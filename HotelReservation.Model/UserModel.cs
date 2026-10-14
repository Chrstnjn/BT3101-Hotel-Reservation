namespace HotelReservation.Model
{
    public class UserModel
    {
        public long UserID { get; set; }
        public string Username { get; set; }

        public string FullName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreationDate { get; set; }
        public UserModel()
        {
            CreationDate = DateTime.Now;
        }
    }
}
