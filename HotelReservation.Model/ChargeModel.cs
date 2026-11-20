namespace HotelReservation.Model
{
    public class ChargeModel
    {
        public int ChargeID { get; set; }
        public int ReservationID { get; set; }
        public string ChargeType { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime ChargedDate { get; set; }
    }
}