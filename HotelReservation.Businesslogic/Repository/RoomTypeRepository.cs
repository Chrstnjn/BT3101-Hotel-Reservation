using HotelReservation.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelReservation.Businesslogic.Repository
{
    public class RoomTypeRepository
    {
        private readonly string connectionString =
               ConfigurationManager.ConnectionStrings["HighlandsDB"].ConnectionString;

        public bool AddRoomType(RoomTypeModel roomType)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO RoomTypes
                                (
                                    RoomTypeName,
                                    NumberOfBeds,
                                    NumberOfPersons,
                                    PricePerNight
                                )
                                VALUES
                                (
                                    @RoomTypeName,
                                    @NumberOfBeds,
                                    @NumberOfPersons,
                                    @PricePerNight
                                )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@RoomTypeName", roomType.RoomTypeName);
                cmd.Parameters.AddWithValue("@NumberOfBeds", roomType.NumberOfBeds);
                cmd.Parameters.AddWithValue("@NumberOfPersons", roomType.NumberOfPersons);
                cmd.Parameters.AddWithValue("@PricePerNight", roomType.PricePerNight);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetRoomTypes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM RoomTypes";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.Fill(dt);
            }

            return dt;
        }

        public bool UpdateRoomType(RoomTypeModel roomType)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE RoomTypes
                         SET RoomTypeName = @RoomTypeName,
                             NumberOfBeds = @NumberOfBeds,
                             NumberOfPersons = @NumberOfPersons,
                             PricePerNight = @PricePerNight
                         WHERE RoomTypeID = @RoomTypeID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@RoomTypeID", roomType.RoomTypeID);
                cmd.Parameters.AddWithValue("@RoomTypeName", roomType.RoomTypeName);
                cmd.Parameters.AddWithValue("@NumberOfBeds", roomType.NumberOfBeds);
                cmd.Parameters.AddWithValue("@NumberOfPersons", roomType.NumberOfPersons);
                cmd.Parameters.AddWithValue("@PricePerNight", roomType.PricePerNight);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool RoomTypeNameExists(string roomTypeName, int excludeId = 0)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM RoomTypes
                         WHERE RoomTypeName = @RoomTypeName
                         AND RoomTypeID <> @ExcludeID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@RoomTypeName", roomTypeName);
                cmd.Parameters.AddWithValue("@ExcludeID", excludeId);

                con.Open();

                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool DeleteRoomType(int roomTypeId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query =
                        "DELETE FROM RoomTypes WHERE RoomTypeID = @RoomTypeID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@RoomTypeID", roomTypeId);

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                // 547 = foreign key error: a Room is still using this Room Type
                return false;
            }
        }
    }
}
