namespace DashPetApp.Forms
{
    partial class InfoViewForm
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
            this.lb_Logo = new System.Windows.Forms.Label();
            this.lb_Version = new System.Windows.Forms.Label();
            this.lb_Credits = new System.Windows.Forms.Label();
            this.pb_GitLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Name = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.tb_Changes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GitLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Logo
            // 
            this.lb_Logo.BackColor = System.Drawing.Color.White;
            this.lb_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Logo.Font = new System.Drawing.Font("Baloo 2 SemiBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lb_Logo.Location = new System.Drawing.Point(0, 0);
            this.lb_Logo.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Logo.Name = "lb_Logo";
            this.lb_Logo.Size = new System.Drawing.Size(1173, 132);
            this.lb_Logo.TabIndex = 1;
            this.lb_Logo.Text = "DashPet🐾";
            this.lb_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Version
            // 
            this.lb_Version.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lb_Version.Location = new System.Drawing.Point(0, 126);
            this.lb_Version.Name = "lb_Version";
            this.lb_Version.Size = new System.Drawing.Size(1173, 38);
            this.lb_Version.TabIndex = 3;
            this.lb_Version.Text = "v1.2(14.07.22)";
            this.lb_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Credits
            // 
            this.lb_Credits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_Credits.Location = new System.Drawing.Point(0, 659);
            this.lb_Credits.Name = "lb_Credits";
            this.lb_Credits.Size = new System.Drawing.Size(1173, 88);
            this.lb_Credits.TabIndex = 5;
            this.lb_Credits.Text = "Icons @ Flaticon.com";
            this.lb_Credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_GitLogo
            // 
            this.pb_GitLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_GitLogo.Image = global::DashPetApp.Properties.Resources.GitHub_Mark_64px;
            this.pb_GitLogo.Location = new System.Drawing.Point(0, 595);
            this.pb_GitLogo.Name = "pb_GitLogo";
            this.pb_GitLogo.Size = new System.Drawing.Size(1173, 64);
            this.pb_GitLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_GitLogo.TabIndex = 8;
            this.pb_GitLogo.TabStop = false;
            this.pb_GitLogo.Click += new System.EventHandler(this.pb_GitLogo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tb_Changes);
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Controls.Add(this.pb_GitLogo);
            this.panel1.Controls.Add(this.lb_Credits);
            this.panel1.Controls.Add(this.panelUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 747);
            this.panel1.TabIndex = 9;
            // 
            // lb_Name
            // 
            this.lb_Name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_Name.Location = new System.Drawing.Point(0, 170);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(1173, 425);
            this.lb_Name.TabIndex = 9;
            this.lb_Name.Text = "Designed & Developed by Dinis Pinto da Costa";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.lb_Logo);
            this.panelUp.Controls.Add(this.lb_Version);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1173, 164);
            this.panelUp.TabIndex = 10;
            // 
            // tb_Changes
            // 
            this.tb_Changes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Changes.Location = new System.Drawing.Point(438, 170);
            this.tb_Changes.Multiline = true;
            this.tb_Changes.Name = "tb_Changes";
            this.tb_Changes.ReadOnly = true;
            this.tb_Changes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Changes.Size = new System.Drawing.Size(294, 14);
            this.tb_Changes.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::DashPetApp.Properties.Resources.loading;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::DashPetApp.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(536, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // InfoViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 747);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Red Hat Display", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoViewForm";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pb_GitLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Logo;
        private System.Windows.Forms.Label lb_Version;
        private System.Windows.Forms.Label lb_Credits;
        private System.Windows.Forms.PictureBox pb_GitLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.TextBox tb_Changes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}