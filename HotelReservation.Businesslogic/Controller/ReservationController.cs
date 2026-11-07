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
    }
}
