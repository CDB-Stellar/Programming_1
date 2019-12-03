using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 1] 
             * Write a method called CaculateDifference(int firstNumber, int secondNumber). This method will
             * calculate and return the difference between the two numbers i.e. it will subtract the 
             * smaller one from the larger one and then return that value. Call the CaculateDifference() 
             * method four times from your program Main() method supplying different arguments each time. */

            Console.WriteLine(CaculateDifference(5,6));
            Console.WriteLine(CaculateDifference(3, 2));
            Console.WriteLine(CaculateDifference(10, 6));
            Console.WriteLine(CaculateDifference(3, 6));
        }

        static int CaculateDifference(int firstNumber, int secondNumber)
        {
            int difference = firstNumber - secondNumber;
            return difference;
        }
    }
}
