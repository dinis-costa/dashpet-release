namespace DashPetApp.Forms
{
    partial class InternalViewForm
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
            this.gb_Rooms = new System.Windows.Forms.GroupBox();
            this.tv_Rooms = new System.Windows.Forms.TreeView();
            this.gb_RoomInfo = new System.Windows.Forms.GroupBox();
            this.bt_CancelRoom = new System.Windows.Forms.Button();
            this.bt_EditRoom = new System.Windows.Forms.Button();
            this.bt_SaveRoom = new System.Windows.Forms.Button();
            this.bt_NewRoom = new System.Windows.Forms.Button();
            this.lb_OwnerName = new System.Windows.Forms.Label();
            this.tb_RoomName = new System.Windows.Forms.TextBox();
            this.gb_Owners = new System.Windows.Forms.GroupBox();
            this.tb_Vets = new System.Windows.Forms.TabControl();
            this.tp_OwnersPets = new System.Windows.Forms.TabPage();
            this.dg_Pets = new System.Windows.Forms.DataGridView();
            this.dg_Owners = new System.Windows.Forms.DataGridView();
            this.tp_VetsRooms = new System.Windows.Forms.TabPage();
            this.dg_Rooms = new System.Windows.Forms.DataGridView();
            this.dg_Vets = new System.Windows.Forms.DataGridView();
            this.tp_Services = new System.Windows.Forms.TabPage();
            this.dg_Services = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_CancelDayAppts = new System.Windows.Forms.Button();
            this.lb_ScheduleReminder = new System.Windows.Forms.Label();
            this.dt_ScheduleReminder = new System.Windows.Forms.DateTimePicker();
            this.bt_Clipboard = new System.Windows.Forms.Button();
            this.bt_SendEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Template = new System.Windows.Forms.ComboBox();
            this.gb_ServiceInfo = new System.Windows.Forms.GroupBox();
            this.lb_ServicePrice = new System.Windows.Forms.Label();
            this.tb_ServicePrice = new System.Windows.Forms.TextBox();
            this.bt_CancelService = new System.Windows.Forms.Button();
            this.bt_EditService = new System.Windows.Forms.Button();
            this.bt_SaveService = new System.Windows.Forms.Button();
            this.bt_NewService = new System.Windows.Forms.Button();
            this.lb_ServiceName = new System.Windows.Forms.Label();
            this.tb_ServiceName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_Services = new System.Windows.Forms.ListBox();
            this.lb_PriceSymb = new System.Windows.Forms.Label();
            this.lb_Warning = new System.Windows.Forms.Label();
            this.gb_Rooms.SuspendLayout();
            this.gb_RoomInfo.SuspendLayout();
            this.gb_Owners.SuspendLayout();
            this.tb_Vets.SuspendLayout();
            this.tp_OwnersPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Pets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Owners)).BeginInit();
            this.tp_VetsRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Vets)).BeginInit();
            this.tp_Services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Services)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_ServiceInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Rooms
            // 
            this.gb_Rooms.Controls.Add(this.tv_Rooms);
            this.gb_Rooms.Location = new System.Drawing.Point(14, 15);
            this.gb_Rooms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Rooms.Name = "gb_Rooms";
            this.gb_Rooms.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Rooms.Size = new System.Drawing.Size(350, 361);
            this.gb_Rooms.TabIndex = 132;
            this.gb_Rooms.TabStop = false;
            this.gb_Rooms.Text = "Rooms";
            // 
            // tv_Rooms
            // 
            this.tv_Rooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_Rooms.Location = new System.Drawing.Point(5, 33);
            this.tv_Rooms.Name = "tv_Rooms";
            this.tv_Rooms.Size = new System.Drawing.Size(340, 322);
            this.tv_Rooms.TabIndex = 0;
            this.tv_Rooms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_Rooms_AfterSelect);
            // 
            // gb_RoomInfo
            // 
            this.gb_RoomInfo.Controls.Add(this.bt_CancelRoom);
            this.gb_RoomInfo.Controls.Add(this.bt_EditRoom);
            this.gb_RoomInfo.Controls.Add(this.bt_SaveRoom);
            this.gb_RoomInfo.Controls.Add(this.bt_NewRoom);
            this.gb_RoomInfo.Controls.Add(this.lb_OwnerName);
            this.gb_RoomInfo.Controls.Add(this.tb_RoomName);
            this.gb_RoomInfo.Location = new System.Drawing.Point(374, 15);
            this.gb_RoomInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_RoomInfo.Name = "gb_RoomInfo";
            this.gb_RoomInfo.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_RoomInfo.Size = new System.Drawing.Size(390, 151);
            this.gb_RoomInfo.TabIndex = 131;
            this.gb_RoomInfo.TabStop = false;
            this.gb_RoomInfo.Text = "Room Info";
            // 
            // bt_CancelRoom
            // 
            this.bt_CancelRoom.Enabled = false;
            this.bt_CancelRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelRoom.Location = new System.Drawing.Point(196, 39);
            this.bt_CancelRoom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_CancelRoom.Name = "bt_CancelRoom";
            this.bt_CancelRoom.Size = new System.Drawing.Size(83, 32);
            this.bt_CancelRoom.TabIndex = 9;
            this.bt_CancelRoom.Tag = "option";
            this.bt_CancelRoom.Text = "Canc.";
            this.bt_CancelRoom.UseVisualStyleBackColor = true;
            this.bt_CancelRoom.Click += new System.EventHandler(this.bt_CancelRoom_Click);
            // 
            // bt_EditRoom
            // 
            this.bt_EditRoom.Enabled = false;
            this.bt_EditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditRoom.Location = new System.Drawing.Point(103, 39);
            this.bt_EditRoom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_EditRoom.Name = "bt_EditRoom";
            this.bt_EditRoom.Size = new System.Drawing.Size(83, 32);
            this.bt_EditRoom.TabIndex = 8;
            this.bt_EditRoom.Tag = "action";
            this.bt_EditRoom.Text = "Edit";
            this.bt_EditRoom.UseVisualStyleBackColor = true;
            this.bt_EditRoom.Click += new System.EventHandler(this.bt_EditRoom_Click);
            // 
            // bt_SaveRoom
            // 
            this.bt_SaveRoom.Enabled = false;
            this.bt_SaveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveRoom.Location = new System.Drawing.Point(289, 39);
            this.bt_SaveRoom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_SaveRoom.Name = "bt_SaveRoom";
            this.bt_SaveRoom.Size = new System.Drawing.Size(83, 32);
            this.bt_SaveRoom.TabIndex = 10;
            this.bt_SaveRoom.Tag = "option";
            this.bt_SaveRoom.Text = "Save";
            this.bt_SaveRoom.UseVisualStyleBackColor = true;
            this.bt_SaveRoom.Click += new System.EventHandler(this.bt_SaveRoom_Click);
            // 
            // bt_NewRoom
            // 
            this.bt_NewRoom.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_NewRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NewRoom.Location = new System.Drawing.Point(10, 39);
            this.bt_NewRoom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_NewRoom.Name = "bt_NewRoom";
            this.bt_NewRoom.Size = new System.Drawing.Size(83, 32);
            this.bt_NewRoom.TabIndex = 7;
            this.bt_NewRoom.Tag = "action";
            this.bt_NewRoom.Text = "New";
            this.bt_NewRoom.UseVisualStyleBackColor = false;
            this.bt_NewRoom.Click += new System.EventHandler(this.bt_NewRoom_Click);
            // 
            // lb_OwnerName
            // 
            this.lb_OwnerName.AutoSize = true;
            this.lb_OwnerName.Location = new System.Drawing.Point(29, 98);
            this.lb_OwnerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_OwnerName.Name = "lb_OwnerName";
            this.lb_OwnerName.Size = new System.Drawing.Size(70, 26);
            this.lb_OwnerName.TabIndex = 3;
            this.lb_OwnerName.Text = "Name:";
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.Location = new System.Drawing.Point(108, 95);
            this.tb_RoomName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.ReadOnly = true;
            this.tb_RoomName.Size = new System.Drawing.Size(264, 34);
            this.tb_RoomName.TabIndex = 2;
            this.tb_RoomName.Tag = "field,handle";
            // 
            // gb_Owners
            // 
            this.gb_Owners.Controls.Add(this.lb_Warning);
            this.gb_Owners.Controls.Add(this.tb_Vets);
            this.gb_Owners.Location = new System.Drawing.Point(19, 385);
            this.gb_Owners.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Owners.Name = "gb_Owners";
            this.gb_Owners.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Owners.Size = new System.Drawing.Size(1522, 521);
            this.gb_Owners.TabIndex = 133;
            this.gb_Owners.TabStop = false;
            this.gb_Owners.Text = "Management";
            // 
            // tb_Vets
            // 
            this.tb_Vets.Controls.Add(this.tp_OwnersPets);
            this.tb_Vets.Controls.Add(this.tp_VetsRooms);
            this.tb_Vets.Controls.Add(this.tp_Services);
            this.tb_Vets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Vets.Location = new System.Drawing.Point(5, 33);
            this.tb_Vets.Name = "tb_Vets";
            this.tb_Vets.SelectedIndex = 0;
            this.tb_Vets.Size = new System.Drawing.Size(1512, 482);
            this.tb_Vets.TabIndex = 2;
            // 
            // tp_OwnersPets
            // 
            this.tp_OwnersPets.Controls.Add(this.dg_Pets);
            this.tp_OwnersPets.Controls.Add(this.dg_Owners);
            this.tp_OwnersPets.Location = new System.Drawing.Point(4, 35);
            this.tp_OwnersPets.Name = "tp_OwnersPets";
            this.tp_OwnersPets.Padding = new System.Windows.Forms.Padding(3);
            this.tp_OwnersPets.Size = new System.Drawing.Size(1504, 443);
            this.tp_OwnersPets.TabIndex = 2;
            this.tp_OwnersPets.Text = "Owners/Pets";
            this.tp_OwnersPets.UseVisualStyleBackColor = true;
            // 
            // dg_Pets
            // 
            this.dg_Pets.AllowUserToAddRows = false;
            this.dg_Pets.AllowUserToDeleteRows = false;
            this.dg_Pets.AllowUserToOrderColumns = true;
            this.dg_Pets.AllowUserToResizeColumns = false;
            this.dg_Pets.AllowUserToResizeRows = false;
            this.dg_Pets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Pets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_Pets.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dg_Pets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Pets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Pets.Dock = System.Windows.Forms.DockStyle.Right;
            this.dg_Pets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Pets.Location = new System.Drawing.Point(988, 3);
            this.dg_Pets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dg_Pets.MultiSelect = false;
            this.dg_Pets.Name = "dg_Pets";
            this.dg_Pets.RowHeadersVisible = false;
            this.dg_Pets.RowHeadersWidth = 51;
            this.dg_Pets.RowTemplate.Height = 24;
            this.dg_Pets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_Pets.Size = new System.Drawing.Size(513, 437);
            this.dg_Pets.TabIndex = 13;
            this.dg_Pets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
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
            this.dg_Owners.Dock = System.Windows.Forms.DockStyle.Left;
            this.dg_Owners.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Owners.Location = new System.Drawing.Point(3, 3);
            this.dg_Owners.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dg_Owners.MultiSelect = false;
            this.dg_Owners.Name = "dg_Owners";
            this.dg_Owners.RowHeadersVisible = false;
            this.dg_Owners.RowHeadersWidth = 51;
            this.dg_Owners.RowTemplate.Height = 24;
            this.dg_Owners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_Owners.Size = new System.Drawing.Size(975, 437);
            this.dg_Owners.TabIndex = 3;
            this.dg_Owners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            this.dg_Owners.SelectionChanged += new System.EventHandler(this.dg_Owners_SelectionChanged);
            // 
            // tp_VetsRooms
            // 
            this.tp_VetsRooms.Controls.Add(this.dg_Rooms);
            this.tp_VetsRooms.Controls.Add(this.dg_Vets);
            this.tp_VetsRooms.Location = new System.Drawing.Point(4, 35);
            this.tp_VetsRooms.Name = "tp_VetsRooms";
            this.tp_VetsRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tp_VetsRooms.Size = new System.Drawing.Size(1504, 455);
            this.tp_VetsRooms.TabIndex = 1;
            this.tp_VetsRooms.Text = "Vets/Rooms";
            this.tp_VetsRooms.UseVisualStyleBackColor = true;
            // 
            // dg_Rooms
            // 
            this.dg_Rooms.AllowUserToAddRows = false;
            this.dg_Rooms.AllowUserToDeleteRows = false;
            this.dg_Rooms.AllowUserToOrderColumns = true;
            this.dg_Rooms.AllowUserToResizeColumns = false;
            this.dg_Rooms.AllowUserToResizeRows = false;
            this.dg_Rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Rooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_Rooms.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dg_Rooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Rooms.Dock = System.Windows.Forms.DockStyle.Right;
            this.dg_Rooms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Rooms.Location = new System.Drawing.Point(1084, 3);
            this.dg_Rooms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dg_Rooms.MultiSelect = false;
            this.dg_Rooms.Name = "dg_Rooms";
            this.dg_Rooms.RowHeadersVisible = false;
            this.dg_Rooms.RowHeadersWidth = 51;
            this.dg_Rooms.RowTemplate.Height = 24;
            this.dg_Rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_Rooms.Size = new System.Drawing.Size(417, 449);
            this.dg_Rooms.TabIndex = 1;
            this.dg_Rooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
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
            this.dg_Vets.Dock = System.Windows.Forms.DockStyle.Left;
            this.dg_Vets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Vets.Location = new System.Drawing.Point(3, 3);
            this.dg_Vets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dg_Vets.MultiSelect = false;
            this.dg_Vets.Name = "dg_Vets";
            this.dg_Vets.RowHeadersVisible = false;
            this.dg_Vets.RowHeadersWidth = 51;
            this.dg_Vets.RowTemplate.Height = 24;
            this.dg_Vets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_Vets.Size = new System.Drawing.Size(1071, 449);
            this.dg_Vets.TabIndex = 2;
            this.dg_Vets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // tp_Services
            // 
            this.tp_Services.Controls.Add(this.dg_Services);
            this.tp_Services.Location = new System.Drawing.Point(4, 35);
            this.tp_Services.Name = "tp_Services";
            this.tp_Services.Size = new System.Drawing.Size(1504, 455);
            this.tp_Services.TabIndex = 3;
            this.tp_Services.Text = "Services";
            this.tp_Services.UseVisualStyleBackColor = true;
            // 
            // dg_Services
            // 
            this.dg_Services.AllowUserToAddRows = false;
            this.dg_Services.AllowUserToDeleteRows = false;
            this.dg_Services.AllowUserToOrderColumns = true;
            this.dg_Services.AllowUserToResizeColumns = false;
            this.dg_Services.AllowUserToResizeRows = false;
            this.dg_Services.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Services.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_Services.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dg_Services.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Services.Dock = System.Windows.Forms.DockStyle.Left;
            this.dg_Services.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Services.Location = new System.Drawing.Point(0, 0);
            this.dg_Services.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dg_Services.MultiSelect = false;
            this.dg_Services.Name = "dg_Services";
            this.dg_Services.RowHeadersVisible = false;
            this.dg_Services.RowHeadersWidth = 51;
            this.dg_Services.RowTemplate.Height = 24;
            this.dg_Services.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_Services.Size = new System.Drawing.Size(736, 455);
            this.dg_Services.TabIndex = 2;
            this.dg_Services.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_CancelDayAppts);
            this.groupBox1.Controls.Add(this.lb_ScheduleReminder);
            this.groupBox1.Controls.Add(this.dt_ScheduleReminder);
            this.groupBox1.Controls.Add(this.bt_Clipboard);
            this.groupBox1.Controls.Add(this.bt_SendEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Template);
            this.groupBox1.Location = new System.Drawing.Point(1155, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 364);
            this.groupBox1.TabIndex = 134;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mailing";
            // 
            // bt_CancelDayAppts
            // 
            this.bt_CancelDayAppts.Location = new System.Drawing.Point(7, 301);
            this.bt_CancelDayAppts.Name = "bt_CancelDayAppts";
            this.bt_CancelDayAppts.Size = new System.Drawing.Size(375, 45);
            this.bt_CancelDayAppts.TabIndex = 6;
            this.bt_CancelDayAppts.Text = "Cancel Today\'s Appointments";
            this.bt_CancelDayAppts.UseVisualStyleBackColor = true;
            this.bt_CancelDayAppts.Click += new System.EventHandler(this.bt_CancelDayAppts_Click);
            // 
            // lb_ScheduleReminder
            // 
            this.lb_ScheduleReminder.AutoSize = true;
            this.lb_ScheduleReminder.Location = new System.Drawing.Point(6, 205);
            this.lb_ScheduleReminder.Name = "lb_ScheduleReminder";
            this.lb_ScheduleReminder.Size = new System.Drawing.Size(188, 26);
            this.lb_ScheduleReminder.TabIndex = 5;
            this.lb_ScheduleReminder.Text = "Schedule Reminder:";
            // 
            // dt_ScheduleReminder
            // 
            this.dt_ScheduleReminder.Font = new System.Drawing.Font("Ubuntu Mono", 13.8F);
            this.dt_ScheduleReminder.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_ScheduleReminder.Location = new System.Drawing.Point(200, 203);
            this.dt_ScheduleReminder.Name = "dt_ScheduleReminder";
            this.dt_ScheduleReminder.ShowUpDown = true;
            this.dt_ScheduleReminder.Size = new System.Drawing.Size(151, 30);
            this.dt_ScheduleReminder.TabIndex = 4;
            this.dt_ScheduleReminder.ValueChanged += new System.EventHandler(this.dt_ScheduleReminder_ValueChanged);
            // 
            // bt_Clipboard
            // 
            this.bt_Clipboard.Location = new System.Drawing.Point(6, 137);
            this.bt_Clipboard.Name = "bt_Clipboard";
            this.bt_Clipboard.Size = new System.Drawing.Size(375, 45);
            this.bt_Clipboard.TabIndex = 3;
            this.bt_Clipboard.Text = "Copy Mailing List To Clipboard";
            this.bt_Clipboard.UseVisualStyleBackColor = true;
            this.bt_Clipboard.Click += new System.EventHandler(this.bt_Clipboard_Click);
            // 
            // bt_SendEmail
            // 
            this.bt_SendEmail.Location = new System.Drawing.Point(6, 86);
            this.bt_SendEmail.Name = "bt_SendEmail";
            this.bt_SendEmail.Size = new System.Drawing.Size(375, 45);
            this.bt_SendEmail.TabIndex = 2;
            this.bt_SendEmail.Text = "Send Email";
            this.bt_SendEmail.UseVisualStyleBackColor = true;
            this.bt_SendEmail.Click += new System.EventHandler(this.bt_SendEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Template:";
            // 
            // cb_Template
            // 
            this.cb_Template.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Template.FormattingEnabled = true;
            this.cb_Template.Location = new System.Drawing.Point(111, 34);
            this.cb_Template.Name = "cb_Template";
            this.cb_Template.Size = new System.Drawing.Size(263, 34);
            this.cb_Template.TabIndex = 0;
            // 
            // gb_ServiceInfo
            // 
            this.gb_ServiceInfo.Controls.Add(this.lb_PriceSymb);
            this.gb_ServiceInfo.Controls.Add(this.lb_ServicePrice);
            this.gb_ServiceInfo.Controls.Add(this.tb_ServicePrice);
            this.gb_ServiceInfo.Controls.Add(this.bt_CancelService);
            this.gb_ServiceInfo.Controls.Add(this.bt_EditService);
            this.gb_ServiceInfo.Controls.Add(this.bt_SaveService);
            this.gb_ServiceInfo.Controls.Add(this.bt_NewService);
            this.gb_ServiceInfo.Controls.Add(this.lb_ServiceName);
            this.gb_ServiceInfo.Controls.Add(this.tb_ServiceName);
            this.gb_ServiceInfo.Location = new System.Drawing.Point(374, 178);
            this.gb_ServiceInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_ServiceInfo.Name = "gb_ServiceInfo";
            this.gb_ServiceInfo.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_ServiceInfo.Size = new System.Drawing.Size(390, 198);
            this.gb_ServiceInfo.TabIndex = 132;
            this.gb_ServiceInfo.TabStop = false;
            this.gb_ServiceInfo.Text = "Service Info";
            // 
            // lb_ServicePrice
            // 
            this.lb_ServicePrice.AutoSize = true;
            this.lb_ServicePrice.Location = new System.Drawing.Point(36, 144);
            this.lb_ServicePrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ServicePrice.Name = "lb_ServicePrice";
            this.lb_ServicePrice.Size = new System.Drawing.Size(62, 26);
            this.lb_ServicePrice.TabIndex = 12;
            this.lb_ServicePrice.Text = "Price:";
            // 
            // tb_ServicePrice
            // 
            this.tb_ServicePrice.Location = new System.Drawing.Point(108, 141);
            this.tb_ServicePrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ServicePrice.Name = "tb_ServicePrice";
            this.tb_ServicePrice.ReadOnly = true;
            this.tb_ServicePrice.Size = new System.Drawing.Size(231, 34);
            this.tb_ServicePrice.TabIndex = 11;
            this.tb_ServicePrice.Tag = "field,float";
            // 
            // bt_CancelService
            // 
            this.bt_CancelService.Enabled = false;
            this.bt_CancelService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelService.Location = new System.Drawing.Point(196, 39);
            this.bt_CancelService.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_CancelService.Name = "bt_CancelService";
            this.bt_CancelService.Size = new System.Drawing.Size(83, 32);
            this.bt_CancelService.TabIndex = 9;
            this.bt_CancelService.Tag = "option";
            this.bt_CancelService.Text = "Canc.";
            this.bt_CancelService.UseVisualStyleBackColor = true;
            this.bt_CancelService.Click += new System.EventHandler(this.bt_CancelService_Click);
            // 
            // bt_EditService
            // 
            this.bt_EditService.Enabled = false;
            this.bt_EditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditService.Location = new System.Drawing.Point(103, 39);
            this.bt_EditService.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_EditService.Name = "bt_EditService";
            this.bt_EditService.Size = new System.Drawing.Size(83, 32);
            this.bt_EditService.TabIndex = 8;
            this.bt_EditService.Tag = "action";
            this.bt_EditService.Text = "Edit";
            this.bt_EditService.UseVisualStyleBackColor = true;
            this.bt_EditService.Click += new System.EventHandler(this.bt_EditService_Click);
            // 
            // bt_SaveService
            // 
            this.bt_SaveService.Enabled = false;
            this.bt_SaveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveService.Location = new System.Drawing.Point(289, 39);
            this.bt_SaveService.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_SaveService.Name = "bt_SaveService";
            this.bt_SaveService.Size = new System.Drawing.Size(83, 32);
            this.bt_SaveService.TabIndex = 10;
            this.bt_SaveService.Tag = "option";
            this.bt_SaveService.Text = "Save";
            this.bt_SaveService.UseVisualStyleBackColor = true;
            this.bt_SaveService.Click += new System.EventHandler(this.bt_SaveService_Click);
            // 
            // bt_NewService
            // 
            this.bt_NewService.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_NewService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NewService.Location = new System.Drawing.Point(10, 39);
            this.bt_NewService.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_NewService.Name = "bt_NewService";
            this.bt_NewService.Size = new System.Drawing.Size(83, 32);
            this.bt_NewService.TabIndex = 7;
            this.bt_NewService.Tag = "action";
            this.bt_NewService.Text = "New";
            this.bt_NewService.UseVisualStyleBackColor = false;
            this.bt_NewService.Click += new System.EventHandler(this.bt_NewService_Click);
            // 
            // lb_ServiceName
            // 
            this.lb_ServiceName.AutoSize = true;
            this.lb_ServiceName.Location = new System.Drawing.Point(29, 98);
            this.lb_ServiceName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ServiceName.Name = "lb_ServiceName";
            this.lb_ServiceName.Size = new System.Drawing.Size(70, 26);
            this.lb_ServiceName.TabIndex = 3;
            this.lb_ServiceName.Text = "Name:";
            // 
            // tb_ServiceName
            // 
            this.tb_ServiceName.Location = new System.Drawing.Point(108, 95);
            this.tb_ServiceName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ServiceName.Name = "tb_ServiceName";
            this.tb_ServiceName.ReadOnly = true;
            this.tb_ServiceName.Size = new System.Drawing.Size(264, 34);
            this.tb_ServiceName.TabIndex = 2;
            this.tb_ServiceName.Tag = "field,handle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_Services);
            this.groupBox3.Location = new System.Drawing.Point(774, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Size = new System.Drawing.Size(373, 361);
            this.groupBox3.TabIndex = 133;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Services";
            // 
            // lb_Services
            // 
            this.lb_Services.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Services.FormattingEnabled = true;
            this.lb_Services.ItemHeight = 26;
            this.lb_Services.Location = new System.Drawing.Point(5, 33);
            this.lb_Services.Name = "lb_Services";
            this.lb_Services.Size = new System.Drawing.Size(363, 322);
            this.lb_Services.TabIndex = 0;
            this.lb_Services.SelectedIndexChanged += new System.EventHandler(this.lb_Services_SelectedIndexChanged);
            this.lb_Services.DataSourceChanged += new System.EventHandler(this.lb_Services_SelectedIndexChanged);
            // 
            // lb_PriceSymb
            // 
            this.lb_PriceSymb.AutoSize = true;
            this.lb_PriceSymb.Location = new System.Drawing.Point(349, 144);
            this.lb_PriceSymb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_PriceSymb.Name = "lb_PriceSymb";
            this.lb_PriceSymb.Size = new System.Drawing.Size(23, 26);
            this.lb_PriceSymb.TabIndex = 13;
            this.lb_PriceSymb.Text = "$";
            // 
            // lb_Warning
            // 
            this.lb_Warning.AutoSize = true;
            this.lb_Warning.ForeColor = System.Drawing.Color.Red;
            this.lb_Warning.Location = new System.Drawing.Point(524, 38);
            this.lb_Warning.Name = "lb_Warning";
            this.lb_Warning.Size = new System.Drawing.Size(854, 26);
            this.lb_Warning.TabIndex = 14;
            this.lb_Warning.Text = "WARNING: Disabling elements might cause any active appointments to be cancelled a" +
    "ccordingly.";
            // 
            // InternalViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1555, 921);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_ServiceInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Owners);
            this.Controls.Add(this.gb_Rooms);
            this.Controls.Add(this.gb_RoomInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Red Hat Display", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InternalViewForm";
            this.Text = "Internal";
            this.Load += new System.EventHandler(this.InternalViewForm_Load);
            this.gb_Rooms.ResumeLayout(false);
            this.gb_RoomInfo.ResumeLayout(false);
            this.gb_RoomInfo.PerformLayout();
            this.gb_Owners.ResumeLayout(false);
            this.gb_Owners.PerformLayout();
            this.tb_Vets.ResumeLayout(false);
            this.tp_OwnersPets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Pets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Owners)).EndInit();
            this.tp_VetsRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Vets)).EndInit();
            this.tp_Services.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Services)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_ServiceInfo.ResumeLayout(false);
            this.gb_ServiceInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Rooms;
        private System.Windows.Forms.TreeView tv_Rooms;
        private System.Windows.Forms.GroupBox gb_RoomInfo;
        private System.Windows.Forms.Button bt_CancelRoom;
        private System.Windows.Forms.Button bt_EditRoom;
        private System.Windows.Forms.Button bt_SaveRoom;
        private System.Windows.Forms.Button bt_NewRoom;
        private System.Windows.Forms.Label lb_OwnerName;
        private System.Windows.Forms.TextBox tb_RoomName;
        private System.Windows.Forms.GroupBox gb_Owners;
        private System.Windows.Forms.TabControl tb_Vets;
        private System.Windows.Forms.DataGridView dg_Rooms;
        private System.Windows.Forms.TabPage tp_VetsRooms;
        private System.Windows.Forms.DataGridView dg_Vets;
        private System.Windows.Forms.TabPage tp_OwnersPets;
        private System.Windows.Forms.DataGridView dg_Owners;
        private System.Windows.Forms.DataGridView dg_Pets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Template;
        private System.Windows.Forms.Button bt_SendEmail;
        private System.Windows.Forms.Button bt_Clipboard;
        private System.Windows.Forms.GroupBox gb_ServiceInfo;
        private System.Windows.Forms.Label lb_ServicePrice;
        private System.Windows.Forms.TextBox tb_ServicePrice;
        private System.Windows.Forms.Button bt_CancelService;
        private System.Windows.Forms.Button bt_EditService;
        private System.Windows.Forms.Button bt_SaveService;
        private System.Windows.Forms.Button bt_NewService;
        private System.Windows.Forms.Label lb_ServiceName;
        private System.Windows.Forms.TextBox tb_ServiceName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lb_Services;
        private System.Windows.Forms.TabPage tp_Services;
        private System.Windows.Forms.DataGridView dg_Services;
        private System.Windows.Forms.DateTimePicker dt_ScheduleReminder;
        private System.Windows.Forms.Label lb_ScheduleReminder;
        private System.Windows.Forms.Button bt_CancelDayAppts;
        private System.Windows.Forms.Label lb_PriceSymb;
        private System.Windows.Forms.Label lb_Warning;
    }
}