using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Program
    {
        public static void Main(string[] args)
        {

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            foreach (string name in names)
            {
                Console.WriteLine("[{0}] : {1}", Array.IndexOf(names, name), name);
                Console.ReadKey();
            }

        }
    }

