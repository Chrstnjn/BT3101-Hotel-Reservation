using HotelReservation.Model;
using HotelReservation.Businesslogic.Repository;

namespace HotelReservation.Businesslogic.Controller
{
    public class UserController
    {
        private UserRepository repository = new UserRepository();

        public UserModel Login(string username, string password)
        {
            return repository.Login(username, password);
        }
    }
}