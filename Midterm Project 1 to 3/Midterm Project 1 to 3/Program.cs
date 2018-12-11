using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project_1_to_3

// Control structures that can be used to order statements are:  (1) Loops included while and do while will repeat a part of code until the terminating sequence is met.
//  (2) Switches can be used in statements are used in place of if else statements (3) if statements include if else and else that use logic to solve code
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 11;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i<=10) keepLooping = false;
                i++;
                Console.WriteLine(i);
                
            }
        }
    }
}
