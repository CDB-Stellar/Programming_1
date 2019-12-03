using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_04._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 4: Question 4]
             * Write a method that takes four parameters of type int. The method will assign the sum of
             * the first two arguments to the third and the difference of the first two to the fourth. 
             * This method should be coded so that the calling method will use the value of the third 
             * and fourth parameters. Call this method about three times and print out the value of the
             * four parameters after the method returns. */
             
            int sum, difference;

            SumAndDifference(4, 6, out sum, out difference);
            Console.WriteLine($"{4}, {6}, sum: {sum}, difference: {difference}");
            SumAndDifference(10, 8, out sum, out difference);
            Console.WriteLine($"{10}, {8}, sum: {sum}, difference: {difference}");
            SumAndDifference(7, 7, out sum, out difference);
            Console.WriteLine($"{7}, {7}, sum: {sum}, difference: {difference}");
        }

        static void SumAndDifference(int num1, int num2, out int sum, out int difference)
        {
            sum = num1 + num2;
            difference = num1 - num2;
        }
    }
}
