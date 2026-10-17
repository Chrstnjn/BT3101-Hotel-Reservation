using HotelReservation.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelReservation.Businesslogic.Repository
{
    public class GuestRepository
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

        public void AddGuest(GuestModel guest)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Guests
                                (
                                    FirstName,
                                    LastName,
                                    DateOfBirth,
                                    Gender,
                                    PhoneNumber,
                                    StreetAddress,
                                    City,
                                    Province,
                                    EmergencyContactName,
                                    EmergencyContactNumber
                                )
                                VALUES
                                (
                                    @FirstName,
                                    @LastName,
                                    @DateOfBirth,
                                    @Gender,
                                    @PhoneNumber,
                                    @StreetAddress,
                                    @City,
                                    @Province,
                                    @EmergencyContactName,
                                    @EmergencyContactNumber
                                )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FirstName", guest.FirstName);
                cmd.Parameters.AddWithValue("@LastName", guest.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", guest.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", guest.Gender);
                cmd.Parameters.AddWithValue("@PhoneNumber", guest.PhoneNumber);
                cmd.Parameters.AddWithValue("@StreetAddress", guest.StreetAddress);
                cmd.Parameters.AddWithValue("@City", guest.City);
                cmd.Parameters.AddWithValue("@Province", guest.Province);
                cmd.Parameters.AddWithValue("@EmergencyContactName", guest.EmergencyContactName);
                cmd.Parameters.AddWithValue("@EmergencyContactNumber", guest.EmergencyContactNumber);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetGuests()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Guests";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.Fill(dt);
            }

            return dt;
        }

        public bool UpdateGuest(GuestModel guest)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_UpdateGuest", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@GuestID", guest.GuestID);
                cmd.Parameters.AddWithValue("@FirstName", guest.FirstName);
                cmd.Parameters.AddWithValue("@LastName", guest.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", guest.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", guest.Gender);
                cmd.Parameters.AddWithValue("@PhoneNumber", guest.PhoneNumber);
                cmd.Parameters.AddWithValue("@StreetAddress", guest.StreetAddress);
                cmd.Parameters.AddWithValue("@City", guest.City);
                cmd.Parameters.AddWithValue("@Province", guest.Province);
                cmd.Parameters.AddWithValue("@EmergencyContactName", guest.EmergencyContactName);
                cmd.Parameters.AddWithValue("@EmergencyContactNumber", guest.EmergencyContactNumber);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

            public void DeleteGuest(int guestId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Guests WHERE GuestID = @GuestID", conn);

                cmd.Parameters.AddWithValue("@GuestID", guestId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
