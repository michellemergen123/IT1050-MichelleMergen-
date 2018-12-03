using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lab6 
{
    static void Main()
    {
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        

        for (int i = 0; i < seasons.Length; i++)
        {
            Console.WriteLine(seasons[i]);
        }

        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }
    }
}



