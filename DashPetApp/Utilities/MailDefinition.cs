using DashPetApp.Models;
using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashPetApp.Services
{
    public class MailDefinition
    {
        private SmtpService _smtpService = new SmtpService(); // Instance of class where the smtpClient resides.

        /// <summary>
        /// Based on <paramref name="emailTemplate"/> selects a template from the files folder and generates a title.
        /// Replaces message parameters with <paramref name="a"/> properties.
        /// If it's a receipt email, it attaches the generated receipt.
        /// </summary>
        /// <param name="a">Appointment Object</param>
        /// <param name="emailTemplate"></param>
        /// <returns></returns>
        public async Task SendAppointmentEmail(Appointment a, string emailTemplate)
        {
            try
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(ConfigurationManager.AppSettings["email"]),
                    Subject = $"DashPet -- {emailTemplate} Appointment -- {a.appt_date} - {a.TimeSlot.timeslot_time} -- Ref. [{a.appt_id}]",
                    Body = File.ReadAllText($@".\EmailTemplates\Appointments\{emailTemplate}.html"),
                    //IsBodyHtml = true,
                };
                mailMessage.To.Add(a.Pet.Owner.owner_email);

                mailMessage.Body = mailMessage.Body.Replace("<%Name%>", $"{a.Pet.Owner.owner_name}");
                mailMessage.Body = mailMessage.Body.Replace("<%Date%>", $"{a.appt_date.ToString("D")}");
                mailMessage.Body = mailMessage.Body.Replace("<%Time%>", $"{a.TimeSlot.timeslot_time}");
                mailMessage.Body = mailMessage.Body.Replace("<%Service%>", $"{a.Service}");
                mailMessage.Body = mailMessage.Body.Replace("<%Vet%>", $"{a.Vet.vet_name}");

                if (emailTemplate == "Completed")
                    mailMessage.Attachments.Add(GenerateAttachment(a));

                await _smtpService.SmtpConnection(mailMessage);
            }
            catch (System.Exception e)
            {

                MessageBox.Show(e.ToString());
            };
        }

        /// <summary>
        /// Receives a string, <paramref name="mailingList"/>, containing all the valid addresses to be dealt as recipients.
        /// Based on <paramref name="emailTemplate"/> selects a template from the files folder and generates a title.
        /// Attemps to establish a connection to send the message to the mailing list.
        /// </summary>
        /// <param name="mailingList"></param>
        /// <param name="emailTemplate"></param>
        public async Task SendGeneralEmail(string mailingList, string emailTemplate)
        {
            try
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(ConfigurationManager.AppSettings["email"]),
                    Subject = $"DashPet -- General Announcement: {emailTemplate}",
                    Body = File.ReadAllText($@".\EmailTemplates\General\{emailTemplate}.html"),
                    //IsBodyHtml = true,
                };
                mailMessage.To.Add(mailingList);
                await _smtpService.SmtpConnection(mailMessage);
            }
            catch (System.Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// Receives an Appointment, <paramref name="a"/>, reads from the HTML Invoice Template.
        /// Replaces the markers on the file by the correct appointment properties.
        /// Creates/saves the file on the Invoices.
        /// </summary>
        /// <param name="a">Appointment Object</param>
        /// <returns>Returns the Attachment get from the newly created file.</returns>
        private Attachment GenerateAttachment(Appointment a)
        {
            var readTemplate = File.ReadAllText(@".\EmailTemplates\Appointments\Invoice.html");

            readTemplate = readTemplate.Replace("<%ApptId%>", $"{a.appt_id}");
            readTemplate = readTemplate.Replace("<%DateTime%>", $"{DateTime.Now}");
            readTemplate = readTemplate.Replace("<%Name%>", $"{a.Pet.Owner.owner_name}");
            readTemplate = readTemplate.Replace("<%Phone%>", $"{a.Pet.Owner.owner_phone}");
            readTemplate = readTemplate.Replace("<%Email%>", $"{a.Pet.Owner.owner_email}");
            readTemplate = readTemplate.Replace("<%ServiceName%>", $"{a.Service.service_name}");
            readTemplate = readTemplate.Replace("<%ServicePrice%>", $"{a.Service.service_price}{NumberFormatInfo.CurrentInfo.CurrencySymbol}");

            File.WriteAllText($@".\Invoices\{a.appt_id}.html", readTemplate);

            return new Attachment($@".\Invoices\{a.appt_id}.html", MediaTypeNames.Text.Html);
        }
    }
}
