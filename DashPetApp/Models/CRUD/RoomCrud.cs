using System.Linq;

namespace DashPetApp.Models
{
    public partial class DataClassesDataContext
    {
        /// <summary>
        /// Creates a Room with the arguments passed.
        /// Inserts & submits the object information on the database.
        /// </summary>
        public void CreateRoom(string name)
        {
            Room room = new Room
            {
                room_name = name,
                room_status = true,
            };

            Rooms.InsertOnSubmit(room);

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives an Room with the properties as arguments passed.
        /// Submits the edited object information on the database.
        /// </summary>
        public void EditRoom(Room room, string name)
        {
            room.room_name = name;

            SubmitDatabaseChanges();
        }

        /// <summary>
        /// Receives a Room and switches it's status.
        /// </summary>
        public void RoomStatusSwitch(Room room)
        {
            if (room.room_status)
            {
                room.room_status = false;

                foreach (Vet vet in Vets.Where(v => v.Room == room))
                {
                    vet.Room = null; // Removes the room of Vets that were in the disabled room.
                }
            }
            else
            {
                room.room_status = true;
            }

            SubmitDatabaseChanges();
        }
    }
}
