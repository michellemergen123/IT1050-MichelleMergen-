using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The array access expressions to access each of the elements in p are ___[0]__, ___[1]__,__[2]__ and __[3]___.
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [12];
            
            {
                String[] month = new string[12];
                month[0] = "January";
                month[1] = "February";
                month[2] = "March";
                month[3] = "April";
                month[4] = "May";
                month[5] = "June";
                month[6] = "July";
                month[7] = "August";
                month[8] = "September";
                month[9] = "October";
                month[10] = "November";
                month[11] = "December";
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("{0,2}. {1}", i, month[i]);
                }
                {
                    int i = 0;
                    Console.Write("{0,2}. {1}", i, month[i]);
                    
                }

                
            }
        }
    }
}
    
   

