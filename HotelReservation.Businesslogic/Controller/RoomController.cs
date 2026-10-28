using HotelReservation.Businesslogic.Repository;
using HotelReservation.Model;
using System.Data;

namespace HotelReservation.Businesslogic.Controller
{
    public class RoomController
    {
        private readonly RoomRepository repository =
            new RoomRepository();

        public bool SaveRoom(RoomModel room)
        {
            return repository.AddRoom(room);
        }

        public DataTable GetRooms()
        {
            return repository.GetRooms();
        }
        public bool RoomNumberExists(string roomNumber)
        {
            return repository.RoomNumberExists(roomNumber);
        }
    }
}
