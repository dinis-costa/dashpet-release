using DashPetApp.Models;
using DashPetApp.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DashPetApp.Forms
{
    public partial class InternalViewForm : Form
    {
        #region Fields

        private DataClassesDataContext dc;

        private Room selectedRoom;
        private Owner selectedOwner;
        private Service selectedService;

        private MailDefinition email;
        private GroupBoxUtils gbUtils;
        private byte saveMode;

        #endregion

        #region Load Events
        public InternalViewForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            dc = new DataClassesDataContext();
            gbUtils = new GroupBoxUtils();
            email = new MailDefinition();
        }
        private void InternalViewForm_Load(object sender, EventArgs e)
        {
            lb_PriceSymb.Text = NumberFormatInfo.CurrentInfo.CurrencySymbol; // For '€' and '$' for e.g..
            RefreshRooms();
            RefreshServices();


            dt_ScheduleReminder.Format = DateTimePickerFormat.Custom;
            dt_ScheduleReminder.CustomFormat = "HH:mm";

            try
            {
                dt_ScheduleReminder.Value = DateTime.ParseExact(File.ReadAllText(@".\reminder_time.txt"), "HH:mm", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                dt_ScheduleReminder.Value = DateTime.ParseExact("00:00", "HH:mm", CultureInfo.InvariantCulture);
            }

            dg_Services.DataSource = dc.Services;
            dg_Rooms.DataSource = dc.Rooms;
            dg_Vets.DataSource = dc.Vets;
            dg_Owners.DataSource = dc.Owners;
            dg_Pets.DataSource = dc.Pets;

            dg_Owners.Columns[0].HeaderText = "ID";
            dg_Owners.Columns[1].HeaderText = "Name";
            dg_Owners.Columns[2].HeaderText = "Document";
            dg_Owners.Columns[3].HeaderText = "Phone";
            dg_Owners.Columns[4].Visible = false;
            dg_Owners.Columns[5].HeaderText = "Email";
            dg_Owners.Columns[6].HeaderText = "Status";
            dg_Owners.Columns[7].Visible = false;

            dg_Pets.Columns[0].Visible = false;
            dg_Pets.Columns[1].Visible = false;
            dg_Pets.Columns[2].HeaderText = "Name";
            dg_Pets.Columns[3].Visible = false;
            dg_Pets.Columns[4].Visible = false;
            dg_Pets.Columns[5].Visible = false;
            dg_Pets.Columns[6].Visible = false;
            dg_Pets.Columns[7].Visible = false;
            dg_Pets.Columns[8].HeaderText = "Status";
            dg_Pets.Columns[9].Visible = false;
            dg_Pets.Columns[10].HeaderText = "Species";
            dg_Pets.Columns[11].Visible = false;

            dg_Vets.Columns[0].HeaderText = "ID";
            dg_Vets.Columns[1].HeaderText = "Name";
            dg_Vets.Columns[2].HeaderText = "Document";
            dg_Vets.Columns[3].HeaderText = "Phone";
            dg_Vets.Columns[4].HeaderText = "Email";
            dg_Vets.Columns[5].Visible = false;
            dg_Vets.Columns[6].HeaderText = "Status";

            dg_Rooms.Columns[0].Visible = false;
            dg_Rooms.Columns[1].HeaderText = "Name";
            dg_Rooms.Columns[2].HeaderText = "Status";

            dg_Services.Columns[0].Visible = false;
            dg_Services.Columns[1].HeaderText = "Name";
            dg_Services.Columns[2].HeaderText = "Price";
            dg_Services.Columns[3].HeaderText = "Status";

            string[] files = Directory.GetFiles(@".\EmailTemplates\General");
            foreach (string file in files)
                cb_Template.Items.Add(Path.GetFileNameWithoutExtension(file));

            if (cb_Template.Items.Count == 0)
            {
                bt_Clipboard.Enabled = false;
                bt_SendEmail.Enabled = false;
            }
            else cb_Template.SelectedIndex = 0;
        }

        #endregion

        #region Selection Events

        private void dg_Owners_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_Owners.CurrentRow != null)
            {
                selectedOwner = dg_Owners.CurrentRow.DataBoundItem as Owner;

                dg_Pets.DataSource = dc.Pets.Where(p => p.pet_owner_id == selectedOwner.owner_id); // Populates with selected owner pets.
            }
        }
        private void tv_Rooms_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedRoom = null;

            tb_RoomName.Text = string.Empty;
            var selection = tv_Rooms.SelectedNode;

            if (selection.Parent == null)
            {
                selectedRoom = dc.Rooms.First(room => room.room_name == selection.Text);
                tb_RoomName.Text = selectedRoom.room_name;
                bt_EditRoom.Enabled = true;
            }
            else bt_EditRoom.Enabled = false;
        }
        private void lb_Services_SelectedIndexChanged(object sender, EventArgs e) // Also triggers on DataSourceChanged.
        {
            if (lb_Services.SelectedItem != null)
            {
                selectedService = lb_Services.SelectedItem as Service;

                tb_ServiceName.Text = selectedService.service_name;
                tb_ServicePrice.Text = selectedService.service_price.ToString();
                bt_EditService.Enabled = true;
            }
            else bt_EditService.Enabled = false;
        }

        /// <summary>
        /// This is a general event for when the column that identifies the "status" is clicked.
        /// When the cell content is clicked it passes the selected object status to be switched.
        /// </summary>
        private async void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).CurrentRow != null)
            {
                object selectedObject = null;

                switch ((sender as DataGridView).Name)
                {
                    case "dg_Owners": selectedObject = (sender as DataGridView).CurrentRow.DataBoundItem as Owner; break;
                    case "dg_Pets": selectedObject = (sender as DataGridView).CurrentRow.DataBoundItem as Pet; break;
                    case "dg_Vets": selectedObject = (sender as DataGridView).CurrentRow.DataBoundItem as Vet; break;
                    case "dg_Rooms": selectedObject = (sender as DataGridView).CurrentRow.DataBoundItem as Room; break;
                    case "dg_Services": selectedObject = (sender as DataGridView).CurrentRow.DataBoundItem as Service; break;
                }


                if (selectedObject != null)
                {
                    var colIndex = (sender as DataGridView).CurrentCell.ColumnIndex;

                    if ((sender as DataGridView).Columns[colIndex].Name.Contains("status"))
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to enable/disable this element?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            switch (selectedObject.GetType().Name)
                            {
                                case "Owner": await dc.OwnerStatusSwitch(selectedObject as Owner); break;
                                case "Pet": await dc.PetStatusSwitch(selectedObject as Pet); break;
                                case "Vet": await dc.VetStatusSwitch(selectedObject as Vet); break;
                                case "Room": dc.RoomStatusSwitch(selectedObject as Room); break;
                                case "Service": await dc.ServiceStatusSwitch(selectedObject as Service); break;
                            }
                            RefreshRooms();
                            RefreshServices();
                        }
                    }
                }
            }
        }

        #endregion


        /// <summary>
        /// Button events behave generally the same between forms, refer to CustomerViewForm for in depth comments.
        /// </summary>
        #region Button Events

        #region Mailing Buttons

        /// <summary>
        /// Sends email to active owners.
        /// </summary>
        private async void bt_SendEmail_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Are you sure you want to send the email?", "Warning!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string mailingList = string.Empty;

                foreach (var recipient in dc.GetMailingList())
                {
                    mailingList += recipient + ","; // Separates each email on the string.
                }

                if (mailingList != string.Empty)
                {
                    mailingList = mailingList.Remove(mailingList.Length - 1); // In case the mailing list is empty.
                }
                else return;

                await email.SendGeneralEmail(mailingList, cb_Template.Text); // Sends email to selected recipients.

            }
        }

        /// <summary>
        /// Gets active owner mailing list to clipboard.
        /// </summary>
        private void bt_Clipboard_Click(object sender, EventArgs e)
        {
            string mailingList = string.Empty;

            foreach (var recipient in dc.GetMailingList())
            {
                mailingList += recipient + ";";
            }

            Clipboard.SetDataObject(mailingList);
        }

        #endregion

        #region Room Buttons
        private void bt_NewRoom_Click(object sender, EventArgs e)
        {
            gbUtils.NewClickBehavior(sender, gb_RoomInfo);
            saveMode = 1;
        }
        private void bt_EditRoom_Click(object sender, EventArgs e)
        {
            gbUtils.EditClickBehavior(sender, gb_RoomInfo);
            saveMode = 2;
        }
        private void bt_CancelRoom_Click(object sender, EventArgs e)
        {
            gbUtils.ButtonsMode((Button)sender);
            bt_EditRoom.Enabled = false;

            gbUtils.EnableGroupBoxes(gb_RoomInfo, true);

            gbUtils.ClearGroupBox(gb_RoomInfo);
            gbUtils.MakeFieldsWritable(false, gb_RoomInfo);

            RefreshRooms();

            saveMode = 0;
        }
        private void bt_SaveRoom_Click(object sender, EventArgs e)
        {
            if (gbUtils.Validate(gb_RoomInfo) &&
                ((saveMode == 1 && dc.Rooms.Count(r => r.room_name == tb_RoomName.Text) == 0) ||
                (saveMode == 2 && dc.Rooms.Count(r => r.room_name == tb_RoomName.Text) < 1))
                )
            {
                gbUtils.ButtonsMode((sender as Button));

                gbUtils.EnableGroupBoxes(gb_RoomInfo, true);

                if (saveMode == 1) dc.CreateRoom(tb_RoomName.Text);
                else if (saveMode == 2) dc.EditRoom(selectedRoom, tb_RoomName.Text);

                gbUtils.MakeFieldsWritable(false, gb_RoomInfo);

                RefreshRooms();

                saveMode = 0;


                tb_RoomName.Text = string.Empty;
                selectedRoom = null;
            }
            else MessageBox.Show("Invalid Name field.");

            dg_Rooms.DataSource = null;
            dg_Rooms.DataSource = from Room in dc.Rooms
                                  select Room;
            dg_Rooms.Columns[0].Visible = false;
            dg_Rooms.Columns[1].HeaderText = "Name";
            dg_Rooms.Columns[2].HeaderText = "Status";
        }
        #endregion

        #region Service Buttons

        private void bt_NewService_Click(object sender, EventArgs e)
        {
            gbUtils.NewClickBehavior(sender, gb_ServiceInfo);
            saveMode = 1;
        }
        private void bt_EditService_Click(object sender, EventArgs e)
        {
            gbUtils.EditClickBehavior(sender, gb_ServiceInfo);
            saveMode = 2;
        }
        private void bt_CancelService_Click(object sender, EventArgs e)
        {
            gbUtils.ButtonsMode((Button)sender);
            bt_EditService.Enabled = false;

            gbUtils.EnableGroupBoxes(gb_ServiceInfo, true);

            gbUtils.ClearGroupBox(gb_ServiceInfo);
            gbUtils.MakeFieldsWritable(false, gb_ServiceInfo);

            RefreshServices();

            saveMode = 0;
        }
        private void bt_SaveService_Click(object sender, EventArgs e)
        {
            if (gbUtils.Validate(gb_ServiceInfo))
            {
                gbUtils.ButtonsMode((sender as Button));

                gbUtils.EnableGroupBoxes(gb_ServiceInfo, true);

                if (saveMode == 1) dc.CreateService(tb_ServiceName.Text, tb_ServicePrice.Text);
                else if (saveMode == 2) dc.EditService(selectedService, tb_ServiceName.Text, tb_ServicePrice.Text);

                gbUtils.MakeFieldsWritable(false, gb_ServiceInfo);

                RefreshServices();

                saveMode = 0;

                lb_Services.ClearSelected();

                tb_ServiceName.Text = string.Empty;
                tb_ServicePrice.Text = string.Empty;
                selectedService = null;
            }

            // Refreshes in-form services table.
            dg_Services.DataSource = null;
            dg_Services.DataSource = from Service in dc.Services
                                  select Service;
            dg_Services.Columns[0].Visible = false;
            dg_Services.Columns[1].HeaderText = "Name";
            dg_Services.Columns[2].HeaderText = "Price";
            dg_Services.Columns[3].HeaderText = "Status";
        }

        #endregion

        #endregion

        #region Object Methods

        private void RefreshServices()
        {
            // Gets active services.
            lb_Services.DataSource = dc.Services.Where(s => s.service_status);
        }

        private void RefreshRooms() // Refreshes Rooms & Vets.
        {
            selectedRoom = null;
            bt_EditRoom.Enabled = false;

            tv_Rooms.Nodes.Clear();
            foreach (Room room in dc.Rooms.Where(r => r.room_status))
            {
                tv_Rooms.Nodes.Add(room.room_name);
            }

            foreach (Vet vet in dc.Vets.Where(v => v.vet_status))
            {
                if (vet.Room != null)
                {
                    foreach (TreeNode tn in tv_Rooms.Nodes)
                    {
                        if (tn.Text == vet.Room.room_name)
                        {
                            tn.Nodes.Add($"{vet.vet_name}");
                        }
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// Changes the time to send reminders emails as it's being changed.
        /// </summary>
        private void dt_ScheduleReminder_ValueChanged(object sender, EventArgs e)
        {
            File.WriteAllText(@".\reminder_time.txt", dt_ScheduleReminder.Value.ToString("HH:mm"));
        }

        /// <summary>
        /// Cancel Appointments for the day.
        /// </summary>
        private async void bt_CancelDayAppts_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete the appointments for the day?", "Warning!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                foreach (var appt in dc.Appointments.Where(a=> !a.appt_status && a.appt_date == DateTime.Now.Date))
                {
                    await dc.DelAppt(appt);
                }
            }
        }
    }
}
