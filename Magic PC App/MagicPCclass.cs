using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_PC_App
{
    class MagicPCclass
    {
        
        Random rando = new Random();
        int ballNumber = 0;

        string genAnswer;

        public void getUserAnswer()
        {
            switch (rando.Next(8))
            {
                case 0:
                    genAnswer = "It does not appear likely.";
                    break;
                case 1:
                    genAnswer = "All signs point to yes.";
                    break;
                case 2:
                    genAnswer = "The answer is too cloudy, please try again?";
                    break;
                case 3:
                    genAnswer = "Yes, definitely.";
                    break;
                case 4:
                    genAnswer = "It does not look good.";
                    break;
                case 5:
                    genAnswer = "It is most probable.";
                    break;
                case 6:
                    genAnswer = "I can not tell at this time.";
                    break;
                case 7:
                    genAnswer = "Outcome unknown.";
                    break;
            }
        }

        public string GenAnswer
        {
            get
            {
                return genAnswer;
            }
            set
            {
                genAnswer = value;
            }
        }

        public int BallNumber { get => ballNumber; set => ballNumber = value; }
    }
}
