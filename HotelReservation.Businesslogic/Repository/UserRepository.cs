using HotelReservation.Model;
using System.Configuration;
using System.Data.SqlClient;

namespace HotelReservation.Businesslogic.Repository
{
    public class UserRepository
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

        public UserModel Login(string username, string password)
        {
            UserModel user = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT *
                                 FROM Users
                                 WHERE Username = @Username
                                 AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = new UserModel
                    {
                        UserID = Convert.ToInt64(reader["UserID"]),
                        Username = reader["Username"].ToString(),
                        FullName = reader["FullName"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString(),
                        CreationDate = Convert.ToDateTime(reader["CreationDate"])
                    };
                }
            }

            return user;
        }
    }
}