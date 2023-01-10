using System;
using System.Threading.Tasks;

namespace DashPetApp.Models
{
    public partial class DataClassesDataContext
    {
        /// <summary>
        /// Creates an Owner with the arguments passed.
        /// Inserts & submits the object information on the database.
        /// </summary>
        public void CreateOwner(string name, string address, string doc, string email, string phone)
        {
            Owner owner = new Owner
            {
                owner_name = name,
                owner_address = address,
                owner_doc = doc,
                owner_email = email,
                owner_phone = phone,
                owner_status = true,
            };

            Owners.InsertOnSubmit(owner);

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives an Owner with the properties as arguments passed.
        /// Submits the edited object information on the database.
        /// </summary>
        public void EditOwner(Owner owner, string name, string address, string doc, string email, string phone)
        {
            owner.owner_name = name;
            owner.owner_address = address;
            owner.owner_doc = doc;
            owner.owner_email = email;
            owner.owner_phone = phone;

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives an Owner and switches it's status.
        /// </summary>
        public async Task OwnerStatusSwitch(Owner owner)
        {
            if (owner.owner_status)
            {
                owner.owner_status = false;

                foreach (Appointment appt in GetActiveOwnerAppts(owner))
                {
                    await DelAppt(appt); // Deletes appointments of the inactive Owner.
                }
            }
            else
            {
                owner.owner_status = true;
            }
            SubmitDatabaseChanges();
        }
    }
}
