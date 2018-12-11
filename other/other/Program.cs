using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace other
{
    class Program

    {
        static void Main(string[] args)
        {
            int loop = 2;
            while (loop < 128)
            {
                Console.WriteLine("[{0}]", loop++);
                loop *= 2;
                Console.ReadKey();

            }

        }
    }
}
   



