using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* Repeatedly prompt for a number and sum it. When the sum just exceeds 
             * 100, stop the prompting and display the sum at the end. You must not 
             * display the sum while the user in typing in numbers. (You do not need 
             * a counter but you will need some way of terminating the loop) */

            int sum = 0;

            do
            {
                Console.Write("Enter a number: ");
                sum += Convert.ToInt32(Console.ReadLine());
            } while (sum <= 100);

            Console.WriteLine($"The sum of all entered numbers is: {sum}");
        }
    }
}
