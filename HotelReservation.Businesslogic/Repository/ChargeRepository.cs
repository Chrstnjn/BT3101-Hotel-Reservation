using HotelReservation.Model;
using System.Configuration;
using System.Data.SqlClient;

namespace HotelReservation.Businesslogic.Repository
{
    public class ChargeRepository
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["HighlandsDB"].ConnectionString;

        // For manual charges later (damage, extra bed, etc.)
        public void Add(ChargeModel charge)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Charge (ReservationID, ChargeType, Description, Amount)
                      VALUES (@ReservationID, @ChargeType, @Description, @Amount)", con);

                cmd.Parameters.AddWithValue("@ReservationID", charge.ReservationID);
                cmd.Parameters.AddWithValue("@ChargeType", charge.ChargeType);
                cmd.Parameters.AddWithValue("@Description", (object?)charge.Description ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Amount", charge.Amount);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<ChargeModel> GetByReservation(int reservationId)
        {
            List<ChargeModel> list = new List<ChargeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT ChargeID, ReservationID, ChargeType, Description, Amount, ChargedDate
                      FROM Charge
                      WHERE ReservationID = @ReservationID
                      ORDER BY ChargedDate", con);

                cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new ChargeModel
                        {
                            ChargeID = dr.GetInt32(0),
                            ReservationID = dr.GetInt32(1),
                            ChargeType = dr.GetString(2),
                            Description = dr.IsDBNull(3) ? null : dr.GetString(3),
                            Amount = dr.GetDecimal(4),
                            ChargedDate = dr.GetDateTime(5)
                        });
                    }
                }
            }

            return list;
        }

        public decimal GetTotal(int reservationId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(Amount), 0) FROM Charge WHERE ReservationID = @ReservationID", con);

                cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                con.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
    }
}