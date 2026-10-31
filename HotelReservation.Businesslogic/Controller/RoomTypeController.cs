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

        public bool Update(RoomTypeModel roomType)
        {
            return repository.UpdateRoomType(roomType);
        }

        public bool RoomTypeNameExists(string roomTypeName, int excludeId = 0)
        {
            return repository.RoomTypeNameExists(roomTypeName, excludeId);
        }

        public DataTable GetRoomTypes()
        {
            return repository.GetRoomTypes();
        }

        public bool DeleteRoomType(int roomTypeId)
        {
            return repository.DeleteRoomType(roomTypeId);
        }
    }
}
