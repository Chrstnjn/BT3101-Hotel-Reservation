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
        public void ConfirmDownpayment(int reservationId, decimal amount, string paymentMethod)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_ConfirmDownpayment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateReservation(int reservationId, ReservationModel reservation)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_UpdateReservation", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
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

        public void CancelReservation(int reservationId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_CancelReservation", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void CheckInReservation(int reservationId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_CheckInReservation", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetCheckOuts()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("usp_GetCheckOuts", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dt);
            }

            return dt;
        }

        public void CheckOutReservation(int reservationId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_CheckOutReservation", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void ProcessBilling(int reservationId, decimal amountReceived, string paymentMethod)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_ProcessBilling", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                cmd.Parameters.AddWithValue("@AmountReceived", amountReceived);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
