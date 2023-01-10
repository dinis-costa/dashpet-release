using System;
using System.Threading.Tasks;

namespace DashPetApp.Models
{
    public partial class DataClassesDataContext
    {
        /// <summary>
        /// Creates an Appointment with the arguments passed.
        /// Inserts & submits the object information on the database.
        /// Sends creation ("New") email.
        /// </summary>
        public async Task CreateAppt(Pet pet, Vet vet, DateTime date, TimeSlot time, Service service, string notes)
        {
            Appointment appt = new Appointment
            {
                appt_service_id = service.service_id,
                appt_pet_id = pet.pet_id,
                appt_vet_id = vet.vet_id,
                appt_date = date,
                appt_timeslot_id = time.timeslot_id,
                appt_notes = notes,
                appt_status = false,
            };

            Appointments.InsertOnSubmit(appt);

            SubmitDatabaseChanges();

            await _email.SendAppointmentEmail(appt, "New");
        }

        /// <summary>
        /// Receives an Appointment with the properties as arguments passed.
        /// Submits the edited object information on the database.
        /// Sends edit ("Changed") email.
        /// </summary>
        public async Task EditAppt(Appointment appt, Vet vet, DateTime date, TimeSlot time, Service service, string notes)
        {
            //Adicionar restrições de envio de mudança nas notas.
            appt.appt_date = date;
            appt.appt_notes = notes;
            appt.Vet = vet;
            appt.TimeSlot = time;
            appt.Service = service;

            SubmitDatabaseChanges();
            
            await _email.SendAppointmentEmail(appt, "Changed");
        }

        /// <summary>
        /// Sends deletion ("Cancelled") email.
        /// Receives an Appointment and deletes it from the database.
        /// </summary>
        public async Task DelAppt(Appointment appt)
        {

            await _email.SendAppointmentEmail(appt, "Cancelled");

            Appointments.DeleteOnSubmit(appt);

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives an Appointment and changes it's status.
        /// Sends receipt ("Completed") email.
        /// </summary>
        public async Task ConfirmAppt(Appointment appt)
        {
            appt.appt_status = true;

            SubmitDatabaseChanges();

            await _email.SendAppointmentEmail(appt, "Completed");
        }
    }
}
