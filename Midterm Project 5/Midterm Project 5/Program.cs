using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("49");
            for (int number = 48; number >= 1; number--)
                Console.Write(",{0}", number);
            Console.ReadKey();
        }
    }
}
