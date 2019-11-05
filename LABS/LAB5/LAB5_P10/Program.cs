using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a console-based application that asks a user to enter 
             * an IQ score. If the score is a number less than 0 or greater 
             * than 200, issue an error message; otherwise, issue an “above 
             * average”, “average”,or “below average” message for scores 
             * over, at, or under 100, respectively. */

            int iqScore;

            Console.Write("Please enter the IQ score: ");
            iqScore = Convert.ToInt32(Console.ReadLine());

            if (iqScore < 0 || iqScore > 200)
            {
                Console.WriteLine("Error. Invalid IQ score.");
            }
            else if (iqScore > 100)
            {
                Console.WriteLine("Above Average");
            }
            else if (iqScore == 100)
            {
                Console.WriteLine("Average");
            }
            else
            {
                Console.WriteLine("Below Average");
            }
        }
    }
}
