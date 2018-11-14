using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifthen_truefalse
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Programming 1050");
            Console.Write("This class is hard:  yes or no?:");
            string userValue = Console.ReadLine();

            if (userValue == "yes")
            {
                string message = "It is true!";
                Console.WriteLine(message);
            }
            else if (userValue == "no")
            {
                string message = "It is false!";
                Console.WriteLine(message);
            }
            Console.ReadLine();


        }
    }
}
