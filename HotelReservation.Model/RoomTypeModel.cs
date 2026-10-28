namespace HotelReservation.Model
{
    public class RoomTypeModel
    {
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public int NumberOfBeds { get; set; }
        public int NumberOfPersons { get; set; }
        public decimal PricePerNight { get; set; }
    }
}
