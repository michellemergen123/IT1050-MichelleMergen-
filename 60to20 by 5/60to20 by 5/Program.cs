using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60to20_by_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 60;
            while (i >= 20)
            {
                Console.WriteLine(i);
                i--;
                i = i - 4;
                
            }
            Console.ReadKey();
        }
    }

}
