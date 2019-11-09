using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write a program to reverse the digits of a positive integer number. For example, if the number 8735 is entered, 
             * the number displayed should be 5378. (Hint: Use a do statement and continuously strip off and display the units
             * digit of the number. If the variable num initially contains the number entered, the units digit is obtained as 
             * (num % 10). After a units digit is displayed, dividing the number by 10 sets up the number for the next iteration. 
             * Thus, (8735 % 10) is 5 and (8735 / 10) is 873. The do statement should continue as long as the remaining number is 
             * not zero). */

            int number;

            Console.Write("Please enter any multiple digit number: ");
            number = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write(number % 10);
                number /= 10;
            } while (number != 0);

            Console.WriteLine();
        }
    }
}
