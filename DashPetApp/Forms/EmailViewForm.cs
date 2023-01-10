using System.Windows.Forms;

namespace DashPetApp.Forms
{
    public partial class EmailViewForm : Form
    {
        public EmailViewForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(908, 605);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("https://outlook.office.com/mail/", System.UriKind.Absolute);
            // 
            // EmailViewForm
            // 
            this.ClientSize = new System.Drawing.Size(908, 605);
            this.Controls.Add(this.webBrowser);
            this.DoubleBuffered = true;
            this.Name = "EmailViewForm";
            this.Text = "Email";
            this.ResumeLayout(false);

        }
    }
}
