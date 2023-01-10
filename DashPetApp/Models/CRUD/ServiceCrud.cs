using System;
using System.Threading.Tasks;

namespace DashPetApp.Models
{
    public partial class DataClassesDataContext
    {
        /// <summary>
        /// Creates a Service with the arguments passed.
        /// Inserts & submits the object information on the database.
        /// </summary>
        public void CreateService(string name, string price)
        {
            Service service = new Service
            {
                service_name = name,
                service_price = price,
                service_status = true,
            };

            Services.InsertOnSubmit(service);

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives an Service with the properties as arguments passed.
        /// Submits the edited object information on the database.
        /// </summary>
        public void EditService(Service service, string name, string price)
        {
            service.service_name = name;
            service.service_price = price;

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives a Service and switches it's status.
        /// </summary>
        public async Task ServiceStatusSwitch(Service service)
        {
            if (service.service_status)
            {
                service.service_status = false;

                foreach (Appointment appt in GetActiveServiceAppts(service))
                {
                    await DelAppt(appt); // Deletes active appointments with the service.
                }
            }
            else
            {
                service.service_status = true;
            }

            SubmitDatabaseChanges();
        }


    }
}