using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 18, 2019

            /* Write a console app that will do the following:
             * a) Display all the items of the char array vowels on a single line 
             * b) Subtract 32 from each item of the char array vowels. You will have to cast the 32 to a char in 
             *    order to do the subtraction
             * c) Display all the new items of the char array vowels on a single line
             * (Declare the following arrays in each application: vowels, primes, poem, obama) */

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
            string[] poem = { "Mary", "had", "a", "little", "lamb" };
            string[] obama = { "Barack", "Hussein", "Obama" };

            Console.WriteLine("Array vowels: ");

            for (int i = 0; i < vowels.Length; ++i)
            {
                Console.Write($"'{vowels[i]}', ");
                vowels[i] -= (char)32;
            }

            Console.WriteLine("\n\nNew values in array vowels: ");

            foreach (int x in vowels)
            {
                Console.Write($"'{(char)x}', ");
            }
        }
    }
}
