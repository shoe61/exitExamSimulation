using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitExamApp
{
    class Test
    {
        private int testID;
        private int userID;
        private string correctAnswer;
        private float time;
        private int attempted;

        public int getTestID() { return testID; }
        public void setTestID(int tID) { testID = tID; }

        public int getUserID() { return userID; }
        public void setUserID(int uID) { userID = uID; }


        public float getTime() { return time; }
        public void setTime(float t) { time = t; }


    }
}
