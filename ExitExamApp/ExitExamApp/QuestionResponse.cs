using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitExamApp
{
    class QuestionResponse
    {
        private int questionResponseID;
        private int userID;
        private int correct;

        public int getQuestionResponse() { return questionResponseID; }
        public void setQuestionResponse(int qResponse) { questionResponseID = qResponse; }

        public int getUserID() { return userID;}
        public void setUserID(int uID) { userID = uID; }



    }
}
