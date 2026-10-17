using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Model
{
    public class GuestModel
    {
        public int GuestID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string EmergencyContactName { get; set; }

        public string EmergencyContactNumber { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
