using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitExamApp
{
    class Test
    {
        private int _testID;
        private int _userID;
        private string _correctAnswer;
        private float _time;
        private int _attempted;

        public Test()
        {
            _testID = 0;
            _userID = 0;
            _correctAnswer = "";
            _time = 0;
            _attempted = 0;
        }

        public int TestID
        {
            get
            {
                return _testID;
            }
            set
            {
                _testID = value;
            }
        }

        public int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }

        public string CorrectAnswer
        {
            get
            {
                return _correctAnswer;
            }
            set
            {
                _correctAnswer = value;
            }
        }

        public float Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }

        public int Attempted
        {
            get
            {
                return _attempted;
            }
            set
            {
                _attempted = value;
            }
        }
    }
}