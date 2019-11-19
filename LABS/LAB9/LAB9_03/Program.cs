using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 18, 2019

            /* Write a console app that sums all the items of the array primes, and then display this sum.
             * (Declare the following arrays in each application: vowels, primes, poem, obama) */

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
            string[] poem = { "Mary", "had", "a", "little", "lamb" };
            string[] obama = { "Barack", "Hussein", "Obama" };

            int sum = 0;

            for (int i = 0; i < primes.Length; ++i)
            {
                sum += primes[i];
            }

            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
