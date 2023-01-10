using DashPetApp.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DashPetApp.Models
{
    /// <summary>
    /// This file extends the DataClassesDataContext to allow the call of queries to the database as methods.
    /// This allow the return of a IQueryable without calling the specific object or table.
    /// </summary>
    public partial class DataClassesDataContext
    {
        #region Owner Related Queries

        /// <summary>
        /// <returns>Returns Owners with a an active status by changes on the SQL TimeStamp.</returns>
        /// </summary>
        public IQueryable GetActiveOwners()
        {
            return Owners.AsQueryable().Where(o => o.owner_status).OrderByDescending(o => o.owner_timestamp);
        }

        /// <summary>
        /// <returns>Returns owner's emails with a an active status.</returns>
        /// </summary>
        public IQueryable GetMailingList()
        {
            return Owners.Where(o => o.owner_status).Select(x => x.owner_email);
        }
        #endregion

        #region Vet Related Queries

        /// <summary>
        /// <returns>Returns active status Vets.</returns>
        /// </summary>
        public IQueryable<Vet> GetActiveVets()
        {
            return Vets.Where(v => v.vet_status);
        }

        /// <summary>
        /// <returns>Returns the Vets that are busy, meaning that they have an appointment at the passed date & time.</returns>
        /// </summary>
        /// <param name="date">The date to be checked.</param>
        /// <param name="time">The time to be checked.</param>
        public IQueryable<Vet> GetBusyVets(DateTime date, string time)
        {
            return Appointments.Where(appt => (appt.appt_date == date) && (appt.TimeSlot.timeslot_time == time)).Select(vet => vet.Vet);
        }

        /// <summary>
        /// <returns>Returns the Vets have an active and are not busy in the date and time requested.</returns>
        /// </summary>
        /// <param name="date">To be passed to get the busy Vets</param>
        /// <param name="currentAppt">To get current TimeSlot value to display.</param>
        /// <param name="time">To be passed to get the busy Vets.</param>
        public IQueryable<Vet> GetVetSlots(DateTime date, Appointment currentAppt, string time)
        {
            // Note: Per link, it's not possible to make function referecens within Linq query. Saved on variable first works.
            //https://stackoverflow.com/questions/332670/simple-linq-to-sql-has-no-supported-translation-to-sql

            IQueryable<Vet> occupiedVets = GetBusyVets(date, time);

            IQueryable<Vet> vetSlots = GetActiveVets().Where(vet => !occupiedVets.Contains(vet));

            if (currentAppt != null) // To populate the slots with the current TimeSlot of the Appointment.
                vetSlots = GetActiveVets().Where(vet => vet == currentAppt.Vet || !occupiedVets.Contains(vet));

            return vetSlots;
        }

        #endregion

        #region Appointment Related Queries

        /// <summary>
        /// <returns>Returns active appointments.</returns>
        /// </summary>
        public IQueryable GetActiveAppts()
        {
            return Appointments.AsQueryable().Where(a => !a.appt_status);
        }

        /// <summary>
        /// <returns>Returns active appointments that have the same Owner as the one passed.</returns>
        /// </summary>
        public IQueryable GetActiveOwnerAppts(Owner owner)
        {
            return Appointments.Where(a => !a.appt_status && a.Pet.Owner.owner_id == owner.owner_id);
        }

        /// <summary>
        /// <returns>Returns active appointments that have the same Vet as the one passed.</returns>
        /// </summary>
        public IQueryable<Appointment> GetActiveVetAppts(Vet vet)
        {
            return Appointments.Where(a => !a.appt_status && a.Vet.vet_id == vet.vet_id);
        }

        /// <summary>
        /// <returns>Returns active appointments that have the same date as the one passed.</returns>
        /// </summary>
        public IQueryable GetDateAppts(DateTime date)
        {
            return Appointments.Where(a => a.appt_date == date);
        }

        /// <summary>
        /// <returns>Returns all appointments that have the same Owner as the one passed.</returns>
        /// </summary>
        public IQueryable GetAllAOwnerAppts(Owner owner)
        {
            return Appointments.Where(a => a.Pet.Owner.owner_id == owner.owner_id);
        }

        /// <summary>
        /// <returns>Returns active appointments that have the same Pet as the one passed.</returns>
        /// </summary>
        public IQueryable GetActivePetAppts(Pet pet)
        {
            return Appointments.Where(a => !a.appt_status && a.Pet.pet_id == pet.pet_id);
        }

        /// <summary>
        /// <returns>Returns active appointments that have the same Service as the one passed.</returns>
        /// </summary>
        public IQueryable GetActiveServiceAppts(Service service)
        {
            return Appointments.Where(a => !a.appt_status && a.Service.service_id == service.service_id);
        }

        /// <summary>
        /// <returns>Returns all appointments that have the same Vet as the one passed.</returns>
        /// </summary>
        public IQueryable GetAllAVetAppts(Vet vet)
        {
            return Appointments.Where(a => a.Vet.vet_id == vet.vet_id);
        }

        #endregion

        #region Other Queries

        /// <summary>
        /// <returns>Returns avaliable timeslots by using the passed and and active count of Vets.</returns>
        /// </summary>
        public IQueryable<TimeSlot> GetTimeSlots(DateTime date, Appointment currentAppt)
        {
            IQueryable<Vet> activeVets = Vets.Where(v => v.vet_status);

            IQueryable<TimeSlot> timeSlots = TimeSlots.Where(slot => slot.Appointments.Where(appt => appt.appt_date == date).Count() < activeVets.Count());

            if (currentAppt != null)
                timeSlots = TimeSlots.Where(slot => slot == currentAppt.TimeSlot || slot.Appointments.Where(appt => appt.appt_date == date).Count() < activeVets.Count());

            return timeSlots;
        }

        /// <summary>
        /// <returns>Returns active rooms.</returns>
        /// </summary>
        public IQueryable GetActiveRooms()
        {
            return Rooms.Where(r => r.room_status);
        }

        /// <summary>
        /// <returns>Returns pets that are active and that share the owner passed.</returns>
        /// </summary>
        public IQueryable GetOwnerPets(Owner owner)
        {
            return Pets.Where(p => p.pet_status && p.pet_owner_id == owner.owner_id).OrderByDescending(p => p.pet_timestamp);
        }

        /// <summary>
        /// <returns>Returns animal species that share the class passed.</returns>
        /// </summary>
        public IQueryable GetAnimalSpecies(AnimalClass ac)
        {
            return AnimalSpecies.Where(s => s.animalspecies_animalclass_id == ac.animalclass_id);
        }

        /// <summary>
        /// <returns>Returns active services.</returns>
        /// </summary>
        public IQueryable GetActiveServices()
        {
            return Services.Where(s => s.service_status);
        }

        #endregion
    }
}
