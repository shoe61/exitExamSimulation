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
        private int _questionID;
        private int _questionCategory;
        private string _text;
        private string _answer;
        private string _incorrect1;
        private string _incorrect2;
        private string _incorrect3;
        private string _incorrect4;
        private string _hint;

        public Question()
        {
            _questionID = 0;
            _questionCategory = 0;
            _text = "";
            _answer = "";
            _incorrect1 = "";
            _incorrect2 = "";
            _incorrect3 = "";
            _incorrect4 = "";
            _hint = "";
        }

        public int QuestionID
        {
            get
            {
                return _questionID;
            }
            set
            {
                _questionID = value;
            }

        }

        public int QuestionCategory
        {
            get
            {
                return _questionCategory;
            }
            set
            {
                _questionCategory = value;
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }

        public string Answer
        {
            get
            {
                return _answer;
            }
            set
            {
                _answer = value;
            }
        }

        public string Incorrect1
        {
            get
            {
                return _incorrect1;
            }
            set
            {
                _incorrect1 = value;
            }
        }

        public string Incorrect2
        {
            get
            {
                return _incorrect2;
            }
            set
            {
                _incorrect2 = value;
            }
        }

        public string Incorrect3
        {
            get
            {
                return _incorrect3;
            }
            set
            {
                _incorrect3 = value;
            }
        }

        public string Incorrect4
        {
            get
            {
                return _incorrect4;
            }
            set
            {
                _incorrect4 = value;
            }
        }

        public string Hint
        {
            get
            {
                return _hint;
            }
            set
            {
                _hint = value;
            }
        }
    }
}