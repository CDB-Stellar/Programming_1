using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067

            int firstValue;
            int smallest;
            int currentValue;

            Console.WriteLine("Enter several integers below (the first value enter will be how many values you must enter):");
            firstValue = Convert.ToInt32(Console.ReadLine());
            smallest = firstValue;

            for (int count = 0; count < firstValue; ++count)
            {
                Console.Write("Enter an integer: ");
                currentValue = Convert.ToInt32(Console.ReadLine());

                if (smallest > currentValue)
                {
                    smallest = currentValue;
                }
            }

            Console.WriteLine($"The smallest value was {smallest}.");
        }
    }
}
