using HotelReservation.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelReservation.Businesslogic.Repository
{
    public class RoomRepository
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["HighlandsDB"].ConnectionString;

        public bool AddRoom(RoomModel room)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Rooms
                                (
                                    RoomNumber,
                                    RoomTypeID,
                                    Status
                                )
                                VALUES
                                (
                                    @RoomNumber,
                                    @RoomTypeID,
                                    @Status
                                )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                cmd.Parameters.AddWithValue("@RoomTypeID", room.RoomTypeID);
                cmd.Parameters.AddWithValue("@Status", room.Status);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetRooms()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT
                    r.RoomID,
                    r.RoomNumber,
                    rt.RoomTypeName,
                    rt.NumberOfBeds,
                    rt.NumberOfPersons,
                    rt.PricePerNight,
                    r.Status
                FROM Rooms r
                INNER JOIN RoomTypes rt
                    ON r.RoomTypeID = rt.RoomTypeID
                ORDER BY CAST(r.RoomNumber AS INT)";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.Fill(dt);
            }

            return dt;
        }

        public bool RoomNumberExists(string roomNumber)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Rooms WHERE RoomNumber = @RoomNumber";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                con.Open();

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public bool UpdateRoom(RoomModel room)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Rooms
                         SET RoomNumber = @RoomNumber,
                             RoomTypeID = @RoomTypeID,
                             Status = @Status
                         WHERE RoomID = @RoomID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
                cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                cmd.Parameters.AddWithValue("@RoomTypeID", room.RoomTypeID);
                cmd.Parameters.AddWithValue("@Status", room.Status);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteRoom(int roomID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomID", roomID);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetTotalRooms()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Rooms";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.Fill(dt);
            }

            return dt;
        }

    }
}
