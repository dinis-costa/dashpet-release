namespace DashPetApp.Forms
{
    partial class CustomersViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_Owners = new System.Windows.Forms.DataGridView();
            this.lb_OwnerId = new System.Windows.Forms.Label();
            this.tb_OwnerId = new System.Windows.Forms.TextBox();
            this.tb_OwnerName = new System.Windows.Forms.TextBox();
            this.lb_OwnerName = new System.Windows.Forms.Label();
            this.tb_OwnerDoc = new System.Windows.Forms.TextBox();
            this.lb_OwnerDoc = new System.Windows.Forms.Label();
            this.tb_OwnerPhone = new System.Windows.Forms.TextBox();
            this.lb_OwnerPhone = new System.Windows.Forms.Label();
            this.tb_OwnerAddress = new System.Windows.Forms.TextBox();
            this.lb_OwnerAddress = new System.Windows.Forms.Label();
            this.tb_OwnerEmail = new System.Windows.Forms.TextBox();
            this.lb_OwnerEmail = new System.Windows.Forms.Label();
            this.bt_NewOwner = new System.Windows.Forms.Button();
            this.gb_OwnerInfo = new System.Windows.Forms.GroupBox();
            this.bt_CancelOwner = new System.Windows.Forms.Button();
            this.bt_EditOwner = new System.Windows.Forms.Button();
            this.bt_SaveOwner = new System.Windows.Forms.Button();
            this.cb_Pets = new System.Windows.Forms.ComboBox();
            this.gb_PetInfo = new System.Windows.Forms.GroupBox();
            this.tb_PetName = new System.Windows.Forms.TextBox();
            this.lb_PetName = new System.Windows.Forms.Label();
            this.bt_CancelPet = new System.Windows.Forms.Button();
            this.lb_PetNotes = new System.Windows.Forms.Label();
            this.bt_EditPet = new System.Windows.Forms.Button();
            this.tb_PetNotes = new System.Windows.Forms.TextBox();
            this.bt_SavePet = new System.Windows.Forms.Button();
            this.tb_PetWeight = new System.Windows.Forms.TextBox();
            this.bt_NewPet = new System.Windows.Forms.Button();
            this.lb_PetWeight = new System.Windows.Forms.Label();
            this.lb_PetDob = new System.Windows.Forms.Label();
            this.dt_PetDob = new System.Windows.Forms.DateTimePicker();
            this.lb_PetSex = new System.Windows.Forms.Label();
            this.cb_PetSex = new System.Windows.Forms.ComboBox();
            this.cb_AnimalSpecies = new System.Windows.Forms.ComboBox();
            this.cb_AnimalClass = new System.Windows.Forms.ComboBox();
            this.lb_AnimalSpecies = new System.Windows.Forms.Label();
            this.lb_AnimalClass = new System.Windows.Forms.Label();
            this.dg_Appts = new System.Windows.Forms.DataGridView();
            this.gb_ApptInfo = new System.Windows.Forms.GroupBox();
            this.lb_ApptService = new System.Windows.Forms.Label();
            this.cb_ApptService = new System.Windows.Forms.ComboBox();
            this.bt_DelAppt = new System.Windows.Forms.Button();
            this.lb_ApptVet = new System.Windows.Forms.Label();
            this.cb_ApptVet = new System.Windows.Forms.ComboBox();
            this.tb_ApptPet = new System.Windows.Forms.TextBox();
            this.bt_CancelAppt = new System.Windows.Forms.Button();
            this.lb_ApptNotes = new System.Windows.Forms.Label();
            this.tb_ApptNotes = new System.Windows.Forms.TextBox();
            this.bt_SaveAppt = new System.Windows.Forms.Button();
            this.lb_ApptDate = new System.Windows.Forms.Label();
            this.bt_EditAppt = new System.Windows.Forms.Button();
            this.dt_ApptDate = new System.Windows.Forms.DateTimePicker();
            this.bt_NewAppt = new System.Windows.Forms.Button();
            this.cb_ApptSlot = new System.Windows.Forms.ComboBox();
            this.lb_ApptPet = new System.Windows.Forms.Label();
            this.gb_Owners = new System.Windows.Forms.GroupBox();
            this.gb_SearchOwners = new System.Windows.Forms.GroupBox();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.cb_Search = new System.Windows.Forms.ComboBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.gb_Appointments = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_ApptFilter = new System.Windows.Forms.CheckBox();
            this.lb_WeightSymb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Owners)).BeginInit();
            this.gb_OwnerInfo.SuspendLayout();
            this.gb_PetInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Appts)).BeginInit();
            this.gb_ApptInfo.SuspendLayout();
            this.gb_Owners.SuspendLayout();
            this.gb_SearchOwners.SuspendLayout();
            this.gb_Appointments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_Owners
            // 
            this.dg_Owners.AllowUserToAddRows = false;
            this.dg_Owners.AllowUserToDeleteRows = false;
            this.dg_Owners.AllowUserToOrderColumns = true;
            this.dg_Owners.AllowUserToResizeColumns = false;
            this.dg_Owners.AllowUserToResizeRows = false;
            this.dg_Owners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Owners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_Owners.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dg_Owners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Owners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Owners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Owners.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Owners.Location = new System.Drawing.Point(5, 33);
            this.dg_Owners.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dg_Owners.MultiSelect = false;
            this.dg_Owners.Name = "dg_Owners";
            this.dg_Owners.RowHeadersVisible = false;
            this.dg_Owners.RowHeadersWidth = 51;
            this.dg_Owners.RowTemplate.Height = 24;
            this.dg_Owners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_Owners.Size = new System.Drawing.Size(724, 297);
            this.dg_Owners.TabIndex = 1;
            this.dg_Owners.SelectionChanged += new System.EventHandler(this.dg_Owners_SelectionChanged);
            // 
            // lb_OwnerId
            // 
            this.lb_OwnerId.AutoSize = true;
            this.lb_OwnerId.Location = new System.Drawing.Point(63, 100);
            this.lb_OwnerId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_OwnerId.Name = "lb_OwnerId";
            this.lb_OwnerId.Size = new System.Drawing.Size(36, 26);
            this.lb_OwnerId.TabIndex = 1;
            this.lb_OwnerId.Text = "ID:";
            // 
            // tb_OwnerId
            // 
            this.tb_OwnerId.Location = new System.Drawing.Point(109, 97);
            this.tb_OwnerId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_OwnerId.Name = "tb_OwnerId";
            this.tb_OwnerId.ReadOnly = true;
            this.tb_OwnerId.Size = new System.Drawing.Size(263, 34);
            this.tb_OwnerId.TabIndex = 99;
            this.tb_OwnerId.TabStop = false;
            // 
            // tb_OwnerName
            // 
            this.tb_OwnerName.Location = new System.Drawing.Point(108, 143);
            this.tb_OwnerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_OwnerName.Name = "tb_OwnerName";
            this.tb_OwnerName.ReadOnly = true;
            this.tb_OwnerName.Size = new System.Drawing.Size(264, 34);
            this.tb_OwnerName.TabIndex = 2;
            this.tb_OwnerName.Tag = "field,name";
            // 
            // lb_OwnerName
            // 
            this.lb_OwnerName.AutoSize = true;
            this.lb_OwnerName.Location = new System.Drawing.Point(29, 146);
            this.lb_OwnerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_OwnerName.Name = "lb_OwnerName";
            this.lb_OwnerName.Size = new System.Drawing.Size(70, 26);
            this.lb_OwnerName.TabIndex = 3;
            this.lb_OwnerName.Text = "Name:";
            // 
            // tb_OwnerDoc
            // 
            this.tb_OwnerDoc.Location = new System.Drawing.Point(108, 189);
            this.tb_OwnerDoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_OwnerDoc.Name = "tb_OwnerDoc";
            this.tb_OwnerDoc.ReadOnly = true;
            this.tb_OwnerDoc.Size = new System.Drawing.Size(264, 34);
            this.tb_OwnerDoc.TabIndex = 3;
            this.tb_OwnerDoc.Tag = "field,doc";
            // 
            // lb_OwnerDoc
            // 
            this.lb_OwnerDoc.AutoSize = true;
            this.lb_OwnerDoc.Location = new System.Drawing.Point(41, 192);
            this.lb_OwnerDoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_OwnerDoc.Name = "lb_OwnerDoc";
            this.lb_OwnerDoc.Size = new System.Drawing.Size(58, 26);
            this.lb_OwnerDoc.TabIndex = 5;
            this.lb_OwnerDoc.Text = "Doc.:";
            // 
            // tb_OwnerPhone
            // 
            this.tb_OwnerPhone.Location = new System.Drawing.Point(108, 235);
            this.tb_OwnerPhone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_OwnerPhone.Name = "tb_OwnerPhone";
            this.tb_OwnerPhone.ReadOnly = true;
            this.tb_OwnerPhone.Size = new System.Drawing.Size(264, 34);
            this.tb_OwnerPhone.TabIndex = 4;
            this.tb_OwnerPhone.Tag = "field,phone";
            // 
            // lb_OwnerPhone
            // 
            this.lb_OwnerPhone.AutoSize = true;
            this.lb_OwnerPhone.Location = new System.Drawing.Point(25, 238);
            this.lb_OwnerPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_OwnerPhone.Name = "lb_OwnerPhone";
            this.lb_OwnerPhone.Size = new System.Drawing.Size(75, 26);
            this.lb_OwnerPhone.TabIndex = 7;
            this.lb_OwnerPhone.Text = "Phone:";
            // 
            // tb_OwnerAddress
            // 
            this.tb_OwnerAddress.Location = new System.Drawing.Point(108, 327);
            this.tb_OwnerAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_OwnerAddress.Multiline = true;
            this.tb_OwnerAddress.Name = "tb_OwnerAddress";
            this.tb_OwnerAddress.ReadOnly = true;
            this.tb_OwnerAddress.Size = new System.Drawing.Size(264, 111);
            this.tb_OwnerAddress.TabIndex = 6;
            this.tb_OwnerAddress.Tag = "field,address";
            // 
            // lb_OwnerAddress
            // 
            this.lb_OwnerAddress.AutoSize = true;
            this.lb_OwnerAddress.Location = new System.Drawing.Point(10, 330);
            this.lb_OwnerAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_OwnerAddress.Name = "lb_OwnerAddress";
            this.lb_OwnerAddress.Size = new System.Drawing.Size(89, 26);
            this.lb_OwnerAddress.TabIndex = 9;
            this.lb_OwnerAddress.Text = "Address:";
            // 
            // tb_OwnerEmail
            // 
            this.tb_OwnerEmail.Location = new System.Drawing.Point(108, 281);
            this.tb_OwnerEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_OwnerEmail.Name = "tb_OwnerEmail";
            this.tb_OwnerEmail.ReadOnly = true;
            this.tb_OwnerEmail.Size = new System.Drawing.Size(264, 34);
            this.tb_OwnerEmail.TabIndex = 5;
            this.tb_OwnerEmail.Tag = "field,email";
            // 
            // lb_OwnerEmail
            // 
            this.lb_OwnerEmail.AutoSize = true;
            this.lb_OwnerEmail.Location = new System.Drawing.Point(35, 284);
            this.lb_OwnerEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_OwnerEmail.Name = "lb_OwnerEmail";
            this.lb_OwnerEmail.Size = new System.Drawing.Size(64, 26);
            this.lb_OwnerEmail.TabIndex = 11;
            this.lb_OwnerEmail.Text = "Email:";
            // 
            // bt_NewOwner
            // 
            this.bt_NewOwner.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_NewOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NewOwner.Location = new System.Drawing.Point(10, 39);
            this.bt_NewOwner.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_NewOwner.Name = "bt_NewOwner";
            this.bt_NewOwner.Size = new System.Drawing.Size(83, 32);
            this.bt_NewOwner.TabIndex = 7;
            this.bt_NewOwner.Tag = "action";
            this.bt_NewOwner.Text = "New";
            this.bt_NewOwner.UseVisualStyleBackColor = false;
            this.bt_NewOwner.Click += new System.EventHandler(this.bt_NewOwner_Click);
            // 
            // gb_OwnerInfo
            // 
            this.gb_OwnerInfo.Controls.Add(this.bt_CancelOwner);
            this.gb_OwnerInfo.Controls.Add(this.bt_EditOwner);
            this.gb_OwnerInfo.Controls.Add(this.bt_SaveOwner);
            this.gb_OwnerInfo.Controls.Add(this.tb_OwnerId);
            this.gb_OwnerInfo.Controls.Add(this.bt_NewOwner);
            this.gb_OwnerInfo.Controls.Add(this.lb_OwnerId);
            this.gb_OwnerInfo.Controls.Add(this.tb_OwnerEmail);
            this.gb_OwnerInfo.Controls.Add(this.lb_OwnerName);
            this.gb_OwnerInfo.Controls.Add(this.lb_OwnerEmail);
            this.gb_OwnerInfo.Controls.Add(this.tb_OwnerName);
            this.gb_OwnerInfo.Controls.Add(this.tb_OwnerAddress);
            this.gb_OwnerInfo.Controls.Add(this.lb_OwnerDoc);
            this.gb_OwnerInfo.Controls.Add(this.lb_OwnerAddress);
            this.gb_OwnerInfo.Controls.Add(this.tb_OwnerDoc);
            this.gb_OwnerInfo.Controls.Add(this.tb_OwnerPhone);
            this.gb_OwnerInfo.Controls.Add(this.lb_OwnerPhone);
            this.gb_OwnerInfo.Location = new System.Drawing.Point(14, 456);
            this.gb_OwnerInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_OwnerInfo.Name = "gb_OwnerInfo";
            this.gb_OwnerInfo.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_OwnerInfo.Size = new System.Drawing.Size(382, 450);
            this.gb_OwnerInfo.TabIndex = 2;
            this.gb_OwnerInfo.TabStop = false;
            this.gb_OwnerInfo.Text = "Owner Info";
            // 
            // bt_CancelOwner
            // 
            this.bt_CancelOwner.Enabled = false;
            this.bt_CancelOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelOwner.Location = new System.Drawing.Point(196, 39);
            this.bt_CancelOwner.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_CancelOwner.Name = "bt_CancelOwner";
            this.bt_CancelOwner.Size = new System.Drawing.Size(83, 32);
            this.bt_CancelOwner.TabIndex = 9;
            this.bt_CancelOwner.Tag = "option";
            this.bt_CancelOwner.Text = "Canc.";
            this.bt_CancelOwner.UseVisualStyleBackColor = true;
            this.bt_CancelOwner.Click += new System.EventHandler(this.bt_CancelOwner_Click);
            // 
            // bt_EditOwner
            // 
            this.bt_EditOwner.Enabled = false;
            this.bt_EditOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditOwner.Location = new System.Drawing.Point(103, 39);
            this.bt_EditOwner.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_EditOwner.Name = "bt_EditOwner";
            this.bt_EditOwner.Size = new System.Drawing.Size(83, 32);
            this.bt_EditOwner.TabIndex = 8;
            this.bt_EditOwner.Tag = "action";
            this.bt_EditOwner.Text = "Edit";
            this.bt_EditOwner.UseVisualStyleBackColor = true;
            this.bt_EditOwner.Click += new System.EventHandler(this.bt_EditOwner_Click);
            // 
            // bt_SaveOwner
            // 
            this.bt_SaveOwner.Enabled = false;
            this.bt_SaveOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveOwner.Location = new System.Drawing.Point(289, 39);
            this.bt_SaveOwner.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_SaveOwner.Name = "bt_SaveOwner";
            this.bt_SaveOwner.Size = new System.Drawing.Size(83, 32);
            this.bt_SaveOwner.TabIndex = 10;
            this.bt_SaveOwner.Tag = "option";
            this.bt_SaveOwner.Text = "Save";
            this.bt_SaveOwner.UseVisualStyleBackColor = true;
            this.bt_SaveOwner.Click += new System.EventHandler(this.bt_SaveOwner_Click);
            // 
            // cb_Pets
            // 
            this.cb_Pets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Pets.FormattingEnabled = true;
            this.cb_Pets.Location = new System.Drawing.Point(10, 83);
            this.cb_Pets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_Pets.Name = "cb_Pets";
            this.cb_Pets.Size = new System.Drawing.Size(539, 34);
            this.cb_Pets.TabIndex = 12;
            this.cb_Pets.SelectedIndexChanged += new System.EventHandler(this.cb_Pets_SelectedIndexChanged);
            // 
            // gb_PetInfo
            // 
            this.gb_PetInfo.Controls.Add(this.lb_WeightSymb);
            this.gb_PetInfo.Controls.Add(this.tb_PetName);
            this.gb_PetInfo.Controls.Add(this.lb_PetName);
            this.gb_PetInfo.Controls.Add(this.bt_CancelPet);
            this.gb_PetInfo.Controls.Add(this.lb_PetNotes);
            this.gb_PetInfo.Controls.Add(this.bt_EditPet);
            this.gb_PetInfo.Controls.Add(this.tb_PetNotes);
            this.gb_PetInfo.Controls.Add(this.bt_SavePet);
            this.gb_PetInfo.Controls.Add(this.tb_PetWeight);
            this.gb_PetInfo.Controls.Add(this.bt_NewPet);
            this.gb_PetInfo.Controls.Add(this.lb_PetWeight);
            this.gb_PetInfo.Controls.Add(this.lb_PetDob);
            this.gb_PetInfo.Controls.Add(this.dt_PetDob);
            this.gb_PetInfo.Controls.Add(this.lb_PetSex);
            this.gb_PetInfo.Controls.Add(this.cb_PetSex);
            this.gb_PetInfo.Controls.Add(this.cb_AnimalSpecies);
            this.gb_PetInfo.Controls.Add(this.cb_AnimalClass);
            this.gb_PetInfo.Controls.Add(this.lb_AnimalSpecies);
            this.gb_PetInfo.Controls.Add(this.lb_AnimalClass);
            this.gb_PetInfo.Controls.Add(this.cb_Pets);
            this.gb_PetInfo.Enabled = false;
            this.gb_PetInfo.Location = new System.Drawing.Point(406, 456);
            this.gb_PetInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_PetInfo.Name = "gb_PetInfo";
            this.gb_PetInfo.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_PetInfo.Size = new System.Drawing.Size(559, 450);
            this.gb_PetInfo.TabIndex = 11;
            this.gb_PetInfo.TabStop = false;
            this.gb_PetInfo.Text = "Pet Info";
            // 
            // tb_PetName
            // 
            this.tb_PetName.Location = new System.Drawing.Point(99, 129);
            this.tb_PetName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_PetName.Name = "tb_PetName";
            this.tb_PetName.ReadOnly = true;
            this.tb_PetName.Size = new System.Drawing.Size(183, 34);
            this.tb_PetName.TabIndex = 13;
            this.tb_PetName.Tag = "field,handle";
            // 
            // lb_PetName
            // 
            this.lb_PetName.AutoSize = true;
            this.lb_PetName.Location = new System.Drawing.Point(19, 132);
            this.lb_PetName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_PetName.Name = "lb_PetName";
            this.lb_PetName.Size = new System.Drawing.Size(70, 26);
            this.lb_PetName.TabIndex = 115;
            this.lb_PetName.Text = "Name:";
            // 
            // bt_CancelPet
            // 
            this.bt_CancelPet.Enabled = false;
            this.bt_CancelPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelPet.Location = new System.Drawing.Point(285, 39);
            this.bt_CancelPet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_CancelPet.Name = "bt_CancelPet";
            this.bt_CancelPet.Size = new System.Drawing.Size(83, 32);
            this.bt_CancelPet.TabIndex = 23;
            this.bt_CancelPet.Tag = "option";
            this.bt_CancelPet.Text = "Canc.";
            this.bt_CancelPet.UseVisualStyleBackColor = true;
            this.bt_CancelPet.Click += new System.EventHandler(this.bt_CancelPet_Click);
            // 
            // lb_PetNotes
            // 
            this.lb_PetNotes.AutoSize = true;
            this.lb_PetNotes.Location = new System.Drawing.Point(19, 270);
            this.lb_PetNotes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_PetNotes.Name = "lb_PetNotes";
            this.lb_PetNotes.Size = new System.Drawing.Size(70, 26);
            this.lb_PetNotes.TabIndex = 114;
            this.lb_PetNotes.Text = "Notes:";
            // 
            // bt_EditPet
            // 
            this.bt_EditPet.Enabled = false;
            this.bt_EditPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditPet.Location = new System.Drawing.Point(192, 39);
            this.bt_EditPet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_EditPet.Name = "bt_EditPet";
            this.bt_EditPet.Size = new System.Drawing.Size(83, 32);
            this.bt_EditPet.TabIndex = 22;
            this.bt_EditPet.Tag = "action";
            this.bt_EditPet.Text = "Edit";
            this.bt_EditPet.UseVisualStyleBackColor = true;
            this.bt_EditPet.Click += new System.EventHandler(this.bt_EditPet_Click);
            // 
            // tb_PetNotes
            // 
            this.tb_PetNotes.Location = new System.Drawing.Point(99, 267);
            this.tb_PetNotes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_PetNotes.Multiline = true;
            this.tb_PetNotes.Name = "tb_PetNotes";
            this.tb_PetNotes.ReadOnly = true;
            this.tb_PetNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_PetNotes.Size = new System.Drawing.Size(450, 171);
            this.tb_PetNotes.TabIndex = 20;
            this.tb_PetNotes.Tag = "field,notes";
            // 
            // bt_SavePet
            // 
            this.bt_SavePet.Enabled = false;
            this.bt_SavePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SavePet.Location = new System.Drawing.Point(379, 39);
            this.bt_SavePet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_SavePet.Name = "bt_SavePet";
            this.bt_SavePet.Size = new System.Drawing.Size(83, 32);
            this.bt_SavePet.TabIndex = 24;
            this.bt_SavePet.Tag = "option";
            this.bt_SavePet.Text = "Save";
            this.bt_SavePet.UseVisualStyleBackColor = true;
            this.bt_SavePet.Click += new System.EventHandler(this.bt_SavePet_Click);
            // 
            // tb_PetWeight
            // 
            this.tb_PetWeight.Location = new System.Drawing.Point(99, 217);
            this.tb_PetWeight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_PetWeight.Name = "tb_PetWeight";
            this.tb_PetWeight.ReadOnly = true;
            this.tb_PetWeight.Size = new System.Drawing.Size(140, 34);
            this.tb_PetWeight.TabIndex = 19;
            this.tb_PetWeight.Tag = "field,float";
            // 
            // bt_NewPet
            // 
            this.bt_NewPet.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_NewPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NewPet.Location = new System.Drawing.Point(99, 39);
            this.bt_NewPet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_NewPet.Name = "bt_NewPet";
            this.bt_NewPet.Size = new System.Drawing.Size(83, 32);
            this.bt_NewPet.TabIndex = 21;
            this.bt_NewPet.Tag = "action";
            this.bt_NewPet.Text = "New";
            this.bt_NewPet.UseVisualStyleBackColor = false;
            this.bt_NewPet.Click += new System.EventHandler(this.bt_NewPet_Click);
            // 
            // lb_PetWeight
            // 
            this.lb_PetWeight.AutoSize = true;
            this.lb_PetWeight.Location = new System.Drawing.Point(10, 220);
            this.lb_PetWeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_PetWeight.Name = "lb_PetWeight";
            this.lb_PetWeight.Size = new System.Drawing.Size(79, 26);
            this.lb_PetWeight.TabIndex = 111;
            this.lb_PetWeight.Text = "Weight:";
            // 
            // lb_PetDob
            // 
            this.lb_PetDob.AutoSize = true;
            this.lb_PetDob.Location = new System.Drawing.Point(29, 179);
            this.lb_PetDob.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_PetDob.Name = "lb_PetDob";
            this.lb_PetDob.Size = new System.Drawing.Size(60, 26);
            this.lb_PetDob.TabIndex = 110;
            this.lb_PetDob.Text = "DOB:";
            // 
            // dt_PetDob
            // 
            this.dt_PetDob.Enabled = false;
            this.dt_PetDob.Font = new System.Drawing.Font("Ubuntu Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_PetDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_PetDob.Location = new System.Drawing.Point(99, 174);
            this.dt_PetDob.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dt_PetDob.Name = "dt_PetDob";
            this.dt_PetDob.Size = new System.Drawing.Size(183, 30);
            this.dt_PetDob.TabIndex = 18;
            this.dt_PetDob.Tag = "field,dtp";
            this.dt_PetDob.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            // 
            // lb_PetSex
            // 
            this.lb_PetSex.AutoSize = true;
            this.lb_PetSex.Location = new System.Drawing.Point(329, 132);
            this.lb_PetSex.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_PetSex.Name = "lb_PetSex";
            this.lb_PetSex.Size = new System.Drawing.Size(49, 26);
            this.lb_PetSex.TabIndex = 108;
            this.lb_PetSex.Text = "Sex:";
            // 
            // cb_PetSex
            // 
            this.cb_PetSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PetSex.Enabled = false;
            this.cb_PetSex.FormattingEnabled = true;
            this.cb_PetSex.Location = new System.Drawing.Point(388, 129);
            this.cb_PetSex.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_PetSex.Name = "cb_PetSex";
            this.cb_PetSex.Size = new System.Drawing.Size(161, 34);
            this.cb_PetSex.TabIndex = 17;
            this.cb_PetSex.Tag = "field";
            // 
            // cb_AnimalSpecies
            // 
            this.cb_AnimalSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AnimalSpecies.Enabled = false;
            this.cb_AnimalSpecies.FormattingEnabled = true;
            this.cb_AnimalSpecies.Location = new System.Drawing.Point(388, 221);
            this.cb_AnimalSpecies.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_AnimalSpecies.Name = "cb_AnimalSpecies";
            this.cb_AnimalSpecies.Size = new System.Drawing.Size(161, 34);
            this.cb_AnimalSpecies.TabIndex = 15;
            this.cb_AnimalSpecies.Tag = "field";
            // 
            // cb_AnimalClass
            // 
            this.cb_AnimalClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AnimalClass.Enabled = false;
            this.cb_AnimalClass.FormattingEnabled = true;
            this.cb_AnimalClass.Location = new System.Drawing.Point(388, 175);
            this.cb_AnimalClass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_AnimalClass.Name = "cb_AnimalClass";
            this.cb_AnimalClass.Size = new System.Drawing.Size(161, 34);
            this.cb_AnimalClass.TabIndex = 16;
            this.cb_AnimalClass.Tag = "field";
            this.cb_AnimalClass.SelectedIndexChanged += new System.EventHandler(this.cb_AnimalClass_SelectedIndexChanged);
            // 
            // lb_AnimalSpecies
            // 
            this.lb_AnimalSpecies.AutoSize = true;
            this.lb_AnimalSpecies.Location = new System.Drawing.Point(292, 224);
            this.lb_AnimalSpecies.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_AnimalSpecies.Name = "lb_AnimalSpecies";
            this.lb_AnimalSpecies.Size = new System.Drawing.Size(86, 26);
            this.lb_AnimalSpecies.TabIndex = 104;
            this.lb_AnimalSpecies.Text = "Species:";
            // 
            // lb_AnimalClass
            // 
            this.lb_AnimalClass.AutoSize = true;
            this.lb_AnimalClass.Location = new System.Drawing.Point(315, 178);
            this.lb_AnimalClass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_AnimalClass.Name = "lb_AnimalClass";
            this.lb_AnimalClass.Size = new System.Drawing.Size(63, 26);
            this.lb_AnimalClass.TabIndex = 103;
            this.lb_AnimalClass.Text = "Class:";
            // 
            // dg_Appts
            // 
            this.dg_Appts.AllowUserToAddRows = false;
            this.dg_Appts.AllowUserToDeleteRows = false;
            this.dg_Appts.AllowUserToOrderColumns = true;
            this.dg_Appts.AllowUserToResizeColumns = false;
            this.dg_Appts.AllowUserToResizeRows = false;
            this.dg_Appts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Appts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_Appts.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dg_Appts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Appts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Appts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Appts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Appts.Location = new System.Drawing.Point(5, 33);
            this.dg_Appts.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dg_Appts.MultiSelect = false;
            this.dg_Appts.Name = "dg_Appts";
            this.dg_Appts.RowHeadersVisible = false;
            this.dg_Appts.RowHeadersWidth = 51;
            this.dg_Appts.RowTemplate.Height = 24;
            this.dg_Appts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_Appts.Size = new System.Drawing.Size(773, 297);
            this.dg_Appts.TabIndex = 12;
            this.dg_Appts.DataSourceChanged += new System.EventHandler(this.dg_Appts_DataSourceOrSelectionChanged);
            this.dg_Appts.SelectionChanged += new System.EventHandler(this.dg_Appts_DataSourceOrSelectionChanged);
            // 
            // gb_ApptInfo
            // 
            this.gb_ApptInfo.Controls.Add(this.lb_ApptService);
            this.gb_ApptInfo.Controls.Add(this.cb_ApptService);
            this.gb_ApptInfo.Controls.Add(this.bt_DelAppt);
            this.gb_ApptInfo.Controls.Add(this.lb_ApptVet);
            this.gb_ApptInfo.Controls.Add(this.cb_ApptVet);
            this.gb_ApptInfo.Controls.Add(this.tb_ApptPet);
            this.gb_ApptInfo.Controls.Add(this.bt_CancelAppt);
            this.gb_ApptInfo.Controls.Add(this.lb_ApptNotes);
            this.gb_ApptInfo.Controls.Add(this.tb_ApptNotes);
            this.gb_ApptInfo.Controls.Add(this.bt_SaveAppt);
            this.gb_ApptInfo.Controls.Add(this.lb_ApptDate);
            this.gb_ApptInfo.Controls.Add(this.bt_EditAppt);
            this.gb_ApptInfo.Controls.Add(this.dt_ApptDate);
            this.gb_ApptInfo.Controls.Add(this.bt_NewAppt);
            this.gb_ApptInfo.Controls.Add(this.cb_ApptSlot);
            this.gb_ApptInfo.Controls.Add(this.lb_ApptPet);
            this.gb_ApptInfo.Enabled = false;
            this.gb_ApptInfo.Location = new System.Drawing.Point(975, 456);
            this.gb_ApptInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_ApptInfo.Name = "gb_ApptInfo";
            this.gb_ApptInfo.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_ApptInfo.Size = new System.Drawing.Size(566, 450);
            this.gb_ApptInfo.TabIndex = 116;
            this.gb_ApptInfo.TabStop = false;
            this.gb_ApptInfo.Text = "Appointment Info";
            // 
            // lb_ApptService
            // 
            this.lb_ApptService.AutoSize = true;
            this.lb_ApptService.Location = new System.Drawing.Point(19, 224);
            this.lb_ApptService.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptService.Name = "lb_ApptService";
            this.lb_ApptService.Size = new System.Drawing.Size(82, 26);
            this.lb_ApptService.TabIndex = 122;
            this.lb_ApptService.Text = "Service:";
            // 
            // cb_ApptService
            // 
            this.cb_ApptService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ApptService.Enabled = false;
            this.cb_ApptService.FormattingEnabled = true;
            this.cb_ApptService.Location = new System.Drawing.Point(111, 221);
            this.cb_ApptService.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_ApptService.Name = "cb_ApptService";
            this.cb_ApptService.Size = new System.Drawing.Size(445, 34);
            this.cb_ApptService.TabIndex = 121;
            this.cb_ApptService.Tag = "field";
            // 
            // bt_DelAppt
            // 
            this.bt_DelAppt.Enabled = false;
            this.bt_DelAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DelAppt.Location = new System.Drawing.Point(430, 39);
            this.bt_DelAppt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_DelAppt.Name = "bt_DelAppt";
            this.bt_DelAppt.Size = new System.Drawing.Size(90, 32);
            this.bt_DelAppt.TabIndex = 120;
            this.bt_DelAppt.Tag = "action";
            this.bt_DelAppt.Text = "Delete";
            this.bt_DelAppt.UseVisualStyleBackColor = true;
            this.bt_DelAppt.Click += new System.EventHandler(this.bt_DelAppt_Click);
            // 
            // lb_ApptVet
            // 
            this.lb_ApptVet.AutoSize = true;
            this.lb_ApptVet.Location = new System.Drawing.Point(53, 178);
            this.lb_ApptVet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptVet.Name = "lb_ApptVet";
            this.lb_ApptVet.Size = new System.Drawing.Size(48, 26);
            this.lb_ApptVet.TabIndex = 119;
            this.lb_ApptVet.Text = "Vet:";
            // 
            // cb_ApptVet
            // 
            this.cb_ApptVet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ApptVet.Enabled = false;
            this.cb_ApptVet.FormattingEnabled = true;
            this.cb_ApptVet.Location = new System.Drawing.Point(111, 175);
            this.cb_ApptVet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_ApptVet.Name = "cb_ApptVet";
            this.cb_ApptVet.Size = new System.Drawing.Size(445, 34);
            this.cb_ApptVet.TabIndex = 118;
            this.cb_ApptVet.Tag = "field";
            // 
            // tb_ApptPet
            // 
            this.tb_ApptPet.Location = new System.Drawing.Point(111, 85);
            this.tb_ApptPet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ApptPet.Name = "tb_ApptPet";
            this.tb_ApptPet.ReadOnly = true;
            this.tb_ApptPet.Size = new System.Drawing.Size(259, 34);
            this.tb_ApptPet.TabIndex = 117;
            this.tb_ApptPet.Tag = "";
            // 
            // bt_CancelAppt
            // 
            this.bt_CancelAppt.Enabled = false;
            this.bt_CancelAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelAppt.Location = new System.Drawing.Point(244, 39);
            this.bt_CancelAppt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_CancelAppt.Name = "bt_CancelAppt";
            this.bt_CancelAppt.Size = new System.Drawing.Size(83, 32);
            this.bt_CancelAppt.TabIndex = 23;
            this.bt_CancelAppt.Tag = "option";
            this.bt_CancelAppt.Text = "Canc.";
            this.bt_CancelAppt.UseVisualStyleBackColor = true;
            this.bt_CancelAppt.Click += new System.EventHandler(this.bt_CancelAppt_Click);
            // 
            // lb_ApptNotes
            // 
            this.lb_ApptNotes.AutoSize = true;
            this.lb_ApptNotes.Location = new System.Drawing.Point(31, 271);
            this.lb_ApptNotes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptNotes.Name = "lb_ApptNotes";
            this.lb_ApptNotes.Size = new System.Drawing.Size(70, 26);
            this.lb_ApptNotes.TabIndex = 114;
            this.lb_ApptNotes.Text = "Notes:";
            // 
            // tb_ApptNotes
            // 
            this.tb_ApptNotes.Location = new System.Drawing.Point(111, 268);
            this.tb_ApptNotes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ApptNotes.Multiline = true;
            this.tb_ApptNotes.Name = "tb_ApptNotes";
            this.tb_ApptNotes.ReadOnly = true;
            this.tb_ApptNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ApptNotes.Size = new System.Drawing.Size(445, 170);
            this.tb_ApptNotes.TabIndex = 20;
            this.tb_ApptNotes.Tag = "field,notes";
            // 
            // bt_SaveAppt
            // 
            this.bt_SaveAppt.Enabled = false;
            this.bt_SaveAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveAppt.Location = new System.Drawing.Point(337, 39);
            this.bt_SaveAppt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_SaveAppt.Name = "bt_SaveAppt";
            this.bt_SaveAppt.Size = new System.Drawing.Size(83, 32);
            this.bt_SaveAppt.TabIndex = 24;
            this.bt_SaveAppt.Tag = "option";
            this.bt_SaveAppt.Text = "Save";
            this.bt_SaveAppt.UseVisualStyleBackColor = true;
            this.bt_SaveAppt.Click += new System.EventHandler(this.bt_SaveAppt_Click);
            // 
            // lb_ApptDate
            // 
            this.lb_ApptDate.AutoSize = true;
            this.lb_ApptDate.Location = new System.Drawing.Point(42, 132);
            this.lb_ApptDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptDate.Name = "lb_ApptDate";
            this.lb_ApptDate.Size = new System.Drawing.Size(59, 26);
            this.lb_ApptDate.TabIndex = 110;
            this.lb_ApptDate.Text = "Date:";
            // 
            // bt_EditAppt
            // 
            this.bt_EditAppt.Enabled = false;
            this.bt_EditAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditAppt.Location = new System.Drawing.Point(151, 39);
            this.bt_EditAppt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_EditAppt.Name = "bt_EditAppt";
            this.bt_EditAppt.Size = new System.Drawing.Size(83, 32);
            this.bt_EditAppt.TabIndex = 22;
            this.bt_EditAppt.Tag = "action";
            this.bt_EditAppt.Text = "Edit";
            this.bt_EditAppt.UseVisualStyleBackColor = true;
            this.bt_EditAppt.Click += new System.EventHandler(this.bt_EditAppt_Click);
            // 
            // dt_ApptDate
            // 
            this.dt_ApptDate.Enabled = false;
            this.dt_ApptDate.Font = new System.Drawing.Font("Ubuntu Mono", 13.8F);
            this.dt_ApptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ApptDate.Location = new System.Drawing.Point(111, 131);
            this.dt_ApptDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dt_ApptDate.Name = "dt_ApptDate";
            this.dt_ApptDate.Size = new System.Drawing.Size(259, 30);
            this.dt_ApptDate.TabIndex = 18;
            this.dt_ApptDate.Tag = "field,dtp";
            this.dt_ApptDate.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            this.dt_ApptDate.ValueChanged += new System.EventHandler(this.dt_ApptDate_ValueChanged);
            // 
            // bt_NewAppt
            // 
            this.bt_NewAppt.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_NewAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NewAppt.Location = new System.Drawing.Point(58, 39);
            this.bt_NewAppt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_NewAppt.Name = "bt_NewAppt";
            this.bt_NewAppt.Size = new System.Drawing.Size(83, 32);
            this.bt_NewAppt.TabIndex = 21;
            this.bt_NewAppt.Tag = "action";
            this.bt_NewAppt.Text = "New";
            this.bt_NewAppt.UseVisualStyleBackColor = false;
            this.bt_NewAppt.Click += new System.EventHandler(this.bt_NewAppt_Click);
            // 
            // cb_ApptSlot
            // 
            this.cb_ApptSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ApptSlot.Enabled = false;
            this.cb_ApptSlot.FormattingEnabled = true;
            this.cb_ApptSlot.Location = new System.Drawing.Point(380, 129);
            this.cb_ApptSlot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_ApptSlot.Name = "cb_ApptSlot";
            this.cb_ApptSlot.Size = new System.Drawing.Size(176, 34);
            this.cb_ApptSlot.TabIndex = 17;
            this.cb_ApptSlot.Tag = "field";
            this.cb_ApptSlot.SelectedIndexChanged += new System.EventHandler(this.cb_ApptSlot_DataSourceOrSelectedIndexChanged);
            this.cb_ApptSlot.DataSourceChanged += new System.EventHandler(this.cb_ApptSlot_DataSourceOrSelectedIndexChanged);
            // 
            // lb_ApptPet
            // 
            this.lb_ApptPet.AutoSize = true;
            this.lb_ApptPet.Location = new System.Drawing.Point(54, 88);
            this.lb_ApptPet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptPet.Name = "lb_ApptPet";
            this.lb_ApptPet.Size = new System.Drawing.Size(47, 26);
            this.lb_ApptPet.TabIndex = 104;
            this.lb_ApptPet.Text = "Pet:";
            // 
            // gb_Owners
            // 
            this.gb_Owners.Controls.Add(this.dg_Owners);
            this.gb_Owners.Location = new System.Drawing.Point(14, 108);
            this.gb_Owners.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Owners.Name = "gb_Owners";
            this.gb_Owners.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Owners.Size = new System.Drawing.Size(734, 336);
            this.gb_Owners.TabIndex = 124;
            this.gb_Owners.TabStop = false;
            this.gb_Owners.Text = "Owners";
            // 
            // gb_SearchOwners
            // 
            this.gb_SearchOwners.Controls.Add(this.bt_Reset);
            this.gb_SearchOwners.Controls.Add(this.bt_Search);
            this.gb_SearchOwners.Controls.Add(this.cb_Search);
            this.gb_SearchOwners.Controls.Add(this.tb_Search);
            this.gb_SearchOwners.Location = new System.Drawing.Point(14, 15);
            this.gb_SearchOwners.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_SearchOwners.Name = "gb_SearchOwners";
            this.gb_SearchOwners.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_SearchOwners.Size = new System.Drawing.Size(734, 85);
            this.gb_SearchOwners.TabIndex = 125;
            this.gb_SearchOwners.TabStop = false;
            this.gb_SearchOwners.Text = "Search Owners";
            // 
            // bt_Reset
            // 
            this.bt_Reset.Location = new System.Drawing.Point(641, 39);
            this.bt_Reset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(83, 32);
            this.bt_Reset.TabIndex = 3;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(535, 39);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(96, 32);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // cb_Search
            // 
            this.cb_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Search.FormattingEnabled = true;
            this.cb_Search.Location = new System.Drawing.Point(284, 39);
            this.cb_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_Search.Name = "cb_Search";
            this.cb_Search.Size = new System.Drawing.Size(241, 34);
            this.cb_Search.TabIndex = 1;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(10, 39);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(264, 34);
            this.tb_Search.TabIndex = 0;
            // 
            // gb_Appointments
            // 
            this.gb_Appointments.Controls.Add(this.dg_Appts);
            this.gb_Appointments.Location = new System.Drawing.Point(758, 108);
            this.gb_Appointments.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Appointments.Name = "gb_Appointments";
            this.gb_Appointments.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Appointments.Size = new System.Drawing.Size(783, 336);
            this.gb_Appointments.TabIndex = 126;
            this.gb_Appointments.TabStop = false;
            this.gb_Appointments.Text = "Appointments";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_ApptFilter);
            this.groupBox1.Location = new System.Drawing.Point(758, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(783, 85);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // cb_ApptFilter
            // 
            this.cb_ApptFilter.AutoSize = true;
            this.cb_ApptFilter.Location = new System.Drawing.Point(27, 36);
            this.cb_ApptFilter.Name = "cb_ApptFilter";
            this.cb_ApptFilter.Size = new System.Drawing.Size(271, 30);
            this.cb_ApptFilter.TabIndex = 0;
            this.cb_ApptFilter.Text = "Include Past Appointments";
            this.cb_ApptFilter.UseVisualStyleBackColor = true;
            this.cb_ApptFilter.CheckedChanged += new System.EventHandler(this.cb_ApptFilter_CheckedChanged);
            // 
            // lb_WeightSymb
            // 
            this.lb_WeightSymb.AutoSize = true;
            this.lb_WeightSymb.Location = new System.Drawing.Point(244, 220);
            this.lb_WeightSymb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_WeightSymb.Name = "lb_WeightSymb";
            this.lb_WeightSymb.Size = new System.Drawing.Size(35, 26);
            this.lb_WeightSymb.TabIndex = 116;
            this.lb_WeightSymb.Text = "Kg";
            // 
            // CustomersViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1555, 921);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Appointments);
            this.Controls.Add(this.gb_SearchOwners);
            this.Controls.Add(this.gb_Owners);
            this.Controls.Add(this.gb_ApptInfo);
            this.Controls.Add(this.gb_PetInfo);
            this.Controls.Add(this.gb_OwnerInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Red Hat Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CustomersViewForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Owners)).EndInit();
            this.gb_OwnerInfo.ResumeLayout(false);
            this.gb_OwnerInfo.PerformLayout();
            this.gb_PetInfo.ResumeLayout(false);
            this.gb_PetInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Appts)).EndInit();
            this.gb_ApptInfo.ResumeLayout(false);
            this.gb_ApptInfo.PerformLayout();
            this.gb_Owners.ResumeLayout(false);
            this.gb_SearchOwners.ResumeLayout(false);
            this.gb_SearchOwners.PerformLayout();
            this.gb_Appointments.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Owners;
        private System.Windows.Forms.Label lb_OwnerId;
        private System.Windows.Forms.TextBox tb_OwnerId;
        private System.Windows.Forms.TextBox tb_OwnerName;
        private System.Windows.Forms.Label lb_OwnerName;
        private System.Windows.Forms.TextBox tb_OwnerDoc;
        private System.Windows.Forms.Label lb_OwnerDoc;
        private System.Windows.Forms.TextBox tb_OwnerPhone;
        private System.Windows.Forms.Label lb_OwnerPhone;
        private System.Windows.Forms.TextBox tb_OwnerAddress;
        private System.Windows.Forms.Label lb_OwnerAddress;
        private System.Windows.Forms.TextBox tb_OwnerEmail;
        private System.Windows.Forms.Label lb_OwnerEmail;
        private System.Windows.Forms.Button bt_NewOwner;
        private System.Windows.Forms.GroupBox gb_OwnerInfo;
        private System.Windows.Forms.Button bt_SaveOwner;
        private System.Windows.Forms.Button bt_CancelOwner;
        private System.Windows.Forms.Button bt_EditOwner;
        private System.Windows.Forms.ComboBox cb_Pets;
        private System.Windows.Forms.GroupBox gb_PetInfo;
        private System.Windows.Forms.ComboBox cb_AnimalSpecies;
        private System.Windows.Forms.ComboBox cb_AnimalClass;
        private System.Windows.Forms.Label lb_AnimalSpecies;
        private System.Windows.Forms.Label lb_AnimalClass;
        private System.Windows.Forms.Label lb_PetSex;
        private System.Windows.Forms.ComboBox cb_PetSex;
        private System.Windows.Forms.Label lb_PetNotes;
        private System.Windows.Forms.TextBox tb_PetNotes;
        private System.Windows.Forms.TextBox tb_PetWeight;
        private System.Windows.Forms.Label lb_PetWeight;
        private System.Windows.Forms.Label lb_PetDob;
        private System.Windows.Forms.DateTimePicker dt_PetDob;
        private System.Windows.Forms.Button bt_CancelPet;
        private System.Windows.Forms.Button bt_EditPet;
        private System.Windows.Forms.Button bt_SavePet;
        private System.Windows.Forms.Button bt_NewPet;
        private System.Windows.Forms.TextBox tb_PetName;
        private System.Windows.Forms.Label lb_PetName;
        private System.Windows.Forms.DataGridView dg_Appts;
        private System.Windows.Forms.GroupBox gb_ApptInfo;
        private System.Windows.Forms.Button bt_CancelAppt;
        private System.Windows.Forms.Label lb_ApptNotes;
        private System.Windows.Forms.Button bt_EditAppt;
        private System.Windows.Forms.TextBox tb_ApptNotes;
        private System.Windows.Forms.Button bt_SaveAppt;
        private System.Windows.Forms.Button bt_NewAppt;
        private System.Windows.Forms.Label lb_ApptDate;
        private System.Windows.Forms.DateTimePicker dt_ApptDate;
        private System.Windows.Forms.ComboBox cb_ApptSlot;
        private System.Windows.Forms.Label lb_ApptPet;
        private System.Windows.Forms.TextBox tb_ApptPet;
        private System.Windows.Forms.Label lb_ApptVet;
        private System.Windows.Forms.ComboBox cb_ApptVet;
        private System.Windows.Forms.GroupBox gb_Owners;
        private System.Windows.Forms.GroupBox gb_SearchOwners;
        private System.Windows.Forms.GroupBox gb_Appointments;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.ComboBox cb_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button bt_DelAppt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_ApptFilter;
        private System.Windows.Forms.Label lb_ApptService;
        private System.Windows.Forms.ComboBox cb_ApptService;
        private System.Windows.Forms.Label lb_WeightSymb;
    }
}