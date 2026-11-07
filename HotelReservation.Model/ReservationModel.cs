namespace HotelReservation.Model
{
    public class ReservationModel
    {
        public int GuestID { get; set; }
        public int RoomID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfGuests { get; set; }
        public int TotalNights { get; set; }
        public decimal RatePerNight { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
