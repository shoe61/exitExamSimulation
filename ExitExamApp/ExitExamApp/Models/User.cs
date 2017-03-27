using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitExamApp
{
    public class User
    {
        private int _userID;
        private String _firstName;
        private String _lastName;
        private String _userName;
        private String _passWord;
        private Char _userType;

        public User()
        {
            _userID = 0;
            _firstName = "";
            _lastName = "";
            _userName = "";
            _passWord = "";
            _userType = 'S';
        }

        public int UserID
        {
            get
            {
                return _userID;
            }
            set 
            {
                //Ensures that the value is positive
                if (value > 0)
                {
                    _userID = value;
                }
                else
                {
                    throw new Exception(String.Format("{0} is not a valid User ID. The value must be positive.", value));
                }
            }
        }

        public String FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                //Ensures that the value is not too long to be stored in the database.
                if (value.Length <= Logic.Constants.USER_FIRSTNAME_LENGTH)
                {
                    _firstName = value;
                }
                else
                {
                    throw new Exception("First Name input too large."); 
                }
            }
        }

        public String LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                //Ensures that the value is not too long to be stored in the database.
                if (value.Length <= Logic.Constants.USER_LASTNAME_LENGTH)
                {
                    _lastName = value;
                }
                else
                {
                    throw new Exception("Last Name input too large.");
                }
            }
        }

        public String UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                //Ensures that the value is not too long to be stored in the database.
                if (value.Length <= Logic.Constants.USER_USERNAME_LENGTH)
                {
                    _userName = value;
                }
                else
                {
                    throw new Exception("Username input too large.");
                }
            }
        }

        public String PassWord
        {
            get
            {
                return _passWord;
            }
            set
            {
                //Ensures that the value is not too long to be stored in the database.
                if (value.Length <= Logic.Constants.USER_PASSWORD_LENGTH)
                {
                    _passWord = value;
                }
                else
                {
                    throw new Exception("Password input too large");
                }
            }
        }

        public Char UserType
        {
            get
            {
                return _userType;
            }
            set
            {
                //Ensures that a valid user type is assigned.
                if (Logic.Constants.USER_USERTYPES.Contains(value))
                {
                    _userType = value;
                }
                else
                {
                    throw new Exception(String.Format("{0} is not a valid user type.", value));
                }
            }
        }
    }
}
