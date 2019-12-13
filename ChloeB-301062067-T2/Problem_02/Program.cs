using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067

            int number;

            Console.Write("Enter a multiple digit number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("That number reversed is: ");

            while (number > 0)
            {
                Console.Write(number % 10);
                number /= 10;
            }
            Console.WriteLine();
        }
    }
}
