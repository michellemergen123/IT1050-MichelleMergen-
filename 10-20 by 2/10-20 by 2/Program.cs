using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_20_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i++; i = i + 1;
            }
            Console.ReadKey();
        }
    }

}
