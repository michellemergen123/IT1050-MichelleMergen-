using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; //declare first number to multiply
            int number2; //declare second number to multiply
            int sum; //declare sum of number1 * number2

            Console.Write("Enter first integer: "); //prompt user
            //read first number from user
            number1 = Convert.ToInt32(Console.ReadLine() );

            Console.Write("Enter second integer: "); //prompt user
            //read second number from user
            number2 = Convert.ToInt32(Console.ReadLine() );

            sum = number1 * number2; // multiply numbers

            Console.WriteLine("product is {0}", sum); //display product
            /* A) Execution starts with any class that contains a main method. 
             * B)  the difference between an integer variable and a double/float variable is that integer variables have no decimal place and double/float variables do. For example int =5, float = 5.44
             * C) A static method can be called without creating an object of the class in which the method is declared.
             * D)  To read the value of an instance variable, we create method called a get accessor.  To assign a value to an instance variable, we use a method called a set accessor.
             * E) An object is an instance of a class. Objects have values that either have to be defined or are defined by default settings. A class describes the values.  We can create 1 or more instances of a class.  
             */

            Console.WriteLine("{0}\n{1}", "Hello World!", "From Michelle Mergen");
            Console.WriteLine( "Hello World! From Michelle Mergen");
            Console.ReadKey();
        

       
        }
    }
}
