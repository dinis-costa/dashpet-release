using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DashPetApp.Forms
{
    public partial class InfoViewForm : Form
    {
        public InfoViewForm()
        {
            InitializeComponent();
            lb_Name.Text = "Created && Designed\nby\n\nDinis Pinto da Costa";
            tb_Changes.Text = File.ReadAllText(@".\version-history.txt"); // Gets version history text.
        }

        private void pb_GitLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dinis-costa"); // Opens default browser.
        }
    }
}
