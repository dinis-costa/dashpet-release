using DashPetApp.Models;
using DashPetApp.Services;
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DashPetApp.Forms
{
    public partial class CustomersViewForm : Form
    {
        #region Fields
        private DataClassesDataContext dc; // Linq data context.

        private Owner selectedOwner; // The owner currently selected.
        private Pet selectedPet; // The pet currently selected.
        private Appointment selectedAppt; // The appointment currently selected.

        private GroupBoxUtils gbUtils; // GroupBox utilities class - refer for in-depth method comments.
        private byte saveMode; // 1- Create; 2 - Edit. Defines the condition to be used when Save buttons are pressed.
        #endregion

        #region Load Events
        public CustomersViewForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            dc = new DataClassesDataContext();
            gbUtils = new GroupBoxUtils();
        }
        private void CustomersViewForm_Load(object sender, EventArgs e)
        {
            // Populates all controls with respective data and data sources.

            cb_ApptService.DataSource = dc.GetActiveServices();

            cb_PetSex.DataSource = new string[] { "M", "F", "N/A" };

            cb_AnimalClass.DataSource = dc.AnimalClasses;

            dg_Appts.DataSource = dc.GetActiveAppts();
            dg_Appts.Columns[0].HeaderText = "ID";
            dg_Appts.Columns[1].Visible = false;
            dg_Appts.Columns[2].Visible = false;
            dg_Appts.Columns[3].HeaderText = "Date";
            dg_Appts.Columns[4].Visible = false;
            dg_Appts.Columns[5].Visible = false;
            dg_Appts.Columns[6].Visible = false;
            dg_Appts.Columns[7].Visible = false;
            dg_Appts.Columns[9].Visible = false;
            dg_Appts.Columns[10].HeaderText = "Time";
            dg_Appts.Columns[11].Visible = false;

            cb_ApptService.DataSource = dc.GetActiveServices();

            RefreshOwners();
            dg_Owners.Columns[0].Visible = false;
            dg_Owners.Columns[1].HeaderText = "Name";
            dg_Owners.Columns[2].HeaderText = "Document";
            dg_Owners.Columns[3].HeaderText = "Phone";
            dg_Owners.Columns[4].Visible = false;
            dg_Owners.Columns[5].HeaderText = "Email";
            dg_Owners.Columns[6].Visible = false;
            dg_Owners.Columns[7].Visible = false;

            // Determines cb_Search.Items as visible headers of dg_Owners.Columns.
            foreach (DataGridViewColumn col in dg_Owners.Columns)
            {
                if (col.Visible) cb_Search.Items.Add(col.HeaderText);
            }
            cb_Search.SelectedIndex = 2; // Default to phone number.

            saveMode = 0;
            Cursor.Current = Cursors.Default;

        }

        #endregion

        #region Selection Events

        /// <summary>
        /// Resets selections. Defines selected Owner and populates all data accordingly.
        /// </summary>
        private void dg_Owners_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_Owners.CurrentRow != null)
            {
                selectedOwner = dg_Owners.CurrentRow.DataBoundItem as Owner;
                bt_EditOwner.Enabled = true;
                PopulateOwnerInfo();

                selectedPet = null;
                gb_PetInfo.Enabled = true;
                RefreshPets();

                selectedAppt = null;
                bt_DelAppt.Enabled = false;
                RefreshAppts();
            }
        }

        /// <summary>
        /// Determines selected Pet and populated data fields.
        /// </summary>
        private void cb_Pets_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbUtils.ClearGroupBox(gb_PetInfo);
            if (cb_Pets.SelectedIndex != -1)
            {
                selectedPet = cb_Pets.SelectedItem as Pet;
                bt_EditPet.Enabled = true;
                PopulatePetInfo();

                gb_ApptInfo.Enabled = true;
                bt_NewAppt.Enabled = true;
            }
            else
            {
                bt_EditPet.Enabled = false;

                gb_ApptInfo.Enabled = false;
                bt_NewAppt.Enabled = false;
            }
        }
        
        private void cb_AnimalClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gets animal species according to the selected animal class.
            cb_AnimalSpecies.DataSource = dc.GetAnimalSpecies((AnimalClass)cb_AnimalClass.SelectedItem);
        }

        /// <summary>
        /// Determines selected appointment and button status.
        /// </summary>
        private void dg_Appts_DataSourceOrSelectionChanged(object sender, EventArgs e)
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
            // Gets avaliable TimeSlots for the current date selection.
            cb_ApptSlot.DataSource = dc.GetTimeSlots(dt_ApptDate.Value, selectedAppt);
        }
        private void cb_ApptSlot_DataSourceOrSelectedIndexChanged(object sender, EventArgs e)
        {
            // Gets avaliable Vets for the current selection.
            cb_ApptVet.DataSource = dc.GetVetSlots(dt_ApptDate.Value, selectedAppt, cb_ApptSlot.Text);
        }
        private void cb_ApptFilter_CheckedChanged(object sender, EventArgs e)
        {
            // Refresh when filter is checked/unchecked.
            RefreshAppts();
        }

        #endregion

        /// <summary>
        /// All buttons events across the forms are similar and sometimes exactly the same.
        /// The current code on the form controls behavioral exeptions, especially when it comes to enabling/disabling action/option buttons.
        /// Refer to the methods for further comments.
        /// </summary>
        #region Button Events

        #region Search Buttons
        private void bt_Search_Click(object sender, EventArgs e)
        {
            if (tb_Search.Text != string.Empty)
            {
                Expression<Func<Owner, bool>> searchParameter = null;
                switch (cb_Search.SelectedIndex)
                {
                    case 0: searchParameter = x => x.owner_name.Contains(tb_Search.Text); break;
                    case 1: searchParameter = x => x.owner_doc.Contains(tb_Search.Text); break;
                    case 2: searchParameter = x => x.owner_phone.Contains(tb_Search.Text); break;
                    case 3: searchParameter = x => x.owner_email.Contains(tb_Search.Text); break;
                }
                if (((dg_Owners.DataSource as IQueryable<Owner>).Where(searchParameter)).Count() > 0)
                {
                    dg_Owners.DataSource = (dg_Owners.DataSource as IQueryable<Owner>).Where(searchParameter);
                }
                else
                {
                    MessageBox.Show("No results for search value/parameter combination.");
                }
            }
            else MessageBox.Show("Insert a search value.");
        }
        private void bt_Reset_Click(object sender, EventArgs e)
        {
            RefreshOwners();
            tb_Search.Text = string.Empty;
        }
        #endregion

        #region Owner Buttons
        private void bt_NewOwner_Click(object sender, EventArgs e)
        {
            gbUtils.NewClickBehavior(sender, gb_OwnerInfo);
            saveMode = 1;
        }
        private void bt_EditOwner_Click(object sender, EventArgs e)
        {
            gbUtils.EditClickBehavior(sender, gb_OwnerInfo);
            saveMode = 2;
        }
        private void bt_SaveOwner_Click(object sender, EventArgs e)
        {
            if (gbUtils.Validate(gb_OwnerInfo))
            {
                gbUtils.ButtonsMode((sender as Button));

                gbUtils.EnableGroupBoxes(gb_OwnerInfo, true);
                gb_ApptInfo.Enabled = false;

                if (saveMode == 1) dc.CreateOwner(tb_OwnerName.Text, tb_OwnerAddress.Text, tb_OwnerDoc.Text, tb_OwnerEmail.Text, tb_OwnerPhone.Text);
                else if (saveMode == 2) dc.EditOwner(selectedOwner, tb_OwnerName.Text, tb_OwnerAddress.Text, tb_OwnerDoc.Text, tb_OwnerEmail.Text, tb_OwnerPhone.Text);

                gbUtils.MakeFieldsWritable(false, gb_OwnerInfo);

                RefreshOwners();

                saveMode = 0;
            }
        }
        private void bt_CancelOwner_Click(object sender, EventArgs e)
        {
            gbUtils.ButtonsMode((Button)sender);
            bt_EditOwner.Enabled = false;

            gbUtils.EnableGroupBoxes(gb_OwnerInfo, true);
            gb_PetInfo.Enabled = false;
            gb_ApptInfo.Enabled = false;

            gbUtils.ClearGroupBox(gb_OwnerInfo);
            gbUtils.MakeFieldsWritable(false, gb_OwnerInfo);

            RefreshOwners();

            saveMode = 0;
        }
        #endregion

        #region Pet Buttons
        private void bt_NewPet_Click(object sender, EventArgs e)
        {
            cb_Pets.Enabled = false;
            cb_Pets.SelectedIndex = -1;
            gbUtils.NewClickBehavior(sender, gb_PetInfo);
            saveMode = 1;
        }
        private void bt_EditPet_Click(object sender, EventArgs e)
        {
            cb_Pets.Enabled = false;
            gbUtils.EditClickBehavior(sender, gb_PetInfo);
            saveMode = 2;
        }
        private void bt_SavePet_Click(object sender, EventArgs e)
        {
            if (gbUtils.Validate(gb_PetInfo))
            {
                gbUtils.ButtonsMode((Button)sender);

                gbUtils.EnableGroupBoxes(gb_PetInfo, true);
                cb_Pets.Enabled = true;

                if (saveMode == 1) dc.CreatePet(selectedOwner, tb_PetName.Text, (AnimalSpecies)cb_AnimalSpecies.SelectedItem, dt_PetDob.Value.Date, tb_PetWeight.Text, cb_PetSex.Text, tb_PetNotes.Text);
                else if (saveMode == 2) dc.EditPet(selectedPet, tb_PetName.Text, (AnimalSpecies)cb_AnimalSpecies.SelectedItem, dt_PetDob.Value.Date, tb_PetWeight.Text, cb_PetSex.Text, tb_PetNotes.Text);

                gbUtils.MakeFieldsWritable(false, gb_PetInfo);

                RefreshPets();

                if (cb_Pets.SelectedIndex >= 0) bt_EditPet.Enabled = true;

                saveMode = 0;
            }
        }
        private void bt_CancelPet_Click(object sender, EventArgs e)
        {
            gbUtils.ButtonsMode((Button)sender);

            gbUtils.EnableGroupBoxes(gb_PetInfo, true);
            cb_Pets.Enabled = true;
            gb_ApptInfo.Enabled = false;
            bt_EditPet.Enabled = false;

            gbUtils.MakeFieldsWritable(false, gb_PetInfo);
            gbUtils.ClearGroupBox(gb_PetInfo);
            RefreshPets();
            PopulatePetInfo();

            if (cb_Pets.SelectedItem != null) bt_EditPet.Enabled = true;

            saveMode = 0;
        }
        #endregion

        #region Appointment Buttons
        private void bt_NewAppt_Click(object sender, EventArgs e)
        {
            selectedAppt = null;
            gbUtils.NewClickBehavior(sender, gb_ApptInfo);
            tb_ApptPet.Text = selectedPet.pet_name;
            saveMode = 1;
        }
        private void bt_EditAppt_Click(object sender, EventArgs e)
        {
            gbUtils.EditClickBehavior(sender, gb_ApptInfo);
            saveMode = 2;
        }
        private async void bt_SaveAppt_Click(object sender, EventArgs e)
        {
            if (gbUtils.Validate(gb_ApptInfo))
            {
                gbUtils.ButtonsMode((Button)sender);
                bt_EditAppt.Enabled = false;

                gbUtils.EnableGroupBoxes(gb_ApptInfo, true);

                if (saveMode == 1)
                {
                    await dc.CreateAppt(selectedPet, (Vet)cb_ApptVet.SelectedItem, dt_ApptDate.Value.Date, (TimeSlot)cb_ApptSlot.SelectedItem, (Service)cb_ApptService.SelectedItem, tb_ApptNotes.Text);
                }
                else if (saveMode == 2)
                {
                    await dc.EditAppt(selectedAppt, (Vet)cb_ApptVet.SelectedItem, dt_ApptDate.Value.Date, (TimeSlot)cb_ApptSlot.SelectedItem, (Service)cb_ApptService.SelectedItem, tb_ApptNotes.Text);
                }

                RefreshAppts();
                gbUtils.MakeFieldsWritable(false, gb_ApptInfo);
                saveMode = 0;
            }
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

        #region Pet Methods
        private void PopulatePetInfo()
        {
            if (selectedPet != null)
            {
                tb_PetName.Text = selectedPet.pet_name;
                cb_AnimalClass.SelectedIndex = selectedPet.AnimalSpecies.animalspecies_animalclass_id - 1;
                cb_AnimalSpecies.SelectedIndex = cb_AnimalSpecies.FindStringExact(selectedPet.AnimalSpecies.animalspecies_name);
                cb_PetSex.SelectedIndex = cb_PetSex.FindStringExact(selectedPet.pet_sex);
                dt_PetDob.Value = selectedPet.pet_dob;
                tb_PetWeight.Text = selectedPet.pet_weight;
                tb_PetNotes.Text = selectedPet.pet_notes;
            }
        }
        private void RefreshPets()
        {
            cb_Pets.DataSource = null;
            cb_Pets.DataSource = dc.GetOwnerPets(selectedOwner);
            cb_Pets.DisplayMember = "pet_name";
        }
        #endregion


        /// <summary>
        /// Display active owners and fill the fields correctly.
        /// </summary>
        #region Owner Methods
        private void PopulateOwnerInfo()
        {
            if (selectedOwner != null)
            {
                tb_OwnerId.Text = selectedOwner.owner_id.ToString();
                tb_OwnerName.Text = selectedOwner.owner_name;
                tb_OwnerDoc.Text = selectedOwner.owner_doc;
                tb_OwnerPhone.Text = selectedOwner.owner_phone;
                tb_OwnerAddress.Text = selectedOwner.owner_address;
                tb_OwnerEmail.Text = selectedOwner.owner_email;
            }
        }
        private void RefreshOwners()
        {
            dg_Owners.DataSource = dc.GetActiveOwners();
        }
        #endregion

        /// <summary>
        /// To populate with data and refresh the appointments according to the desired selection by Owner.
        /// </summary>
        #region Appointment Methods
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
            }
        }
        private void RefreshAppts()
        {
            if (selectedOwner != null)
            {
                if (cb_ApptFilter.Checked)
                    dg_Appts.DataSource = dc.GetAllAOwnerAppts(selectedOwner);
                else dg_Appts.DataSource = dc.GetActiveOwnerAppts(selectedOwner);
            }
        }

        #endregion

        #endregion

    }
}
