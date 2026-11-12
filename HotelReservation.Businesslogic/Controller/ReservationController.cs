using HotelReservation.Businesslogic.Repository;
using HotelReservation.Model;
using System.Data;

namespace HotelReservation.Businesslogic.Controller
{
    public class ReservationController
    {
        private readonly ReservationRepository repo = new ReservationRepository();

        public void AddReservation(ReservationModel reservation)
        {
            repo.AddReservation(reservation);
        }

        public DataTable GetReservations()
        {
            return repo.GetReservations();
        }
        public void ConfirmDownpayment(int reservationId, decimal amount, string paymentMethod)
        {
            repo.ConfirmDownpayment(reservationId, amount, paymentMethod);
        }
        public void UpdateReservation(int reservationId, ReservationModel reservation)
        {
            repo.UpdateReservation(reservationId, reservation);
        }
        public void CancelReservation(int reservationId)
        {
            repo.CancelReservation(reservationId);
        }
        public void CheckInReservation(int reservationId)
        {
            repo.CheckInReservation(reservationId);
        }
        public DataTable GetCheckOuts()
        {
            return repo.GetCheckOuts();
        }

        public void CheckOutReservation(int reservationId)
        {
            repo.CheckOutReservation(reservationId);
        }
        public void ProcessBilling(int reservationId, decimal amountReceived, string paymentMethod)
        {
            repo.ProcessBilling(reservationId, amountReceived, paymentMethod);
        }
        public DataTable GetBillingRecords()
        {
            return repo.GetBillingRecords();
        }
        public DataTable GetAvailableRooms(DateTime date)
        {
            return repo.GetAvailableRooms(date);
        }

        public DataTable GetRecentActivity()
        {
            return repo.GetRecentActivity();
        }
    }
}
