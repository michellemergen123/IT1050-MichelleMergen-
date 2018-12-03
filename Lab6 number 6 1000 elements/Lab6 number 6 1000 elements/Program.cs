using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_number_5_1000_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNum = new int[1000];
            Random RandomNumber = new Random();


            for (int i = 0; i < 1000; i++)
            {
                randomNum[i] = RandomNumber.Next(1, 100);
            }


            foreach (int n in randomNum)
            {
                Console.WriteLine("{0}", n);
            }


            Console.ReadKey();
        }
    }
}
