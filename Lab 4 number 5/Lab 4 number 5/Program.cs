using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_number_5
{
    class Program
        /*#2  The four basic elements of the counter-controlled repetition are the control variable/loop counter, initial value of the control variable, 
         * an increment or decrement by which the control variable is modified each time through the loop, and a loop continuation condition that determines
         * whether looping should continue.  The intial value is the starting point of the control variable and the increment or decrement is 
         * how the control variable is modified each time through the loop and the loop continuation continuation determines if the loop should continue or end.
         * 
         * #3  Compare and contrast the while and for repetition statements
         * While and for repetition statements are very similiar and can each do just about the same thing.  Both are entry controlled loops, 
         * and the continuation condition is checked at the time of entering the loop.  The while statement can be used to implement any counter controlled loop while the 
         * repetition statement is for specifying the counter controlled repetition detail in a single line of code.
         * #4  It would be more appropriate to use a do-while statement than a while statement when the condition must be run after the loop. 
         * A do-while statement would be good for coming up with the sum of a loop of integers.*/
    {
        static void Main(string[] args)
        {
            for (int i =1; i<101; i++)
            {
                Console.WriteLine(i);
                {
                    if ((i % 2)==0) // it’s even
                    { Console.WriteLine("The Number is Even");
                    }
                    else if ((i % 2) != 0) // it’s odd
                    { Console.WriteLine("The Number is Odd");
                    }
                    
                }
            }
        }

    }
}
