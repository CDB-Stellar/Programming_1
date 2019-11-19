using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 18, 2019

            /* Write a console app that prints the string array poem. All the items must be in the same line. 
             * (Declare the following arrays in each application: vowels, primes, poem, obama) */

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
            string[] poem = { "Mary", "had", "a", "little", "lamb" };
            string[] obama = { "Barack", "Hussein", "Obama" };

            for (int i = 0; i < poem.Length; ++i)
            {
                Console.Write($"{poem[i]} ");
            }
        }
    }
}
