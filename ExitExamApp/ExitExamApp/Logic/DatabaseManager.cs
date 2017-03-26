using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ExitExamApp
{
    class DatabaseManager
    {
        private String _connectionString = "server=138.197.112.204;Port=3306;Database=XPS;uid=masone@localhost;pwd=Tundra95;";
        private MySqlConnection _connection = null;

        public DatabaseManager()
        {
            _connection = new MySqlConnection(_connectionString);
        }

        private void OpenConnection()
        {
            try
            {
                _connection.Open();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User ValidateUser(String userName, String passWord)
        {
            User result = null;

            try
            {
                OpenConnection();
                using(MySqlCommand command = new MySqlCommand( @"
				    SELECT * 
				
				    FROM 
					    User
				    WHERE
					    Username = @username
					    AND Password = @password;"
			    , _connection))
			{
				command.Parameters.AddWithValue("@username", userName);
				command.Parameters.AddWithValue("@password", passWord);
				
				using(MySqlDataReader reader = command.ExecuteReader())
				{
                    while(reader.Read())
                    { 
					    result = new User()
					    {
						    UserID = Int32.Parse(reader.GetString("UserID"))
						    , FirstName = reader.GetString("FirstName")
						    , LastName = reader.GetString("LastName")
						    , UserName = reader.GetString("UserName")
						    , PassWord = reader.GetString("Password")
						    , UserType = reader.GetString("UserType").ToCharArray()[0]
					    };
                    }
				}
			}
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
