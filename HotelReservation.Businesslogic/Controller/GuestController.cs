using HotelReservation.Businesslogic.Repository;
using HotelReservation.Model;
using System.Data;

namespace HotelReservation.Businesslogic.Controller
{
    public class GuestController
    {
        private GuestRepository repository;

        public GuestController()
        {
            repository = new GuestRepository();
        }

        public void AddGuest(GuestModel guest)
        {
            repository.AddGuest(guest);
        }

        public DataTable GetGuests()
        {
            return repository.GetGuests();
        }

        public bool UpdateGuest(GuestModel guest)
        {
            GuestRepository repository = new GuestRepository();
            return repository.UpdateGuest(guest);
        }

        public void DeleteGuest(int guestId)
        {
            GuestRepository repository = new GuestRepository();
            repository.DeleteGuest(guestId);
        }
    }
}
