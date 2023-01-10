namespace DashPetApp.Forms
{
    partial class VetsViewForm
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
            this.gb_Vets = new System.Windows.Forms.GroupBox();
            this.dg_Vets = new System.Windows.Forms.DataGridView();
            this.tb_VetId = new System.Windows.Forms.TextBox();
            this.lb_OwnerId = new System.Windows.Forms.Label();
            this.tb_VetEmail = new System.Windows.Forms.TextBox();
            this.lb_OwnerName = new System.Windows.Forms.Label();
            this.bt_NewVet = new System.Windows.Forms.Button();
            this.gb_VetInfo = new System.Windows.Forms.GroupBox();
            this.bt_DelVetAllAppt = new System.Windows.Forms.Button();
            this.bt_DelVetDailyAppt = new System.Windows.Forms.Button();
            this.lb_VetRoom = new System.Windows.Forms.Label();
            this.cb_VetRoom = new System.Windows.Forms.ComboBox();
            this.bt_CancelVet = new System.Windows.Forms.Button();
            this.bt_EditVet = new System.Windows.Forms.Button();
            this.bt_SaveVet = new System.Windows.Forms.Button();
            this.lb_OwnerEmail = new System.Windows.Forms.Label();
            this.tb_VetName = new System.Windows.Forms.TextBox();
            this.lb_OwnerDoc = new System.Windows.Forms.Label();
            this.tb_VetDoc = new System.Windows.Forms.TextBox();
            this.tb_VetPhone = new System.Windows.Forms.TextBox();
            this.lb_OwnerPhone = new System.Windows.Forms.Label();
            this.gb_Appointments = new System.Windows.Forms.GroupBox();
            this.dg_Appts = new System.Windows.Forms.DataGridView();
            this.gb_ApptInfo = new System.Windows.Forms.GroupBox();
            this.lb_ApptService = new System.Windows.Forms.Label();
            this.cb_ApptService = new System.Windows.Forms.ComboBox();
            this.tb_ApptOwner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cb_ApptSlot = new System.Windows.Forms.ComboBox();
            this.lb_ApptPet = new System.Windows.Forms.Label();
            this.gb_Rooms = new System.Windows.Forms.GroupBox();
            this.tv_Rooms = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_ApptFilter = new System.Windows.Forms.CheckBox();
            this.gb_Vets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Vets)).BeginInit();
            this.gb_VetInfo.SuspendLayout();
            this.gb_Appointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Appts)).BeginInit();
            this.gb_ApptInfo.SuspendLayout();
            this.gb_Rooms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Vets
            // 
            this.gb_Vets.Controls.Add(this.dg_Vets);
            this.gb_Vets.Location = new System.Drawing.Point(15, 15);
            this.gb_Vets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Vets.Name = "gb_Vets";
            this.gb_Vets.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Vets.Size = new System.Drawing.Size(756, 429);
            this.gb_Vets.TabIndex = 130;
            this.gb_Vets.TabStop = false;
            this.gb_Vets.Text = "Vets";
            // 
            // dg_Vets
            // 
            this.dg_Vets.AllowUserToAddRows = false;
            this.dg_Vets.AllowUserToDeleteRows = false;
            this.dg_Vets.AllowUserToOrderColumns = true;
            this.dg_Vets.AllowUserToResizeColumns = false;
            this.dg_Vets.AllowUserToResizeRows = false;
            this.dg_Vets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Vets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_Vets.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dg_Vets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Vets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Vets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Vets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Vets.Location = new System.Drawing.Point(5, 33);
            this.dg_Vets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dg_Vets.MultiSelect = false;
            this.dg_Vets.Name = "dg_Vets";
            this.dg_Vets.RowHeadersVisible = false;
            this.dg_Vets.RowHeadersWidth = 51;
            this.dg_Vets.RowTemplate.Height = 24;
            this.dg_Vets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_Vets.Size = new System.Drawing.Size(746, 390);
            this.dg_Vets.TabIndex = 1;
            this.dg_Vets.SelectionChanged += new System.EventHandler(this.dg_Vets_SelectionChanged);
            // 
            // tb_VetId
            // 
            this.tb_VetId.Location = new System.Drawing.Point(109, 97);
            this.tb_VetId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_VetId.Name = "tb_VetId";
            this.tb_VetId.ReadOnly = true;
            this.tb_VetId.Size = new System.Drawing.Size(263, 34);
            this.tb_VetId.TabIndex = 99;
            this.tb_VetId.TabStop = false;
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
            // tb_VetEmail
            // 
            this.tb_VetEmail.Location = new System.Drawing.Point(108, 281);
            this.tb_VetEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_VetEmail.Name = "tb_VetEmail";
            this.tb_VetEmail.ReadOnly = true;
            this.tb_VetEmail.Size = new System.Drawing.Size(264, 34);
            this.tb_VetEmail.TabIndex = 5;
            this.tb_VetEmail.Tag = "field,email";
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
            // bt_NewVet
            // 
            this.bt_NewVet.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_NewVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NewVet.Location = new System.Drawing.Point(10, 39);
            this.bt_NewVet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_NewVet.Name = "bt_NewVet";
            this.bt_NewVet.Size = new System.Drawing.Size(83, 32);
            this.bt_NewVet.TabIndex = 7;
            this.bt_NewVet.Tag = "action";
            this.bt_NewVet.Text = "New";
            this.bt_NewVet.UseVisualStyleBackColor = false;
            this.bt_NewVet.Click += new System.EventHandler(this.bt_NewVet_Click);
            // 
            // gb_VetInfo
            // 
            this.gb_VetInfo.Controls.Add(this.bt_DelVetAllAppt);
            this.gb_VetInfo.Controls.Add(this.bt_DelVetDailyAppt);
            this.gb_VetInfo.Controls.Add(this.lb_VetRoom);
            this.gb_VetInfo.Controls.Add(this.cb_VetRoom);
            this.gb_VetInfo.Controls.Add(this.bt_CancelVet);
            this.gb_VetInfo.Controls.Add(this.bt_EditVet);
            this.gb_VetInfo.Controls.Add(this.bt_SaveVet);
            this.gb_VetInfo.Controls.Add(this.tb_VetId);
            this.gb_VetInfo.Controls.Add(this.bt_NewVet);
            this.gb_VetInfo.Controls.Add(this.lb_OwnerId);
            this.gb_VetInfo.Controls.Add(this.tb_VetEmail);
            this.gb_VetInfo.Controls.Add(this.lb_OwnerName);
            this.gb_VetInfo.Controls.Add(this.lb_OwnerEmail);
            this.gb_VetInfo.Controls.Add(this.tb_VetName);
            this.gb_VetInfo.Controls.Add(this.lb_OwnerDoc);
            this.gb_VetInfo.Controls.Add(this.tb_VetDoc);
            this.gb_VetInfo.Controls.Add(this.tb_VetPhone);
            this.gb_VetInfo.Controls.Add(this.lb_OwnerPhone);
            this.gb_VetInfo.Location = new System.Drawing.Point(15, 456);
            this.gb_VetInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_VetInfo.Name = "gb_VetInfo";
            this.gb_VetInfo.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_VetInfo.Size = new System.Drawing.Size(395, 450);
            this.gb_VetInfo.TabIndex = 127;
            this.gb_VetInfo.TabStop = false;
            this.gb_VetInfo.Text = "Vet Info";
            // 
            // bt_DelVetAllAppt
            // 
            this.bt_DelVetAllAppt.FlatAppearance.BorderSize = 0;
            this.bt_DelVetAllAppt.Location = new System.Drawing.Point(196, 373);
            this.bt_DelVetAllAppt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_DelVetAllAppt.Name = "bt_DelVetAllAppt";
            this.bt_DelVetAllAppt.Size = new System.Drawing.Size(176, 65);
            this.bt_DelVetAllAppt.TabIndex = 124;
            this.bt_DelVetAllAppt.Tag = "action";
            this.bt_DelVetAllAppt.Text = "Cancel All Appointments";
            this.bt_DelVetAllAppt.UseVisualStyleBackColor = true;
            this.bt_DelVetAllAppt.Click += new System.EventHandler(this.bt_DelVetAllAppt_Click);
            // 
            // bt_DelVetDailyAppt
            // 
            this.bt_DelVetDailyAppt.FlatAppearance.BorderSize = 0;
            this.bt_DelVetDailyAppt.Location = new System.Drawing.Point(10, 373);
            this.bt_DelVetDailyAppt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_DelVetDailyAppt.Name = "bt_DelVetDailyAppt";
            this.bt_DelVetDailyAppt.Size = new System.Drawing.Size(176, 65);
            this.bt_DelVetDailyAppt.TabIndex = 123;
            this.bt_DelVetDailyAppt.Tag = "action";
            this.bt_DelVetDailyAppt.Text = "Cancel Daily Appointments";
            this.bt_DelVetDailyAppt.UseVisualStyleBackColor = true;
            this.bt_DelVetDailyAppt.Click += new System.EventHandler(this.bt_DelVetDailyAppt_Click);
            // 
            // lb_VetRoom
            // 
            this.lb_VetRoom.AutoSize = true;
            this.lb_VetRoom.Location = new System.Drawing.Point(30, 330);
            this.lb_VetRoom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_VetRoom.Name = "lb_VetRoom";
            this.lb_VetRoom.Size = new System.Drawing.Size(70, 26);
            this.lb_VetRoom.TabIndex = 122;
            this.lb_VetRoom.Text = "Room:";
            // 
            // cb_VetRoom
            // 
            this.cb_VetRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_VetRoom.Enabled = false;
            this.cb_VetRoom.FormattingEnabled = true;
            this.cb_VetRoom.Location = new System.Drawing.Point(108, 327);
            this.cb_VetRoom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_VetRoom.Name = "cb_VetRoom";
            this.cb_VetRoom.Size = new System.Drawing.Size(264, 34);
            this.cb_VetRoom.TabIndex = 121;
            this.cb_VetRoom.Tag = "field";
            // 
            // bt_CancelVet
            // 
            this.bt_CancelVet.Enabled = false;
            this.bt_CancelVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelVet.Location = new System.Drawing.Point(196, 39);
            this.bt_CancelVet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_CancelVet.Name = "bt_CancelVet";
            this.bt_CancelVet.Size = new System.Drawing.Size(83, 32);
            this.bt_CancelVet.TabIndex = 9;
            this.bt_CancelVet.Tag = "option";
            this.bt_CancelVet.Text = "Canc.";
            this.bt_CancelVet.UseVisualStyleBackColor = true;
            this.bt_CancelVet.Click += new System.EventHandler(this.bt_CancelVet_Click);
            // 
            // bt_EditVet
            // 
            this.bt_EditVet.Enabled = false;
            this.bt_EditVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditVet.Location = new System.Drawing.Point(103, 39);
            this.bt_EditVet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_EditVet.Name = "bt_EditVet";
            this.bt_EditVet.Size = new System.Drawing.Size(83, 32);
            this.bt_EditVet.TabIndex = 8;
            this.bt_EditVet.Tag = "action";
            this.bt_EditVet.Text = "Edit";
            this.bt_EditVet.UseVisualStyleBackColor = true;
            this.bt_EditVet.Click += new System.EventHandler(this.bt_EditVet_Click);
            // 
            // bt_SaveVet
            // 
            this.bt_SaveVet.Enabled = false;
            this.bt_SaveVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveVet.Location = new System.Drawing.Point(289, 39);
            this.bt_SaveVet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_SaveVet.Name = "bt_SaveVet";
            this.bt_SaveVet.Size = new System.Drawing.Size(83, 32);
            this.bt_SaveVet.TabIndex = 10;
            this.bt_SaveVet.Tag = "option";
            this.bt_SaveVet.Text = "Save";
            this.bt_SaveVet.UseVisualStyleBackColor = true;
            this.bt_SaveVet.Click += new System.EventHandler(this.bt_SaveVet_Click);
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
            // tb_VetName
            // 
            this.tb_VetName.Location = new System.Drawing.Point(108, 143);
            this.tb_VetName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_VetName.Name = "tb_VetName";
            this.tb_VetName.ReadOnly = true;
            this.tb_VetName.Size = new System.Drawing.Size(264, 34);
            this.tb_VetName.TabIndex = 2;
            this.tb_VetName.Tag = "field,name";
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
            // tb_VetDoc
            // 
            this.tb_VetDoc.Location = new System.Drawing.Point(108, 189);
            this.tb_VetDoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_VetDoc.Name = "tb_VetDoc";
            this.tb_VetDoc.ReadOnly = true;
            this.tb_VetDoc.Size = new System.Drawing.Size(264, 34);
            this.tb_VetDoc.TabIndex = 3;
            this.tb_VetDoc.Tag = "field,doc";
            // 
            // tb_VetPhone
            // 
            this.tb_VetPhone.Location = new System.Drawing.Point(108, 235);
            this.tb_VetPhone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_VetPhone.Name = "tb_VetPhone";
            this.tb_VetPhone.ReadOnly = true;
            this.tb_VetPhone.Size = new System.Drawing.Size(264, 34);
            this.tb_VetPhone.TabIndex = 4;
            this.tb_VetPhone.Tag = "field,phone";
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
            // gb_Appointments
            // 
            this.gb_Appointments.Controls.Add(this.dg_Appts);
            this.gb_Appointments.Location = new System.Drawing.Point(781, 112);
            this.gb_Appointments.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Appointments.Name = "gb_Appointments";
            this.gb_Appointments.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Appointments.Size = new System.Drawing.Size(760, 332);
            this.gb_Appointments.TabIndex = 129;
            this.gb_Appointments.TabStop = false;
            this.gb_Appointments.Text = "Appointments";
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
            this.dg_Appts.Size = new System.Drawing.Size(750, 293);
            this.dg_Appts.TabIndex = 12;
            this.dg_Appts.DataSourceChanged += new System.EventHandler(this.dg_Appts_SelectionChanged);
            this.dg_Appts.SelectionChanged += new System.EventHandler(this.dg_Appts_SelectionChanged);
            // 
            // gb_ApptInfo
            // 
            this.gb_ApptInfo.Controls.Add(this.lb_ApptService);
            this.gb_ApptInfo.Controls.Add(this.cb_ApptService);
            this.gb_ApptInfo.Controls.Add(this.tb_ApptOwner);
            this.gb_ApptInfo.Controls.Add(this.label1);
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
            this.gb_ApptInfo.Controls.Add(this.cb_ApptSlot);
            this.gb_ApptInfo.Controls.Add(this.lb_ApptPet);
            this.gb_ApptInfo.Enabled = false;
            this.gb_ApptInfo.Location = new System.Drawing.Point(781, 456);
            this.gb_ApptInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_ApptInfo.Name = "gb_ApptInfo";
            this.gb_ApptInfo.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_ApptInfo.Size = new System.Drawing.Size(760, 450);
            this.gb_ApptInfo.TabIndex = 128;
            this.gb_ApptInfo.TabStop = false;
            this.gb_ApptInfo.Text = "Appointment Info";
            // 
            // lb_ApptService
            // 
            this.lb_ApptService.AutoSize = true;
            this.lb_ApptService.Location = new System.Drawing.Point(19, 222);
            this.lb_ApptService.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptService.Name = "lb_ApptService";
            this.lb_ApptService.Size = new System.Drawing.Size(82, 26);
            this.lb_ApptService.TabIndex = 124;
            this.lb_ApptService.Text = "Service:";
            // 
            // cb_ApptService
            // 
            this.cb_ApptService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ApptService.Enabled = false;
            this.cb_ApptService.FormattingEnabled = true;
            this.cb_ApptService.Location = new System.Drawing.Point(111, 219);
            this.cb_ApptService.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_ApptService.Name = "cb_ApptService";
            this.cb_ApptService.Size = new System.Drawing.Size(583, 34);
            this.cb_ApptService.TabIndex = 123;
            this.cb_ApptService.Tag = "field";
            // 
            // tb_ApptOwner
            // 
            this.tb_ApptOwner.Location = new System.Drawing.Point(111, 83);
            this.tb_ApptOwner.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ApptOwner.Name = "tb_ApptOwner";
            this.tb_ApptOwner.ReadOnly = true;
            this.tb_ApptOwner.Size = new System.Drawing.Size(267, 34);
            this.tb_ApptOwner.TabIndex = 122;
            this.tb_ApptOwner.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 121;
            this.label1.Text = "Owner:";
            // 
            // bt_DelAppt
            // 
            this.bt_DelAppt.Enabled = false;
            this.bt_DelAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DelAppt.Location = new System.Drawing.Point(450, 39);
            this.bt_DelAppt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_DelAppt.Name = "bt_DelAppt";
            this.bt_DelAppt.Size = new System.Drawing.Size(94, 32);
            this.bt_DelAppt.TabIndex = 120;
            this.bt_DelAppt.Tag = "action";
            this.bt_DelAppt.Text = "Delete";
            this.bt_DelAppt.UseVisualStyleBackColor = true;
            this.bt_DelAppt.Click += new System.EventHandler(this.bt_DelAppt_Click);
            // 
            // lb_ApptVet
            // 
            this.lb_ApptVet.AutoSize = true;
            this.lb_ApptVet.Location = new System.Drawing.Point(53, 176);
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
            this.cb_ApptVet.Location = new System.Drawing.Point(111, 173);
            this.cb_ApptVet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_ApptVet.Name = "cb_ApptVet";
            this.cb_ApptVet.Size = new System.Drawing.Size(583, 34);
            this.cb_ApptVet.TabIndex = 118;
            this.cb_ApptVet.Tag = "field";
            // 
            // tb_ApptPet
            // 
            this.tb_ApptPet.Location = new System.Drawing.Point(445, 83);
            this.tb_ApptPet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ApptPet.Name = "tb_ApptPet";
            this.tb_ApptPet.ReadOnly = true;
            this.tb_ApptPet.Size = new System.Drawing.Size(249, 34);
            this.tb_ApptPet.TabIndex = 117;
            this.tb_ApptPet.Tag = "";
            // 
            // bt_CancelAppt
            // 
            this.bt_CancelAppt.Enabled = false;
            this.bt_CancelAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelAppt.Location = new System.Drawing.Point(264, 39);
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
            this.lb_ApptNotes.Location = new System.Drawing.Point(31, 268);
            this.lb_ApptNotes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptNotes.Name = "lb_ApptNotes";
            this.lb_ApptNotes.Size = new System.Drawing.Size(70, 26);
            this.lb_ApptNotes.TabIndex = 114;
            this.lb_ApptNotes.Text = "Notes:";
            // 
            // tb_ApptNotes
            // 
            this.tb_ApptNotes.Location = new System.Drawing.Point(111, 265);
            this.tb_ApptNotes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ApptNotes.Multiline = true;
            this.tb_ApptNotes.Name = "tb_ApptNotes";
            this.tb_ApptNotes.ReadOnly = true;
            this.tb_ApptNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ApptNotes.Size = new System.Drawing.Size(583, 173);
            this.tb_ApptNotes.TabIndex = 20;
            this.tb_ApptNotes.Tag = "field,notes";
            // 
            // bt_SaveAppt
            // 
            this.bt_SaveAppt.Enabled = false;
            this.bt_SaveAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveAppt.Location = new System.Drawing.Point(357, 39);
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
            this.bt_EditAppt.Location = new System.Drawing.Point(171, 39);
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
            this.dt_ApptDate.Size = new System.Drawing.Size(267, 30);
            this.dt_ApptDate.TabIndex = 18;
            this.dt_ApptDate.Tag = "field,dtp";
            this.dt_ApptDate.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            this.dt_ApptDate.ValueChanged += new System.EventHandler(this.dt_ApptDate_ValueChanged);
            // 
            // cb_ApptSlot
            // 
            this.cb_ApptSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ApptSlot.Enabled = false;
            this.cb_ApptSlot.FormattingEnabled = true;
            this.cb_ApptSlot.Location = new System.Drawing.Point(393, 129);
            this.cb_ApptSlot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_ApptSlot.Name = "cb_ApptSlot";
            this.cb_ApptSlot.Size = new System.Drawing.Size(301, 34);
            this.cb_ApptSlot.TabIndex = 17;
            this.cb_ApptSlot.Tag = "field";
            this.cb_ApptSlot.SelectedIndexChanged += new System.EventHandler(this.cb_ApptSlot_SelectedIndexChanged);
            this.cb_ApptSlot.DataSourceChanged += new System.EventHandler(this.cb_ApptSlot_SelectedIndexChanged);
            // 
            // lb_ApptPet
            // 
            this.lb_ApptPet.AutoSize = true;
            this.lb_ApptPet.Location = new System.Drawing.Point(388, 86);
            this.lb_ApptPet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptPet.Name = "lb_ApptPet";
            this.lb_ApptPet.Size = new System.Drawing.Size(47, 26);
            this.lb_ApptPet.TabIndex = 104;
            this.lb_ApptPet.Text = "Pet:";
            // 
            // gb_Rooms
            // 
            this.gb_Rooms.Controls.Add(this.tv_Rooms);
            this.gb_Rooms.Location = new System.Drawing.Point(420, 456);
            this.gb_Rooms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Rooms.Name = "gb_Rooms";
            this.gb_Rooms.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Rooms.Size = new System.Drawing.Size(351, 450);
            this.gb_Rooms.TabIndex = 135;
            this.gb_Rooms.TabStop = false;
            this.gb_Rooms.Text = "Rooms";
            // 
            // tv_Rooms
            // 
            this.tv_Rooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_Rooms.Location = new System.Drawing.Point(5, 33);
            this.tv_Rooms.Name = "tv_Rooms";
            this.tv_Rooms.Size = new System.Drawing.Size(341, 411);
            this.tv_Rooms.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_ApptFilter);
            this.groupBox1.Location = new System.Drawing.Point(781, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(760, 85);
            this.groupBox1.TabIndex = 136;
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
            // VetsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1555, 921);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Rooms);
            this.Controls.Add(this.gb_Appointments);
            this.Controls.Add(this.gb_ApptInfo);
            this.Controls.Add(this.gb_Vets);
            this.Controls.Add(this.gb_VetInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Red Hat Display", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VetsViewForm";
            this.Text = "Vets";
            this.Load += new System.EventHandler(this.VetsViewForm_Load);
            this.gb_Vets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Vets)).EndInit();
            this.gb_VetInfo.ResumeLayout(false);
            this.gb_VetInfo.PerformLayout();
            this.gb_Appointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Appts)).EndInit();
            this.gb_ApptInfo.ResumeLayout(false);
            this.gb_ApptInfo.PerformLayout();
            this.gb_Rooms.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Vets;
        private System.Windows.Forms.DataGridView dg_Vets;
        private System.Windows.Forms.TextBox tb_VetId;
        private System.Windows.Forms.Label lb_OwnerId;
        private System.Windows.Forms.TextBox tb_VetEmail;
        private System.Windows.Forms.Label lb_OwnerName;
        private System.Windows.Forms.Button bt_NewVet;
        private System.Windows.Forms.GroupBox gb_VetInfo;
        private System.Windows.Forms.Button bt_CancelVet;
        private System.Windows.Forms.Button bt_EditVet;
        private System.Windows.Forms.Button bt_SaveVet;
        private System.Windows.Forms.Label lb_OwnerEmail;
        private System.Windows.Forms.TextBox tb_VetName;
        private System.Windows.Forms.Label lb_OwnerDoc;
        private System.Windows.Forms.TextBox tb_VetDoc;
        private System.Windows.Forms.TextBox tb_VetPhone;
        private System.Windows.Forms.Label lb_OwnerPhone;
        private System.Windows.Forms.GroupBox gb_Appointments;
        private System.Windows.Forms.DataGridView dg_Appts;
        private System.Windows.Forms.GroupBox gb_ApptInfo;
        private System.Windows.Forms.Button bt_DelAppt;
        private System.Windows.Forms.Label lb_ApptVet;
        private System.Windows.Forms.ComboBox cb_ApptVet;
        private System.Windows.Forms.TextBox tb_ApptPet;
        private System.Windows.Forms.Button bt_CancelAppt;
        private System.Windows.Forms.Label lb_ApptNotes;
        private System.Windows.Forms.TextBox tb_ApptNotes;
        private System.Windows.Forms.Button bt_SaveAppt;
        private System.Windows.Forms.Label lb_ApptDate;
        private System.Windows.Forms.Button bt_EditAppt;
        private System.Windows.Forms.DateTimePicker dt_ApptDate;
        private System.Windows.Forms.ComboBox cb_ApptSlot;
        private System.Windows.Forms.Label lb_ApptPet;
        private System.Windows.Forms.ComboBox cb_VetRoom;
        private System.Windows.Forms.GroupBox gb_Rooms;
        private System.Windows.Forms.TreeView tv_Rooms;
        private System.Windows.Forms.Label lb_VetRoom;
        private System.Windows.Forms.TextBox tb_ApptOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_DelVetAllAppt;
        private System.Windows.Forms.Button bt_DelVetDailyAppt;
        private System.Windows.Forms.Label lb_ApptService;
        private System.Windows.Forms.ComboBox cb_ApptService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_ApptFilter;
    }
}