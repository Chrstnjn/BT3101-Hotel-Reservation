using HotelReservation.Businesslogic.Repository;
using HotelReservation.Model;
using System.Data;

namespace HotelReservation.Businesslogic.Controller
{
    public class RoomTypeController
    {
        private readonly RoomTypeRepository repository =
            new RoomTypeRepository();

        public bool Save(RoomTypeModel roomType)
        {
            return repository.AddRoomType(roomType);
        }

        public DataTable GetRoomTypes()
        {
            return repository.GetRoomTypes();
        }

        public void DeleteRoomType(int roomTypeId)
        {
            repository.DeleteRoomType(roomTypeId);
        }
    }
}
