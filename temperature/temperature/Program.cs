using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the temperature value in Fahrenheit to Celsius: ");
            int fah = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //conversion formula from F to C

            int FtoC = ((fah - 32) / 9) * 5;
            Console.WriteLine("The Celsius value is {0}: ", FtoC);
            { if (fah < 40)

                    Console.Write("It is cold");
                if (fah > 90)
                    
            
                Console.Write("It is hot");


                Console.ReadLine();
            }
        }
    }
}
