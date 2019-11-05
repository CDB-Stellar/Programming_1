using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* Same as LAB7_07 but additionally displays the average of the numbers at the 
             * end of the loop. You will need a counter but not as a loop terminator. */

            int counter = 0;
            double average;
            int sum = 0;

            do
            {
                Console.Write("Enter a number: ");
                sum += Convert.ToInt32(Console.ReadLine());
                counter++;
            } while (sum <= 100);

            average = sum / counter;

            Console.WriteLine($"The sum of all entered numbers is: {sum}");
            Console.WriteLine($"The average of the numbers is: {average}");
        }
    }
}
