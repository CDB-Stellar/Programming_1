using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write an application that asks a user to enter an IQ score. If the 
             * score is a number less than 0 or greater than 200, issue an error 
             * message; otherwise, issue an “above average”, “average”, or 
             * “below average” message for scores over, at, or under 100, 
             * respectively. */

            const int MAX_IQ = 201;
            const int MIN_IQ = -1;
            const int AVERAGE_IQ = 100;
            int iqScore;

            Console.WriteLine("Please enter your IQ score below:");
            iqScore = Convert.ToInt32(Console.ReadLine());

            if (iqScore > AVERAGE_IQ && iqScore < MAX_IQ)
            {
                Console.WriteLine("Above average");
            }
            else if (iqScore == AVERAGE_IQ)
            {
                Console.WriteLine("Average");
            }
            else if (iqScore < AVERAGE_IQ && iqScore > MIN_IQ)
            {
                Console.WriteLine("Below average");
            }
            else
            {
                Console.WriteLine("Error: invalid IQ score");
            }
        }
    }
}
