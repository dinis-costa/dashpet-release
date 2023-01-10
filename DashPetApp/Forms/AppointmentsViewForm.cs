using DashPetApp.Models;
using DashPetApp.Services;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DashPetApp.Forms
{
    public partial class AppointmentsViewForm : Form
    {
        #region Fields

        private DataClassesDataContext dc; // Linq data context.
        private Appointment selectedAppt; // Currently selected Appointment.
        private GroupBoxUtils gbUtils; // GroupBox Methods.
        private byte saveMode; // Determines if the object is being created or edited. 1 - Create; 2 - Edit.

        #endregion

        #region Load Events
        public AppointmentsViewForm()
        {
            InitializeComponent();
            dc = new DataClassesDataContext();
            gbUtils = new GroupBoxUtils();
        }

        private void AppointmentsViewForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(@".\notepad.txt")) // Loads notepad.txt info for the NotePad feature.
                tb_NotePad.Text = File.ReadAllText(@".\notepad.txt");

            cb_ApptService.DataSource = dc.GetActiveServices(); // Gets available services.

            // Populates the table with the current settings.
            dg_Appts.DataSource = dc.Appointments.Where(a => !a.appt_status); // Placeholder.
            dg_Appts.Columns[0].HeaderText = "ID";
            dg_Appts.Columns[1].Visible = false;
            dg_Appts.Columns[2].Visible = false;
            dg_Appts.Columns[3].HeaderText = "Date";
            dg_Appts.Columns[4].Visible = false;
            dg_Appts.Columns[5].Visible = false;
            dg_Appts.Columns[6].Visible = false;
            dg_Appts.Columns[7].HeaderText = "Status";
            dg_Appts.Columns[8].Visible = false;
            dg_Appts.Columns[9].Visible = false;
            dg_Appts.Columns[10].HeaderText = "Time";
            dg_Appts.Columns[11].Visible = false;
            RefreshAppts(); // Refreshes appointments in the grid.
        }

        #endregion

        #region Selection Events
        private void dg_Appts_DataSourceOrSelectionChanged(object sender, EventArgs e) // Also triggers on DataSourceChanged.
        {
            // Default state after selection.
            selectedAppt = null; // Removes the selected Appointment.
            gbUtils.ClearGroupBox(gb_ApptInfo); // Clears GroupBox.
            // Disables action context buttons.
            bt_EditAppt.Enabled = false;
            bt_DelAppt.Enabled = false;
            bt_ConfirmAppt.Enabled = false;

            if (dg_Appts.CurrentRow != null)
            {
                selectedAppt = dg_Appts.CurrentRow.DataBoundItem as Appointment; // Selected Appointment allows action buttons to be enabled:
                bt_EditAppt.Enabled = true;
                bt_DelAppt.Enabled = true;
                bt_ConfirmAppt.Enabled = true;
                PopulateApptInfo(); // Populates the Appointment Info GroupBox with the object info.

                if (selectedAppt.appt_status) // If the appointment was confirmed it doesn't allow the action buttons to be used.
                {
                    bt_EditAppt.Enabled = false;
                    bt_DelAppt.Enabled = false;
                    bt_ConfirmAppt.Enabled = false;
                }

            }
        }

        private void dt_ApptDate_ValueChanged(object sender, EventArgs e)
        {
            // Check .GetTimeSlots() comments.
            cb_ApptSlot.DataSource = dc.GetTimeSlots(dt_ApptDate.Value, selectedAppt);
        }

        private void cb_ApptSlot_DataSourceOrSelectedIndexChanged(object sender, EventArgs e) // Also triggers on DataSourceChanged.
        {
            // Check .GetVetSlots() comments.
            cb_ApptVet.DataSource = dc.GetVetSlots(dt_ApptDate.Value, selectedAppt, cb_ApptSlot.Text);
        }

        /// <summary>
        /// When the date changes it refreshes the currently displayed appointments.
        /// </summary>
        private void dt_SelectedDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshAppts();
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
            // Controls GroupBox behavior when Cancel is pressed. Check method comments for more info.
            gbUtils.ButtonsMode((Button)sender);
            bt_EditAppt.Enabled = false;
            bt_DelAppt.Enabled = false;
            bt_ConfirmAppt.Enabled = false;

            gbUtils.EnableGroupBoxes(gb_ApptInfo, true);

            gbUtils.MakeFieldsWritable(false, gb_ApptInfo);
            gbUtils.ClearGroupBox(gb_ApptInfo);
            RefreshAppts();
            PopulateApptInfo();

            saveMode = 0;
        }

        private async void bt_SaveAppt_Click(object sender, EventArgs e)
        {
            if (gbUtils.Validate(gb_ApptInfo)) // Validates .Tag "fields".
            {
                // Uses GroupBox Utilities class to control GroupBox behavior accordingly, check method comments.
                gbUtils.ButtonsMode((Button)sender);
                bt_EditAppt.Enabled = false;

                gbUtils.EnableGroupBoxes(gb_ApptInfo, true);

                if (saveMode == 2) // Passes object to be editted.
                    await dc.EditAppt(selectedAppt, (Vet)cb_ApptVet.SelectedItem, dt_ApptDate.Value.Date,
                        (TimeSlot)cb_ApptSlot.SelectedItem, (Service)cb_ApptService.SelectedItem, tb_ApptNotes.Text);

                RefreshAppts();
                gbUtils.MakeFieldsWritable(false, gb_ApptInfo);
                saveMode = 0;
            }
        }

        private async void bt_DelAppt_Click(object sender, EventArgs e)
        {
            // Message Box
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the selected appointment?", "Warning!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                dg_Appts.ClearSelection();
                await dc.DelAppt(selectedAppt); // Deletes appointment and send email.
                dg_Appts.ClearSelection();
                bt_DelAppt.Enabled = false;
                bt_ConfirmAppt.Enabled = false;
                RefreshAppts(); // Refresh table.
            }
        }

        private async void bt_ConfirmAppt_Click(object sender, EventArgs e)
        {
            // Confirmation box.
            DialogResult dr = MessageBox.Show("Are you sure you want to confirm the selected appointment as successful?", "Warning!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                // Disables selected action buttons.
                bt_DelAppt.Enabled = false;
                bt_ConfirmAppt.Enabled = false;
                await dc.ConfirmAppt(selectedAppt); // Changes appointment properties and sends email.
                RefreshAppts(); // Refresh to reflect changes.
            }
        }

        #endregion

        #region Appointment Methods

        private void RefreshAppts()
        {
            // Data source corresponds to the appointments that exist on that date.
            dg_Appts.DataSource = dc.GetDateAppts(dt_SelectedDate.Value.Date);
        }
        private void PopulateApptInfo()
        {
            // Selected appointment inhabits controls. 
            if (selectedAppt != null)
            {
                tb_ApptId.Text = selectedAppt.appt_id.ToString();
                tb_ApptPet.Text = selectedAppt.Pet.pet_name;
                dt_ApptDate.Value = selectedAppt.appt_date;
                cb_ApptSlot.Text = selectedAppt.TimeSlot.timeslot_time;
                cb_ApptVet.Text = selectedAppt.Vet.vet_name;
                tb_ApptNotes.Text = selectedAppt.appt_notes;
                tb_PetSpecies.Text = selectedAppt.Pet.AnimalSpecies.animalspecies_name;
                tb_ApptOwner.Text = selectedAppt.Pet.Owner.owner_name;
                cb_ApptService.Text = selectedAppt.Service.ToString();
            }
        }


        #endregion

        /// <summary>
        /// As text is written or deleted it saves it on the file.
        /// </summary>
        private void tb_NotePad_KeyUp(object sender, KeyEventArgs e)
        {
            File.WriteAllText(@".\notepad.txt", tb_NotePad.Text);
        }
    }
}
