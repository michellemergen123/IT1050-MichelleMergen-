﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project_7
    //output is *.  The do while outputs the same * but the while loop doesn't output anything.
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition

            Console.ReadKey();
            
        }
    }
}
// output is: *
