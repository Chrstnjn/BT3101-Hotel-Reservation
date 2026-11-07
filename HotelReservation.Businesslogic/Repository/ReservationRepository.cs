using HotelReservation.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelReservation.Businesslogic.Repository
{
    public class ReservationRepository
    {
        private readonly string connectionString =
           ConfigurationManager.ConnectionStrings["HighlandsDB"].ConnectionString;

        public void AddReservation(ReservationModel reservation)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_AddReservation", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@GuestID", reservation.GuestID);
                cmd.Parameters.AddWithValue("@RoomID", reservation.RoomID);
                cmd.Parameters.AddWithValue("@CheckInDate", reservation.CheckInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", reservation.CheckOutDate);
                cmd.Parameters.AddWithValue("@NumberOfGuests", reservation.NumberOfGuests);
                cmd.Parameters.AddWithValue("@TotalNights", reservation.TotalNights);
                cmd.Parameters.AddWithValue("@RatePerNight", reservation.RatePerNight);
                cmd.Parameters.AddWithValue("@TotalPrice", reservation.TotalPrice);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetReservations()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("usp_GetReservations", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dt);
            }

            return dt;
        }
    }
}
