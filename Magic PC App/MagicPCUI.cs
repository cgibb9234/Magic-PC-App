using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_PC_App
{
    class MagicPCUI
    {
        MagicPCclass magClass = new MagicPCclass();

        string userQuestion;
        string aHeader = "\n*********************************************************";
        
        public MagicPCUI()
        {

            introText();

            while (userQuestion != "quit" && userQuestion != "QUIT") //I have to figure out the null character
            {
                Console.Write("What is your question?: ");
                Console.ReadLine();
                magClass.getUserAnswer();
                waiting();
                Console.WriteLine("");
                Console.WriteLine(magClass.GenAnswer);
                Console.WriteLine("Would you like another attempt? (Type Yes to go again, type quit to quit): ");
                userQuestion = Console.ReadLine();
            }

        }

        public void introText()
        {
            Console.WriteLine(aHeader);
            Console.WriteLine("\tWelcome my friend welcome. Come closer. That's right");
            Console.WriteLine("");
            Console.WriteLine("\tThis is the magic PC Screen.  All your questions will be answered!");
            Console.WriteLine("\tJust enter a question and the magic PC screen will give you the answer!");
            Console.WriteLine("");
            Console.WriteLine("\tHowever, it must be a question that can be answerd with a yes or a no");
            Console.WriteLine("\tTo exit the program, just hit the Enter key");
            Console.WriteLine("");
            Console.WriteLine(aHeader);
            Console.WriteLine("");
            Console.WriteLine("Hit any key to continue");
            Console.ReadKey();
        }

        public void waiting()
        {
            Console.Write("Thinking.");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
        }
    }
}
