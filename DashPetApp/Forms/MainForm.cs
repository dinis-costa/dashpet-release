using DashPetApp.Models;
using DashPetApp.Services;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DashPetApp
{
    public partial class MainForm : Form
    {
        #region Fields
        private Button currentButton;
        private Form activeForm;
        private DataClassesDataContext dc;
        private MailDefinition email;
        #endregion
        public MainForm()
        {
            InitializeComponent();
            dc = new DataClassesDataContext();
            email = new MailDefinition();

            using (SqlConnection connection = new SqlConnection(@"CONNECTION_STRING"))
                try
                {
                    connection.Open();
                    connection.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show($"Program not connected to a database.\n\nPlease contact your administrator.", $"Fatal Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(0);
                }

            tmr_Local.Start();

        }

        /// <summary>
        /// Receives button and child form to be created.
        /// Sets Form controls and style on the panel_OpenForm.
        /// </summary>
        /// <param name="childForm">Child Form to be opened.</param>
        /// <param name="btnSender">To indentify the active button sender.</param>
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            lb_Title.Text = childForm.Text.ToUpper();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panel_OpenForm.Controls.Add(childForm);
            this.panel_OpenForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// Depending on the Button.Name it opens the correspondent Form.
        /// </summary>
        private void MainMenuButtonClick(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "bt_Customers": OpenChildForm(new Forms.CustomersViewForm(), sender); break;
                case "bt_Appointments": OpenChildForm(new Forms.AppointmentsViewForm(), sender); break;
                case "bt_Internal": OpenChildForm(new Forms.InternalViewForm(), sender); break;
                case "bt_Vets": OpenChildForm(new Forms.VetsViewForm(), sender); break;
                case "bt_Email": OpenChildForm(new Forms.EmailViewForm(), sender); break;
                case "bt_Info": OpenChildForm(new Forms.InfoViewForm(), sender); break;

                case "bt_Minimize": this.WindowState = FormWindowState.Minimized; break;
                case "bt_Exit": Application.Exit(); break;
            }
        }

        /// <summary>
        /// Receives button and enables it accordingly.
        /// </summary>
        /// <param name="btnSender">Button that called the method.</param>
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(); // Disables buttons that are not the sender.
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// Changes buttons that were not the selected one.
        /// </summary>
        private void DisableButton()
        {
            foreach (Control previousButton in panel_Menu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = panel_Top.BackColor;
                    previousButton.ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Controls local timer on main form.
        /// Checks clock for match on the reminder email sent time settings save as file.
        /// Send email when time is matched.
        /// </summary>
        private async void tmr_Local_Tick(object sender, EventArgs e)
        {
            lb_DateTime.Text = DateTime.Now.ToString(CultureInfo.GetCultureInfo("pt-PT"));
            if (DateTime.Now.ToString("HH:mm:ss") == File.ReadAllText(@".\reminder_time.txt") + ":00")
            {
                Thread.Sleep(1000); // So the application doesn't send the same email like 10 times...
                foreach (Appointment appt in dc.GetActiveAppts())
                {
                    if (appt.appt_date == DateTime.Today.AddDays(1))
                    {
                        await email.SendAppointmentEmail(appt, "Reminder");
                    }
                }
            }
        }
    }
}
