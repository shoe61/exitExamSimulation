using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitExamApp
{
    public class User
    {
        private int userID;
        private string firstName;
        private string lastName;
        private string category;
        private string userName;
        private string passWord;

        //Created this just to mess around with the simple log in
        public User()
        {
            userID = 0;
            firstName = "Joshua";
            lastName = "Regino";
            userName = "JRegino";
            passWord = "tomatoes";
        }

        public int getUserID(){return userID;}
        public void setUserID(int id){userID = id;}

        public string getFirstName(){return firstName;}
        public void setFirstName(string first) { firstName = first; }

        public string getLastName() { return lastName; }
        public void setLastName(string last) { lastName = last; }

        public string getCategory() { return category;  }
        public void setCategory(string cat) { category = cat; }
        
        public string getUserName(){return userName;}
        public void setUserName(string user) { userName = user; }

        public string getPassword(){return passWord;}
        public void setPassword(string pass) { passWord = pass; }

    }

    


}
