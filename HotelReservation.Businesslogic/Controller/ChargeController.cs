using HotelReservation.Businesslogic.Repository;
using HotelReservation.Model;

namespace HotelReservation.Businesslogic.Controller
{
    public class ChargeController
    {
        private readonly ChargeRepository _repo = new ChargeRepository();

        // The overdue charge is added by the database (usp_ApplyLateCharges).
        // This controller only adds manual charges and reads them.

        public void AddCharge(int reservationId, string chargeType, string description, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("The charge amount must be greater than zero.");

            _repo.Add(new ChargeModel
            {
                ReservationID = reservationId,
                ChargeType = chargeType,
                Description = description,
                Amount = amount
            });
        }

        public List<ChargeModel> GetCharges(int reservationId)
        {
            return _repo.GetByReservation(reservationId);
        }

        public decimal GetTotalCharges(int reservationId)
        {
            return _repo.GetTotal(reservationId);
        }
    }
}