namespace DashPetApp.Forms
{
    partial class AppointmentsViewForm
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
            this.gb_Appointments = new System.Windows.Forms.GroupBox();
            this.dg_Appts = new System.Windows.Forms.DataGridView();
            this.dt_SelectedDate = new System.Windows.Forms.DateTimePicker();
            this.gb_ApptInfo = new System.Windows.Forms.GroupBox();
            this.lb_ApptService = new System.Windows.Forms.Label();
            this.cb_ApptService = new System.Windows.Forms.ComboBox();
            this.bt_ConfirmAppt = new System.Windows.Forms.Button();
            this.tb_PetSpecies = new System.Windows.Forms.TextBox();
            this.tb_ApptOwner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_DelAppt = new System.Windows.Forms.Button();
            this.lb_ApptVet = new System.Windows.Forms.Label();
            this.cb_ApptVet = new System.Windows.Forms.ComboBox();
            this.tb_ApptPet = new System.Windows.Forms.TextBox();
            this.tb_ApptId = new System.Windows.Forms.TextBox();
            this.lb_ApptId = new System.Windows.Forms.Label();
            this.bt_CancelAppt = new System.Windows.Forms.Button();
            this.lb_ApptNotes = new System.Windows.Forms.Label();
            this.tb_ApptNotes = new System.Windows.Forms.TextBox();
            this.bt_SaveAppt = new System.Windows.Forms.Button();
            this.lb_ApptDate = new System.Windows.Forms.Label();
            this.bt_EditAppt = new System.Windows.Forms.Button();
            this.dt_ApptDate = new System.Windows.Forms.DateTimePicker();
            this.cb_ApptSlot = new System.Windows.Forms.ComboBox();
            this.lb_ApptPet = new System.Windows.Forms.Label();
            this.gb_NotePad = new System.Windows.Forms.GroupBox();
            this.tb_NotePad = new System.Windows.Forms.TextBox();
            this.gb_Appointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Appts)).BeginInit();
            this.gb_ApptInfo.SuspendLayout();
            this.gb_NotePad.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Appointments
            // 
            this.gb_Appointments.Controls.Add(this.dg_Appts);
            this.gb_Appointments.Controls.Add(this.dt_SelectedDate);
            this.gb_Appointments.Location = new System.Drawing.Point(14, 15);
            this.gb_Appointments.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Appointments.Name = "gb_Appointments";
            this.gb_Appointments.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_Appointments.Size = new System.Drawing.Size(692, 891);
            this.gb_Appointments.TabIndex = 134;
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
            this.dg_Appts.Location = new System.Drawing.Point(5, 63);
            this.dg_Appts.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dg_Appts.MultiSelect = false;
            this.dg_Appts.Name = "dg_Appts";
            this.dg_Appts.RowHeadersVisible = false;
            this.dg_Appts.RowHeadersWidth = 51;
            this.dg_Appts.RowTemplate.Height = 24;
            this.dg_Appts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_Appts.Size = new System.Drawing.Size(682, 822);
            this.dg_Appts.TabIndex = 12;
            this.dg_Appts.DataSourceChanged += new System.EventHandler(this.dg_Appts_DataSourceOrSelectionChanged);
            this.dg_Appts.SelectionChanged += new System.EventHandler(this.dg_Appts_DataSourceOrSelectionChanged);
            // 
            // dt_SelectedDate
            // 
            this.dt_SelectedDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dt_SelectedDate.Font = new System.Drawing.Font("Ubuntu Mono", 13.8F);
            this.dt_SelectedDate.Location = new System.Drawing.Point(5, 33);
            this.dt_SelectedDate.Name = "dt_SelectedDate";
            this.dt_SelectedDate.Size = new System.Drawing.Size(682, 30);
            this.dt_SelectedDate.TabIndex = 135;
            this.dt_SelectedDate.ValueChanged += new System.EventHandler(this.dt_SelectedDate_ValueChanged);
            // 
            // gb_ApptInfo
            // 
            this.gb_ApptInfo.Controls.Add(this.lb_ApptService);
            this.gb_ApptInfo.Controls.Add(this.cb_ApptService);
            this.gb_ApptInfo.Controls.Add(this.bt_ConfirmAppt);
            this.gb_ApptInfo.Controls.Add(this.tb_PetSpecies);
            this.gb_ApptInfo.Controls.Add(this.tb_ApptOwner);
            this.gb_ApptInfo.Controls.Add(this.label1);
            this.gb_ApptInfo.Controls.Add(this.bt_DelAppt);
            this.gb_ApptInfo.Controls.Add(this.lb_ApptVet);
            this.gb_ApptInfo.Controls.Add(this.cb_ApptVet);
            this.gb_ApptInfo.Controls.Add(this.tb_ApptPet);
            this.gb_ApptInfo.Controls.Add(this.tb_ApptId);
            this.gb_ApptInfo.Controls.Add(this.lb_ApptId);
            this.gb_ApptInfo.Controls.Add(this.bt_CancelAppt);
            this.gb_ApptInfo.Controls.Add(this.lb_ApptNotes);
            this.gb_ApptInfo.Controls.Add(this.tb_ApptNotes);
            this.gb_ApptInfo.Controls.Add(this.bt_SaveAppt);
            this.gb_ApptInfo.Controls.Add(this.lb_ApptDate);
            this.gb_ApptInfo.Controls.Add(this.bt_EditAppt);
            this.gb_ApptInfo.Controls.Add(this.dt_ApptDate);
            this.gb_ApptInfo.Controls.Add(this.cb_ApptSlot);
            this.gb_ApptInfo.Controls.Add(this.lb_ApptPet);
            this.gb_ApptInfo.Location = new System.Drawing.Point(716, 15);
            this.gb_ApptInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_ApptInfo.Name = "gb_ApptInfo";
            this.gb_ApptInfo.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gb_ApptInfo.Size = new System.Drawing.Size(825, 521);
            this.gb_ApptInfo.TabIndex = 139;
            this.gb_ApptInfo.TabStop = false;
            this.gb_ApptInfo.Text = "Appointment Info";
            // 
            // lb_ApptService
            // 
            this.lb_ApptService.AutoSize = true;
            this.lb_ApptService.Location = new System.Drawing.Point(87, 281);
            this.lb_ApptService.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptService.Name = "lb_ApptService";
            this.lb_ApptService.Size = new System.Drawing.Size(82, 26);
            this.lb_ApptService.TabIndex = 126;
            this.lb_ApptService.Text = "Service:";
            // 
            // cb_ApptService
            // 
            this.cb_ApptService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ApptService.Enabled = false;
            this.cb_ApptService.FormattingEnabled = true;
            this.cb_ApptService.Location = new System.Drawing.Point(179, 278);
            this.cb_ApptService.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_ApptService.Name = "cb_ApptService";
            this.cb_ApptService.Size = new System.Drawing.Size(478, 34);
            this.cb_ApptService.TabIndex = 125;
            this.cb_ApptService.Tag = "field";
            // 
            // bt_ConfirmAppt
            // 
            this.bt_ConfirmAppt.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_ConfirmAppt.Enabled = false;
            this.bt_ConfirmAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ConfirmAppt.Location = new System.Drawing.Point(541, 39);
            this.bt_ConfirmAppt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_ConfirmAppt.Name = "bt_ConfirmAppt";
            this.bt_ConfirmAppt.Size = new System.Drawing.Size(107, 32);
            this.bt_ConfirmAppt.TabIndex = 124;
            this.bt_ConfirmAppt.Tag = "action";
            this.bt_ConfirmAppt.Text = "Confirm";
            this.bt_ConfirmAppt.UseVisualStyleBackColor = false;
            this.bt_ConfirmAppt.Click += new System.EventHandler(this.bt_ConfirmAppt_Click);
            // 
            // tb_PetSpecies
            // 
            this.tb_PetSpecies.Location = new System.Drawing.Point(380, 143);
            this.tb_PetSpecies.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_PetSpecies.Name = "tb_PetSpecies";
            this.tb_PetSpecies.ReadOnly = true;
            this.tb_PetSpecies.Size = new System.Drawing.Size(277, 34);
            this.tb_PetSpecies.TabIndex = 123;
            this.tb_PetSpecies.Tag = "";
            // 
            // tb_ApptOwner
            // 
            this.tb_ApptOwner.Location = new System.Drawing.Point(466, 97);
            this.tb_ApptOwner.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ApptOwner.Name = "tb_ApptOwner";
            this.tb_ApptOwner.ReadOnly = true;
            this.tb_ApptOwner.Size = new System.Drawing.Size(191, 34);
            this.tb_ApptOwner.TabIndex = 122;
            this.tb_ApptOwner.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 100);
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
            this.bt_DelAppt.Location = new System.Drawing.Point(436, 39);
            this.bt_DelAppt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_DelAppt.Name = "bt_DelAppt";
            this.bt_DelAppt.Size = new System.Drawing.Size(95, 32);
            this.bt_DelAppt.TabIndex = 120;
            this.bt_DelAppt.Tag = "action";
            this.bt_DelAppt.Text = "Delete";
            this.bt_DelAppt.UseVisualStyleBackColor = true;
            this.bt_DelAppt.Click += new System.EventHandler(this.bt_DelAppt_Click);
            // 
            // lb_ApptVet
            // 
            this.lb_ApptVet.AutoSize = true;
            this.lb_ApptVet.Location = new System.Drawing.Point(121, 237);
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
            this.cb_ApptVet.Location = new System.Drawing.Point(179, 232);
            this.cb_ApptVet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_ApptVet.Name = "cb_ApptVet";
            this.cb_ApptVet.Size = new System.Drawing.Size(478, 34);
            this.cb_ApptVet.TabIndex = 118;
            this.cb_ApptVet.Tag = "field";
            // 
            // tb_ApptPet
            // 
            this.tb_ApptPet.Location = new System.Drawing.Point(179, 143);
            this.tb_ApptPet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ApptPet.Name = "tb_ApptPet";
            this.tb_ApptPet.ReadOnly = true;
            this.tb_ApptPet.Size = new System.Drawing.Size(191, 34);
            this.tb_ApptPet.TabIndex = 117;
            this.tb_ApptPet.Tag = "";
            // 
            // tb_ApptId
            // 
            this.tb_ApptId.Location = new System.Drawing.Point(179, 97);
            this.tb_ApptId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ApptId.Name = "tb_ApptId";
            this.tb_ApptId.ReadOnly = true;
            this.tb_ApptId.Size = new System.Drawing.Size(191, 34);
            this.tb_ApptId.TabIndex = 13;
            this.tb_ApptId.Tag = "";
            // 
            // lb_ApptId
            // 
            this.lb_ApptId.AutoSize = true;
            this.lb_ApptId.Location = new System.Drawing.Point(133, 100);
            this.lb_ApptId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptId.Name = "lb_ApptId";
            this.lb_ApptId.Size = new System.Drawing.Size(36, 26);
            this.lb_ApptId.TabIndex = 115;
            this.lb_ApptId.Text = "ID:";
            // 
            // bt_CancelAppt
            // 
            this.bt_CancelAppt.Enabled = false;
            this.bt_CancelAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelAppt.Location = new System.Drawing.Point(250, 39);
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
            this.lb_ApptNotes.Location = new System.Drawing.Point(99, 327);
            this.lb_ApptNotes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptNotes.Name = "lb_ApptNotes";
            this.lb_ApptNotes.Size = new System.Drawing.Size(70, 26);
            this.lb_ApptNotes.TabIndex = 114;
            this.lb_ApptNotes.Text = "Notes:";
            // 
            // tb_ApptNotes
            // 
            this.tb_ApptNotes.Location = new System.Drawing.Point(179, 324);
            this.tb_ApptNotes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_ApptNotes.Multiline = true;
            this.tb_ApptNotes.Name = "tb_ApptNotes";
            this.tb_ApptNotes.ReadOnly = true;
            this.tb_ApptNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ApptNotes.Size = new System.Drawing.Size(591, 172);
            this.tb_ApptNotes.TabIndex = 20;
            this.tb_ApptNotes.Tag = "field,notes";
            // 
            // bt_SaveAppt
            // 
            this.bt_SaveAppt.Enabled = false;
            this.bt_SaveAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveAppt.Location = new System.Drawing.Point(343, 39);
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
            this.lb_ApptDate.Location = new System.Drawing.Point(110, 191);
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
            this.bt_EditAppt.Location = new System.Drawing.Point(157, 39);
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
            this.dt_ApptDate.Location = new System.Drawing.Point(179, 190);
            this.dt_ApptDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dt_ApptDate.Name = "dt_ApptDate";
            this.dt_ApptDate.Size = new System.Drawing.Size(191, 30);
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
            this.cb_ApptSlot.Location = new System.Drawing.Point(380, 188);
            this.cb_ApptSlot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_ApptSlot.Name = "cb_ApptSlot";
            this.cb_ApptSlot.Size = new System.Drawing.Size(277, 34);
            this.cb_ApptSlot.TabIndex = 17;
            this.cb_ApptSlot.Tag = "field";
            this.cb_ApptSlot.SelectedIndexChanged += new System.EventHandler(this.cb_ApptSlot_DataSourceOrSelectedIndexChanged);
            this.cb_ApptSlot.DataSourceChanged += new System.EventHandler(this.cb_ApptSlot_DataSourceOrSelectedIndexChanged);
            // 
            // lb_ApptPet
            // 
            this.lb_ApptPet.AutoSize = true;
            this.lb_ApptPet.Location = new System.Drawing.Point(122, 146);
            this.lb_ApptPet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_ApptPet.Name = "lb_ApptPet";
            this.lb_ApptPet.Size = new System.Drawing.Size(47, 26);
            this.lb_ApptPet.TabIndex = 104;
            this.lb_ApptPet.Text = "Pet:";
            // 
            // gb_NotePad
            // 
            this.gb_NotePad.Controls.Add(this.tb_NotePad);
            this.gb_NotePad.Location = new System.Drawing.Point(716, 545);
            this.gb_NotePad.Name = "gb_NotePad";
            this.gb_NotePad.Size = new System.Drawing.Size(825, 361);
            this.gb_NotePad.TabIndex = 140;
            this.gb_NotePad.TabStop = false;
            this.gb_NotePad.Text = "NotePad";
            // 
            // tb_NotePad
            // 
            this.tb_NotePad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_NotePad.Location = new System.Drawing.Point(3, 30);
            this.tb_NotePad.Multiline = true;
            this.tb_NotePad.Name = "tb_NotePad";
            this.tb_NotePad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_NotePad.Size = new System.Drawing.Size(819, 328);
            this.tb_NotePad.TabIndex = 0;
            this.tb_NotePad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_NotePad_KeyUp);
            // 
            // AppointmentsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1555, 921);
            this.ControlBox = false;
            this.Controls.Add(this.gb_NotePad);
            this.Controls.Add(this.gb_ApptInfo);
            this.Controls.Add(this.gb_Appointments);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Red Hat Display", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentsViewForm";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.AppointmentsViewForm_Load);
            this.gb_Appointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Appts)).EndInit();
            this.gb_ApptInfo.ResumeLayout(false);
            this.gb_ApptInfo.PerformLayout();
            this.gb_NotePad.ResumeLayout(false);
            this.gb_NotePad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Appointments;
        private System.Windows.Forms.DateTimePicker dt_SelectedDate;
        private System.Windows.Forms.DataGridView dg_Appts;
        private System.Windows.Forms.GroupBox gb_ApptInfo;
        private System.Windows.Forms.TextBox tb_PetSpecies;
        private System.Windows.Forms.TextBox tb_ApptOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_DelAppt;
        private System.Windows.Forms.Label lb_ApptVet;
        private System.Windows.Forms.ComboBox cb_ApptVet;
        private System.Windows.Forms.TextBox tb_ApptPet;
        private System.Windows.Forms.TextBox tb_ApptId;
        private System.Windows.Forms.Label lb_ApptId;
        private System.Windows.Forms.Button bt_CancelAppt;
        private System.Windows.Forms.Label lb_ApptNotes;
        private System.Windows.Forms.TextBox tb_ApptNotes;
        private System.Windows.Forms.Button bt_SaveAppt;
        private System.Windows.Forms.Label lb_ApptDate;
        private System.Windows.Forms.Button bt_EditAppt;
        private System.Windows.Forms.DateTimePicker dt_ApptDate;
        private System.Windows.Forms.ComboBox cb_ApptSlot;
        private System.Windows.Forms.Label lb_ApptPet;
        private System.Windows.Forms.Button bt_ConfirmAppt;
        private System.Windows.Forms.Label lb_ApptService;
        private System.Windows.Forms.ComboBox cb_ApptService;
        private System.Windows.Forms.GroupBox gb_NotePad;
        private System.Windows.Forms.TextBox tb_NotePad;
    }
}