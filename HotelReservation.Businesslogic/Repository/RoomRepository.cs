using HotelReservation.Model;
using System;
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
        string query = @"
        IF EXISTS
        (
            SELECT 1
            FROM Rooms
            WHERE RoomNumber = @RoomNumber
            AND IsActive = 0
        )
        BEGIN
            UPDATE Rooms
            SET
                IsActive = 1,
                RoomTypeID = @RoomTypeID,
                Status = @Status
            WHERE RoomNumber = @RoomNumber
        END
        ELSE
        BEGIN
            INSERT INTO Rooms
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
            )
        END";

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
                WHERE
                    r.IsActive = 1
                    AND rt.IsActive = 1
                ORDER BY CAST(r.RoomNumber AS INT)";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.Fill(dt);
            }

            return dt;
        }

        // Rooms with their status on the chosen date
        public DataTable GetRoomsByDate(DateTime date)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("usp_GetRoomsByDate", con);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue(
                    "@Date",
                    date.Date);

                da.Fill(dt);
            }

            return dt;
        }

        public bool RoomNumberExists(string roomNumber)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT COUNT(*)
                FROM Rooms
                WHERE RoomNumber = @RoomNumber
                AND IsActive = 1";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@RoomNumber",
                    roomNumber);

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
                SET
                    RoomNumber = @RoomNumber,
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
                string query = @"
                IF EXISTS
                (
                    SELECT 1
                    FROM Reservations
                    WHERE RoomID = @RoomID
                    AND Status NOT IN ('Checked-Out', 'Cancelled')
                )
                SELECT 0;
                ELSE
                BEGIN
                    UPDATE Rooms
                    SET IsActive = 0
                    WHERE RoomID = @RoomID;

                    SELECT 1;
                END";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@RoomID", roomID);

                con.Open();

                return (int)cmd.ExecuteScalar() == 1;
            }
        }

        public DataTable GetTotalRooms()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT *
                FROM Rooms
                WHERE IsActive = 1";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.Fill(dt);
            }

            return dt;
        }
    }
}