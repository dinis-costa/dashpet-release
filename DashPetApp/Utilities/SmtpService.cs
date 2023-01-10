using System;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashPetApp.Services
{
    public class SmtpService
    {
        /// <summary>
        /// Instantiation of an SMTP client to smtpClient from the App.config <mailSettings> attributes as a SmtpClient.
        /// Receives the MailMessage <paramref name="mail"/> and attempts to send the message asynchronously.
        /// </summary>
        /// <param name="mail">The MailMessage to be sent using the SMTP client.</param>
        public async Task SmtpConnection(MailMessage mail)
        {
            SmtpClient smtpClient = new SmtpClient();

            try
            {
                await smtpClient.SendMailAsync(mail);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to send email.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}