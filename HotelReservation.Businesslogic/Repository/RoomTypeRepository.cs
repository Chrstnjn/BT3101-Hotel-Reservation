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
                string query = @"
                IF EXISTS
                (
                    SELECT 1
                    FROM RoomTypes
                    WHERE RoomTypeName = @RoomTypeName
                    AND IsActive = 0
                )
                BEGIN
                    UPDATE RoomTypes
                    SET
                        IsActive = 1,
                        NumberOfBeds = @NumberOfBeds,
                        NumberOfPersons = @NumberOfPersons,
                        PricePerNight = @PricePerNight
                    WHERE RoomTypeName = @RoomTypeName
                    AND IsActive = 0
                END
                ELSE
                BEGIN
                    INSERT INTO RoomTypes
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
                    )
                END";

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
                string query = @"
                    SELECT *
                    FROM RoomTypes
                    WHERE IsActive = 1";

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
                string query = @"
                    SELECT COUNT(*)
                    FROM RoomTypes
                    WHERE RoomTypeName = @RoomTypeName
                    AND IsActive = 1
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
                    string query = @"
                    IF EXISTS
                    (
                        SELECT 1
                        FROM Rooms
                        WHERE RoomTypeID = @RoomTypeID
                        AND IsActive = 1
                    )
                    SELECT 0;
                    ELSE
                    BEGIN
                        UPDATE RoomTypes
                        SET IsActive = 0
                        WHERE RoomTypeID = @RoomTypeID;

                        SELECT 1;
                    END";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@RoomTypeID", roomTypeId);

                    con.Open();

                    return (int)cmd.ExecuteScalar() == 1;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}