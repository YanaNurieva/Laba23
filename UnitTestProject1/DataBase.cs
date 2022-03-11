using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WpfLabaTsi;
namespace UnitTestProject1
{
    public class DataBase
    {
        public string ConnetionString { get; set; }
        public DataBase(string connectStr)
        {
            ConnetionString = connectStr;
        }
        public bool SignInUser(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnetionString))
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand("Select * FROM Users WHERE Login = @login AND Password = @password", connection);
                    command.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@login", login),
                        new SqlParameter("@password",password)
                    });
                    if (command.ExecuteReader().HasRows)
                        return true;
                }
            }
            return false;
        }

        public int SignUpUser(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection("Server = Artem; DataBase = WpfBase; Encrypt = false; Trusted_Connection = true;"))
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand("Insert Users VALUES (@login, @password, User)", connection);
                    command.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@login", login),
                        new SqlParameter("@password",password)
                    });
                   return command.ExecuteNonQuery();
                }
            }
            return default;
        }
    }
}
