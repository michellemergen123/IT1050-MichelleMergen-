using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /*  Both the if single-selection statement and the while repetition statement perform an action or set of actions based on whether a condition is true or false.
     *  The single-selection statement performs the action once while the while repetition statement repeatedly performs the actions until the condition becomes 
     *  false. */

     class Speed
    {
        static void Main()
        {
            // Problem 3
            int speedLimit;
            speedLimit = 35;
            int speed;
            speed = 42;

            if (speed > speedLimit)
            {
                Console.Write("SLOW NOW");
            }

            // Problem 4
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
           

        }
    }

}
               