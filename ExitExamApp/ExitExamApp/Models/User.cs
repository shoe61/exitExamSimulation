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
                _firstName = value;
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
                _lastName = value;
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
                _passWord = value;
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
                _userType = value;
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
                _userName = value;
            }
        }
    }

    


}
