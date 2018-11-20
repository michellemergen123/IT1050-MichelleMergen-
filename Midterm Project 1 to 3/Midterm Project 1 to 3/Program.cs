using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project_1_to_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i <= 9) keepLooping = false;
                i++;
                Console.WriteLine(i);
            }
        }
    }
}
