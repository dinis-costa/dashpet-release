using DashPetApp.Models;
using DashPetApp.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DashPetApp.Forms
{
    public partial class VetsViewForm : Form
    {
        #region Fields

        private DataClassesDataContext dc;

        private Vet selectedVet;
        private Appointment selectedAppt;

        private GroupBoxUtils gbUtils;
        private byte saveMode;

        #endregion

        #region Load Events

        public VetsViewForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            dc = new DataClassesDataContext();
            gbUtils = new GroupBoxUtils();
        }
        private void VetsViewForm_Load(object sender, EventArgs e)
        {
            cb_VetRoom.DataSource = dc.GetActiveRooms();

            cb_ApptService.DataSource = dc.GetActiveServices();

            dg_Appts.DataSource = dc.GetActiveAppts();
            dg_Appts.Columns[0].HeaderText = "ID";
            dg_Appts.Columns[1].Visible = false;
            dg_Appts.Columns[2].Visible = false;
            dg_Appts.Columns[3].HeaderText = "Date";
            dg_Appts.Columns[4].Visible = false;
            dg_Appts.Columns[5].Visible = false;
            dg_Appts.Columns[6].Visible = false;
            dg_Appts.Columns[7].Visible = false;
            dg_Appts.Columns[8].Visible = false;
            dg_Appts.Columns[9].Visible = false;
            dg_Appts.Columns[10].HeaderText = "Time";
            dg_Appts.Columns[11].Visible = false;

            RefreshVets();
            dg_Vets.Columns[0].Visible = false;
            dg_Vets.Columns[1].HeaderText = "Name";
            dg_Vets.Columns[2].Visible = false;
            dg_Vets.Columns[3].HeaderText = "Phone";
            dg_Vets.Columns[3].HeaderText = "Email";
            dg_Vets.Columns[5].Visible = false;
            dg_Vets.Columns[6].Visible = false;

            RefreshRooms();

            saveMode = 0;
            Cursor.Current = Cursors.Default;
        }

        #endregion

        #region Selection Events

        private void dg_Vets_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_Vets.CurrentRow != null)
            {
                selectedVet = dg_Vets.CurrentRow.DataBoundItem as Vet;
                bt_EditVet.Enabled = true;
                PopulateVetInfo();

                selectedAppt = null;
                RefreshAppts();
                if (selectedAppt != null) gb_ApptInfo.Enabled = true;
            }
        }
        private void dg_Appts_SelectionChanged(object sender, EventArgs e) // Also triggers on DataSourceChanged.
        {
            gbUtils.ClearGroupBox(gb_ApptInfo);
            bt_EditAppt.Enabled = false;
            bt_DelAppt.Enabled = false;
            if (dg_Appts.CurrentRow != null)
            {
                selectedAppt = dg_Appts.CurrentRow.DataBoundItem as Appointment;
                bt_EditAppt.Enabled = true;
                bt_DelAppt.Enabled = true;
                PopulateApptInfo();

                if (selectedAppt.appt_status)
                {
                    bt_EditAppt.Enabled = false;
                    bt_DelAppt.Enabled = false;
                }
            }
        }
        private void dt_ApptDate_ValueChanged(object sender, EventArgs e)
        {
            cb_ApptSlot.DataSource = dc.GetTimeSlots(dt_ApptDate.Value, selectedAppt);
        }
        private void cb_ApptSlot_SelectedIndexChanged(object sender, EventArgs e) // Also triggers on DataSourceChanged.
        {
            cb_ApptVet.DataSource = dc.GetVetSlots(dt_ApptDate.Value, selectedAppt, cb_ApptSlot.Text);
        }
        private void cb_ApptFilter_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAppts();
        }

        #endregion

        #region Button Events

        #region Vet Buttons

        private void bt_NewVet_Click(object sender, EventArgs e)
        {
            gbUtils.NewClickBehavior(sender, gb_VetInfo);
            saveMode = 1;
        }
        private void bt_EditVet_Click(object sender, EventArgs e)
        {
            gbUtils.EditClickBehavior(sender, gb_VetInfo);
            saveMode = 2;
        }
        private void bt_CancelVet_Click(object sender, EventArgs e)
        {
            gbUtils.ButtonsMode((Button)sender);
            bt_EditVet.Enabled = false;

            gbUtils.EnableGroupBoxes(gb_VetInfo, true);
            gb_ApptInfo.Enabled = false;

            gbUtils.ClearGroupBox(gb_VetInfo);
            gbUtils.MakeFieldsWritable(false, gb_VetInfo);

            RefreshVets();

            saveMode = 0;
        }
        private void bt_SaveVet_Click(object sender, EventArgs e)
        {
            if (gbUtils.Validate(gb_VetInfo))
            {
                gbUtils.ButtonsMode((sender as Button));

                gbUtils.EnableGroupBoxes(gb_VetInfo, true);
                gb_ApptInfo.Enabled = false;

                if (saveMode == 1)
                    dc.CreateVet(tb_VetName.Text, tb_VetDoc.Text, tb_VetEmail.Text, tb_VetPhone.Text, (Room)cb_VetRoom.SelectedItem);
                else if (saveMode == 2)
                    dc.EditVet(selectedVet, tb_VetName.Text, tb_VetDoc.Text, tb_VetEmail.Text, tb_VetPhone.Text, (Room)cb_VetRoom.SelectedItem);

                gbUtils.MakeFieldsWritable(false, gb_VetInfo);

                RefreshVets();

                saveMode = 0;
            }
        }
        private async void bt_DelVetDailyAppt_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete the daily appointments for {selectedVet.vet_name}?", "Warning!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {

                dg_Appts.ClearSelection();
                foreach (var item in dc.GetActiveVetAppts(selectedVet).Where(a => a.appt_date == DateTime.Now.Date))
                {
                    await dc.DelAppt(item);
                }
                dg_Appts.ClearSelection();

                bt_DelAppt.Enabled = false;
                bt_EditAppt.Enabled = false;

                RefreshAppts();
            }
        }
        private async void bt_DelVetAllAppt_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete all appointments for {selectedVet.vet_name}?", "Warning!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                //var vetAllAppts = dc.GetActiveVetAppts(selectedVet);

                dg_Appts.ClearSelection();

                foreach (var item in dc.GetActiveVetAppts(selectedVet))
                {
                    await dc.DelAppt(item);
                }
                dg_Appts.ClearSelection();

                bt_DelAppt.Enabled = false;
                bt_EditAppt.Enabled = false;

                RefreshAppts();
            }
        }
        #endregion

        #region Appointment Buttons

        private void bt_EditAppt_Click(object sender, EventArgs e)
        {
            gbUtils.EditClickBehavior(sender, gb_ApptInfo);
            saveMode = 2;
        }
        private void bt_CancelAppt_Click(object sender, EventArgs e)
        {
            gbUtils.ButtonsMode((Button)sender);
            bt_EditAppt.Enabled = false;
            bt_DelAppt.Enabled = false;

            gbUtils.EnableGroupBoxes(gb_ApptInfo, true);

            gbUtils.MakeFieldsWritable(false, gb_ApptInfo);
            gbUtils.ClearGroupBox(gb_ApptInfo);
            RefreshAppts();
            PopulateApptInfo();

            saveMode = 0;
        }
        private async void bt_SaveAppt_Click(object sender, EventArgs e)
        {
            if (gbUtils.Validate(gb_ApptInfo))
            {
                gbUtils.ButtonsMode((Button)sender);
                bt_EditAppt.Enabled = false;

                gbUtils.EnableGroupBoxes(gb_ApptInfo, true);

                if (saveMode == 2)
                    await dc.EditAppt(selectedAppt, (Vet)cb_ApptVet.SelectedItem, dt_ApptDate.Value.Date, (TimeSlot)cb_ApptSlot.SelectedItem, 
                        (Service)cb_ApptService.SelectedItem, tb_ApptNotes.Text);


                RefreshAppts();
                gbUtils.MakeFieldsWritable(false, gb_ApptInfo);
                saveMode = 0;
            }
        }
        private async void bt_DelAppt_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the selected appointment?", "Warning!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                dg_Appts.ClearSelection();
                await dc.DelAppt(selectedAppt);
                bt_DelAppt.Enabled = false;
                RefreshAppts();
            }
        }

        #endregion

        #endregion

        #region Object Methods

        #region Vet Methods

        private void RefreshVets()
        {
            dg_Vets.DataSource = dc.GetActiveVets();
            RefreshRooms();
        }
        private void PopulateVetInfo()
        {
            if (selectedVet != null)
            {
                tb_VetId.Text = selectedVet.vet_id.ToString();
                tb_VetName.Text = selectedVet.vet_name;
                tb_VetDoc.Text = selectedVet.vet_doc;
                tb_VetPhone.Text = selectedVet.vet_phone;
                tb_VetEmail.Text = selectedVet.vet_email;
                cb_VetRoom.SelectedItem = selectedVet.Room;
                if (selectedVet.Room == null || selectedVet.Room.room_status == false)
                {
                    cb_VetRoom.SelectedIndex = -1;
                }
            }
        }

        #endregion

        #region Appointment Methods

        private void RefreshAppts()
        {
            if (selectedVet != null)
            {
                if (cb_ApptFilter.Checked)
                    dg_Appts.DataSource = dc.GetAllAVetAppts(selectedVet);
                else dg_Appts.DataSource = dc.GetActiveVetAppts(selectedVet);
            }
        }
        private void PopulateApptInfo()
        {
            if (selectedAppt != null)
            {
                tb_ApptPet.Text = selectedAppt.Pet.pet_name;
                dt_ApptDate.Value = selectedAppt.appt_date;
                cb_ApptSlot.Text = selectedAppt.TimeSlot.timeslot_time;
                cb_ApptVet.Text = selectedAppt.Vet.vet_name;
                tb_ApptNotes.Text = selectedAppt.appt_notes;
                cb_ApptService.Text = selectedAppt.Service.ToString();
                tb_ApptOwner.Text = selectedAppt.Pet.Owner.owner_name;
            }
        }

        #endregion

        /// <summary>
        /// Populates active room with active vets and displays.
        /// </summary>
        private void RefreshRooms()
        {
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
    }
}
