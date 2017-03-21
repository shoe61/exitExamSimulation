using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExitExamApp
{
    class Question
    {
        private int questionID;
        private int questionCategory;
        private string text;
        private string answer;
        private string incorrect1;
        private string incorrect2;
        private string incorrect3;
        //private string hint;

        public Question()
        {

        }

        public int getQuestionID() { return questionID; }
        public void setID(int id) { questionID = id; }

        public int getQuestionCategory() { return questionCategory; }
        public void setQuestionCategory(int cat) { questionCategory = cat; }

        public string getText() { return text; }
        public void setText(string t) { text = t;  }

        public string getAnswer() { return answer; }
        public void setAnswer(string ans) { answer = ans; }

        //public string getIncorrect1() { return incorrect1; }
        //public void setIncorrect1(string ans){incorrect1 = ans;}
        //public string getIncorrect2() { return incorrect2; }
        //public void setIncorrect2(string ans){incorrect2 = ans;}
        //public string getIncorrect3() { return incorrect3; }
        //public void setIncorrect3(string ans){incorrect3 = ans;}

        //public string getHint() { return hint; }
        //public void setHint(string h) { hint = h; }


    }
}
