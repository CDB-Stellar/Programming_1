using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 19, 2019

            /* Write a program containing an array that holds five integers. Assign values to the integers. 
             * Display the integers from first to last, and then display them from last to first. */

            int[] numbers = new int[5] {3, 6, 2, 8, 10};

            Array.Sort(numbers);
            Console.WriteLine($"Numbers from first to last:");
            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine();

            Array.Reverse(numbers);
            Console.WriteLine($"Numbers from last to first:");
            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.Write($"{numbers[i]}, ");
            }
        }
    }
}
