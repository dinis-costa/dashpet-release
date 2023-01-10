namespace DashPetApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.bt_Email = new System.Windows.Forms.Button();
            this.bt_Internal = new System.Windows.Forms.Button();
            this.bt_Vets = new System.Windows.Forms.Button();
            this.bt_Info = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_Customers = new System.Windows.Forms.Button();
            this.bt_Appointments = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.lb_Logo = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lb_DateTime = new System.Windows.Forms.Label();
            this.bt_Minimize = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_OpenForm = new System.Windows.Forms.Panel();
            this.lb_FirstView = new System.Windows.Forms.Label();
            this.tmr_Local = new System.Windows.Forms.Timer(this.components);
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.panel_OpenForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_Menu.Controls.Add(this.bt_Email);
            this.panel_Menu.Controls.Add(this.bt_Internal);
            this.panel_Menu.Controls.Add(this.bt_Vets);
            this.panel_Menu.Controls.Add(this.bt_Info);
            this.panel_Menu.Controls.Add(this.bt_Exit);
            this.panel_Menu.Controls.Add(this.bt_Customers);
            this.panel_Menu.Controls.Add(this.bt_Appointments);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(300, 729);
            this.panel_Menu.TabIndex = 0;
            // 
            // bt_Email
            // 
            this.bt_Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Email.FlatAppearance.BorderSize = 0;
            this.bt_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Email.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Email.ForeColor = System.Drawing.Color.White;
            this.bt_Email.Image = global::DashPetApp.Properties.Resources.email;
            this.bt_Email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Email.Location = new System.Drawing.Point(0, 461);
            this.bt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Email.Name = "bt_Email";
            this.bt_Email.Padding = new System.Windows.Forms.Padding(16, 0, 30, 3);
            this.bt_Email.Size = new System.Drawing.Size(300, 90);
            this.bt_Email.TabIndex = 9;
            this.bt_Email.Tag = "";
            this.bt_Email.Text = "Email";
            this.bt_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Email.UseVisualStyleBackColor = true;
            this.bt_Email.Click += new System.EventHandler(this.MainMenuButtonClick);
            // 
            // bt_Internal
            // 
            this.bt_Internal.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Internal.FlatAppearance.BorderSize = 0;
            this.bt_Internal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Internal.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Internal.ForeColor = System.Drawing.Color.White;
            this.bt_Internal.Image = global::DashPetApp.Properties.Resources.admin;
            this.bt_Internal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Internal.Location = new System.Drawing.Point(0, 371);
            this.bt_Internal.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Internal.Name = "bt_Internal";
            this.bt_Internal.Padding = new System.Windows.Forms.Padding(16, 0, 30, 3);
            this.bt_Internal.Size = new System.Drawing.Size(300, 90);
            this.bt_Internal.TabIndex = 8;
            this.bt_Internal.Tag = "";
            this.bt_Internal.Text = "Internal";
            this.bt_Internal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Internal.UseVisualStyleBackColor = true;
            this.bt_Internal.Click += new System.EventHandler(this.MainMenuButtonClick);
            // 
            // bt_Vets
            // 
            this.bt_Vets.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Vets.FlatAppearance.BorderSize = 0;
            this.bt_Vets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Vets.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Vets.ForeColor = System.Drawing.Color.White;
            this.bt_Vets.Image = ((System.Drawing.Image)(resources.GetObject("bt_Vets.Image")));
            this.bt_Vets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Vets.Location = new System.Drawing.Point(0, 281);
            this.bt_Vets.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Vets.Name = "bt_Vets";
            this.bt_Vets.Padding = new System.Windows.Forms.Padding(16, 0, 30, 3);
            this.bt_Vets.Size = new System.Drawing.Size(300, 90);
            this.bt_Vets.TabIndex = 10;
            this.bt_Vets.Tag = "";
            this.bt_Vets.Text = "Vets";
            this.bt_Vets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Vets.UseVisualStyleBackColor = true;
            this.bt_Vets.Click += new System.EventHandler(this.MainMenuButtonClick);
            // 
            // bt_Info
            // 
            this.bt_Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Info.FlatAppearance.BorderSize = 0;
            this.bt_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Info.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Info.ForeColor = System.Drawing.Color.White;
            this.bt_Info.Image = ((System.Drawing.Image)(resources.GetObject("bt_Info.Image")));
            this.bt_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Info.Location = new System.Drawing.Point(0, 549);
            this.bt_Info.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Info.Name = "bt_Info";
            this.bt_Info.Padding = new System.Windows.Forms.Padding(16, 0, 30, 3);
            this.bt_Info.Size = new System.Drawing.Size(300, 90);
            this.bt_Info.TabIndex = 6;
            this.bt_Info.Tag = "";
            this.bt_Info.Text = "About";
            this.bt_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Info.UseVisualStyleBackColor = true;
            this.bt_Info.Click += new System.EventHandler(this.MainMenuButtonClick);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Exit.FlatAppearance.BorderSize = 0;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.ForeColor = System.Drawing.Color.White;
            this.bt_Exit.Image = global::DashPetApp.Properties.Resources._switch;
            this.bt_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Exit.Location = new System.Drawing.Point(0, 639);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Padding = new System.Windows.Forms.Padding(16, 0, 30, 3);
            this.bt_Exit.Size = new System.Drawing.Size(300, 90);
            this.bt_Exit.TabIndex = 5;
            this.bt_Exit.Tag = "";
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.MainMenuButtonClick);
            // 
            // bt_Customers
            // 
            this.bt_Customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Customers.FlatAppearance.BorderSize = 0;
            this.bt_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Customers.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Customers.ForeColor = System.Drawing.Color.White;
            this.bt_Customers.Image = global::DashPetApp.Properties.Resources.customer;
            this.bt_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Customers.Location = new System.Drawing.Point(0, 191);
            this.bt_Customers.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Customers.Name = "bt_Customers";
            this.bt_Customers.Padding = new System.Windows.Forms.Padding(16, 0, 30, 3);
            this.bt_Customers.Size = new System.Drawing.Size(300, 90);
            this.bt_Customers.TabIndex = 4;
            this.bt_Customers.Tag = "";
            this.bt_Customers.Text = "Customers";
            this.bt_Customers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Customers.UseVisualStyleBackColor = true;
            this.bt_Customers.Click += new System.EventHandler(this.MainMenuButtonClick);
            // 
            // bt_Appointments
            // 
            this.bt_Appointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Appointments.FlatAppearance.BorderSize = 0;
            this.bt_Appointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Appointments.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Appointments.ForeColor = System.Drawing.Color.White;
            this.bt_Appointments.Image = global::DashPetApp.Properties.Resources.calendar;
            this.bt_Appointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Appointments.Location = new System.Drawing.Point(0, 101);
            this.bt_Appointments.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Appointments.Name = "bt_Appointments";
            this.bt_Appointments.Padding = new System.Windows.Forms.Padding(16, 0, 30, 3);
            this.bt_Appointments.Size = new System.Drawing.Size(300, 90);
            this.bt_Appointments.TabIndex = 3;
            this.bt_Appointments.Tag = "";
            this.bt_Appointments.Text = "Appointments";
            this.bt_Appointments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Appointments.UseVisualStyleBackColor = true;
            this.bt_Appointments.Click += new System.EventHandler(this.MainMenuButtonClick);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.panel_Logo.Controls.Add(this.lb_Logo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(300, 101);
            this.panel_Logo.TabIndex = 0;
            // 
            // lb_Logo
            // 
            this.lb_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lb_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Logo.Font = new System.Drawing.Font("Baloo 2 SemiBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Logo.ForeColor = System.Drawing.Color.White;
            this.lb_Logo.Location = new System.Drawing.Point(0, 0);
            this.lb_Logo.Name = "lb_Logo";
            this.lb_Logo.Size = new System.Drawing.Size(300, 101);
            this.lb_Logo.TabIndex = 0;
            this.lb_Logo.Text = "DashPet🐾";
            this.lb_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_Top.Controls.Add(this.lb_DateTime);
            this.panel_Top.Controls.Add(this.bt_Minimize);
            this.panel_Top.Controls.Add(this.lb_Title);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(300, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1084, 101);
            this.panel_Top.TabIndex = 1;
            // 
            // lb_DateTime
            // 
            this.lb_DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DateTime.AutoSize = true;
            this.lb_DateTime.Font = new System.Drawing.Font("Source Code Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DateTime.ForeColor = System.Drawing.Color.White;
            this.lb_DateTime.Location = new System.Drawing.Point(699, 39);
            this.lb_DateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DateTime.Name = "lb_DateTime";
            this.lb_DateTime.Size = new System.Drawing.Size(127, 36);
            this.lb_DateTime.TabIndex = 2;
            this.lb_DateTime.Text = "DateTime";
            this.lb_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Minimize
            // 
            this.bt_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Minimize.AutoSize = true;
            this.bt_Minimize.BackgroundImage = global::DashPetApp.Properties.Resources.minimize;
            this.bt_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Minimize.FlatAppearance.BorderSize = 0;
            this.bt_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Minimize.Location = new System.Drawing.Point(1043, 9);
            this.bt_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Minimize.Name = "bt_Minimize";
            this.bt_Minimize.Size = new System.Drawing.Size(32, 32);
            this.bt_Minimize.TabIndex = 1;
            this.bt_Minimize.UseVisualStyleBackColor = true;
            this.bt_Minimize.Click += new System.EventHandler(this.MainMenuButtonClick);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold);
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(56, 32);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(106, 37);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "HOME";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_OpenForm
            // 
            this.panel_OpenForm.BackColor = System.Drawing.Color.White;
            this.panel_OpenForm.Controls.Add(this.lb_FirstView);
            this.panel_OpenForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OpenForm.Location = new System.Drawing.Point(300, 101);
            this.panel_OpenForm.Margin = new System.Windows.Forms.Padding(4);
            this.panel_OpenForm.Name = "panel_OpenForm";
            this.panel_OpenForm.Padding = new System.Windows.Forms.Padding(30);
            this.panel_OpenForm.Size = new System.Drawing.Size(1084, 628);
            this.panel_OpenForm.TabIndex = 2;
            // 
            // lb_FirstView
            // 
            this.lb_FirstView.BackColor = System.Drawing.Color.White;
            this.lb_FirstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FirstView.Font = new System.Drawing.Font("Baloo 2 SemiBold", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FirstView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lb_FirstView.Location = new System.Drawing.Point(30, 30);
            this.lb_FirstView.Name = "lb_FirstView";
            this.lb_FirstView.Size = new System.Drawing.Size(1024, 568);
            this.lb_FirstView.TabIndex = 1;
            this.lb_FirstView.Text = "DashPet🐾";
            this.lb_FirstView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_Local
            // 
            this.tmr_Local.Tick += new System.EventHandler(this.tmr_Local_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1384, 729);
            this.ControlBox = false;
            this.Controls.Add(this.panel_OpenForm);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Menu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashPet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Menu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_OpenForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Button bt_Appointments;
        private System.Windows.Forms.Button bt_Customers;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel_OpenForm;
        private System.Windows.Forms.Label lb_Logo;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_Minimize;
        private System.Windows.Forms.Button bt_Info;
        private System.Windows.Forms.Button bt_Internal;
        private System.Windows.Forms.Button bt_Email;
        private System.Windows.Forms.Label lb_DateTime;
        private System.Windows.Forms.Timer tmr_Local;
        private System.Windows.Forms.Label lb_FirstView;
        private System.Windows.Forms.Button bt_Vets;
    }
}

