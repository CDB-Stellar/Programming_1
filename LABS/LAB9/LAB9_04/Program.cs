using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 18, 2019

            /* Write a console app that displays all elements of int array primes, then doubles all the items of the array 
             * and then displays the new values.
             * (Declare the following arrays in each application: vowels, primes, poem, obama) */

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
            string[] poem = { "Mary", "had", "a", "little", "lamb" };
            string[] obama = { "Barack", "Hussein", "Obama" };

            Console.WriteLine("Original numbers:");

            for (int i = 0; i < primes.Length; ++i)
            {
                Console.Write($"{primes[i]}, ");
            }

            Console.WriteLine("\n\nThose numbers doubled are:");

            for (int i = 0; i < primes.Length; ++i)
            {
                primes[i] *= 2;
                Console.Write($"{primes[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
