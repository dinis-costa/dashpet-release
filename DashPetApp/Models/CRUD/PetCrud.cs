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
        /// Creates an Pet with the arguments passed.
        /// Inserts & submits the object information on the database.
        /// </summary>
        public void CreatePet(Owner owner, string name, AnimalSpecies animalSpecies, DateTime dob, string weight, string sex, string notes)
        {
            Pet pet = new Pet
            {
                pet_owner_id = owner.owner_id,
                pet_name = name,
                pet_animalspecies_id = animalSpecies.animalspecies_id,
                pet_dob = dob,
                pet_weight = weight,
                pet_sex = sex,
                pet_notes = notes,
                pet_status = true,
            };

            Pets.InsertOnSubmit(pet);

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives an Pet with the properties as arguments passed.
        /// Submits the edited object information on the database.
        /// </summary>
        public void EditPet(Pet pet, string name, AnimalSpecies animalSpecies, DateTime dob, string weight, string sex, string notes)
        {
            pet.pet_name = name;
            pet.pet_notes = notes;
            pet.pet_weight = weight;
            pet.pet_dob = dob;
            pet.pet_sex = sex;
            pet.AnimalSpecies = animalSpecies;

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives an Pet and switches it's status.
        /// </summary>
        public async Task PetStatusSwitch(Pet pet)
        {
            if (pet.pet_status)
            {
                pet.pet_status = false;

                foreach (Appointment appt in GetActivePetAppts(pet))
                {
                    await DelAppt(appt); // Deletes appointments of the inactive Pet.
                }
            }
            else
            {
                pet.pet_status = true;
            }

            SubmitDatabaseChanges();
        }
    }
}
