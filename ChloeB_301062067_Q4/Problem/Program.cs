using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067

            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };

            for (int i = 0; i < primes.Length; ++i)
            {
                Console.Write($"{primes[i]}, ");
                primes[i] *= 2;
            }
            Console.WriteLine();

            for (int i = 0; i < primes.Length; ++i)
            {
                Console.Write($"{primes[i]}, ");
            }
        }
    }
}
