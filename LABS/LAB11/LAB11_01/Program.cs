using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 27, 2019

            /* (In a single project, implement all methods)
             * 1. Write a method that prints the array obama. Each element must be on a separate line. Call method from main.
             * 2. Write a method that prints the array poem. Each element must be on the same line. Call method from main.
             * 3. Write a method to sum all the numbers in primes, and displays it. Call this method from main.
             * 4. Write a method to double the numbers in primes. Call this after displaying primes, and then display primes again after.
             * 5. a) Write a method to subract 32 from each element in vowels (use cast).
             *    b) Write another method to display array vowels on a single line.
             *    c) From main, call second one, then the first, then second again.
             * 6. Change number 3 method to return the sum instead of displaying it. Update main accordingly. */

            string[] obama = { "Barack", "Hussein", "Obama" };
            string[] poem = { "Mary", "had", "a", "little", "lamb" };
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("1.");
            PrintArrayNewLine(obama);

            Console.WriteLine("\n2.");
            PrintArraySameLine(poem);
            
            Console.WriteLine($"\n\n3.\n{CalculateSum(primes)}");
            DoubleArrayElements(ref primes);
            Console.WriteLine($"\n4.\n{CalculateSum(primes)}");

            Console.WriteLine("\n5.");
            DisplayCharArraySameLine(vowels);
            Subtract32( ref vowels);
            Console.WriteLine();
            DisplayCharArraySameLine(vowels);

            Console.WriteLine();
        }

        static void PrintArrayNewLine(string[] anArray)
        {
            for (int i = 0; i < anArray.Length; ++i)
            {
                Console.WriteLine(anArray[i]);
            }
        }

        static void PrintArraySameLine(string[] anArray)
        {
            for (int i = 0; i < anArray.Length; ++i)
            {
                Console.Write(anArray[i]);
            }
        }

        static int CalculateSum(int[] anArray)
        {
            int sum = 0;

            for (int i = 0; i < anArray.Length; ++i)
            {
                sum += anArray[i];
            }

            return sum;
        }

        static void DoubleArrayElements(ref int[] anArray)
        {
            for (int i = 0; i < anArray.Length; ++i)
            {
                anArray[i] = anArray[i] * 2;
            }
        }

        static void Subtract32(ref char[] anArray)
        {
            for (int i = 0; i < anArray.Length; ++i)
            {
                anArray[i] -= (char)32;
            }
        }

        static void DisplayCharArraySameLine(char[] anArray)
        {
            for (int i = 0; i < anArray.Length; ++i)
            {
                Console.Write(anArray[i]);
            }
        }
    }
}
