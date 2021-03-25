using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_PC_App
{
    class Info
    {
        public Info(string assignment)
        {
            string aHeader = "\n*********************************************************";

            Console.WriteLine(aHeader);
            Console.WriteLine("Name: \t\tCorey Gibb");
            Console.WriteLine("Course:\t\tITDEV-115-200");
            Console.WriteLine("Instructor:\tMr. Menzl");
            Console.WriteLine("Assignment:\t" + assignment);
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine(aHeader);
        }
    }
}
