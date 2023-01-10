using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashPetApp.Models
{
    public partial class DataClassesDataContext
    {
        /// <summary>
        /// Creates a Vet with the arguments passed.
        /// Inserts & submits the object information on the database.
        /// </summary>
        public void CreateVet(string name, string doc, string email, string phone, Room room)
        {
            Vet vet = new Vet
            {
                vet_name = name,
                vet_doc = doc,
                vet_email = email,
                vet_phone = phone,
                Room = room,
                vet_status = true,
            };

            Vets.InsertOnSubmit(vet);

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives an Vet with the properties as arguments passed.
        /// Submits the edited object information on the database.
        /// </summary>
        public void EditVet(Vet vet, string name, string doc, string email, string phone, Room room)
        {
            vet.vet_name = name;
            vet.vet_doc = doc;
            vet.vet_email = email;
            vet.vet_phone = phone;
            vet.Room = room;

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives a Vet and switches it's status.
        /// </summary>
        public async Task VetStatusSwitch(Vet vet)
        {
            if (vet.vet_status)
            {
                vet.vet_status = false;
                vet.Room = null;

                foreach (Appointment appt in GetActiveVetAppts(vet))
                {
                    await DelAppt(appt); // Deletes Appointments with the disabled object Vet.
                }
            }
            else
            {
                vet.vet_status = true;
            }

            SubmitDatabaseChanges();
        }
    }
}
