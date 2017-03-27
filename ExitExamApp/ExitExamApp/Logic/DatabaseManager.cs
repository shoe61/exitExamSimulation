using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ExitExamApp
{
    public class DatabaseManager
    {
        //The connection String for our database.
        private String _connectionString = @"server=138.197.112.204;Port=3306;Database=XPS;uid=masone@localhost;pwd=Tundra95;";
        private MySqlConnection _connection = null;

        /// <summary>
        /// Initializes the DatabaseManager object with the connection string. 
        /// </summary>
        public DatabaseManager()
        {
            _connection = new MySqlConnection(_connectionString);
        }

        /// <summary>
        /// This Method opens our connection to the server.
        /// </summary>
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

        /// <summary>
        /// This method closes our connection to the server.
        /// </summary>
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

        /// <summary>
        /// This method will be used to validate a user's log in credentials.
        /// </summary>
        /// <param name="userName"> The username from the log in form </param>
        /// <param name="passWord"> The password from the log in form </param>
        /// <returns>
        /// The result is the user object. If the method returns null, the user
        /// was not validated.
        /// </returns>
        public User ValidateUser(String userName, String passWord)
        {
            User result = null;
            //This query will select the entire row from the user table wiht the given username and password.
            String query = @"
				SELECT * 
				
				FROM 
					User
				WHERE
					UPPER(Username) = UPPER(@username)
					AND Password = @password;";
            try
            {
                OpenConnection();
                using(MySqlCommand command = new MySqlCommand(query, _connection))
			    {
                    //Adds the parameters to the query.
				    command.Parameters.AddWithValue("@username", userName);
				    command.Parameters.AddWithValue("@password", passWord);
				
				    using(MySqlDataReader reader = command.ExecuteReader())
				    {
                        while(reader.Read())
                        { 
                            //Builds the user object from the row in the database.
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

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Returns a user object for a given userID.
        /// </summary>
        /// <param name="userID"> The userID</param>
        /// <returns>The User object</returns>
        public User GetUser(int userID)
        {
            User result = null;
            //This query will return the row in the User table for the userID.
            String commandString = @"                    
                SELECT *

                FROM 
                    User
                WHERE
                    UserID = @UserID;";

            try
            {
                OpenConnection();

                using (MySqlCommand command = new MySqlCommand(commandString, _connection))
                {
                    //Adds the parameter to the query.
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Builds the user object from the row in the database.
                            result = new User()
                            {
                                UserID = Int32.Parse(reader.GetString("UserID"))
                                , FirstName = reader.GetString("FirstName")
                                , LastName = reader.GetString("LastName")
                                , UserName = reader.GetString("UserName")
                                , PassWord = reader.GetString("Password")
                                , UserType = reader.GetChar("UserType")
                            };
                        }
                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// This method inserts a user into the user table.
        /// </summary>
        /// <param name="user">The user object that will be inserted into the database</param>
        /// <returns>The return value indicates whether the operation was successful</returns>
        public bool InsertUser(User user)
        {
            bool result = false;
            String query = @"
				INSERT INTO User
				(
					FirstName
					, LastName
					, UserName
					, Password
					, UserType
				)
				VALUES
				(
					@FirstName
					, @LastName
					, @UserName
					, @Password
					, @UserType
				);";

            try
            {
                OpenConnection();

                using(MySqlCommand command = new MySqlCommand(query, _connection))
			    {
                    //Adds the parameters to the query from the user object.
				    command.Parameters.AddWithValue("@FirstName", user.FirstName.Trim());
				    command.Parameters.AddWithValue("@LastName", user.LastName.Trim());
				    command.Parameters.AddWithValue("@username", user.UserName.Trim());
				    command.Parameters.AddWithValue("@password", user.PassWord.Trim());
				    command.Parameters.AddWithValue("@UserType", user.UserType);
				
                    //If there was a row effected(inserted).
				    if (command.ExecuteNonQuery() == 1)
				    {
					    result = true;
				    }
			    }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// This method deletes the user with the given userID.
        /// </summary>
        /// <param name="userID">The userID of the user to be deleted</param>
        /// <returns>The result returned indicates where the operation was successful</returns>
        public bool DeleteUser(int userID)
        {
            bool result = false;
            //This query will delete the user from the table.
            String query = @"DELETE FROM User WHERE UserID = @UserID;";

            try
            {
                OpenConnection();

                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    //Adds the userID to the query.
                    command.Parameters.AddWithValue("@UserID", userID);

                    //If the row was deleted.
                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
