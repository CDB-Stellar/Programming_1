using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* Display the sum of all the multiples of 3 between 1000000 
             * and 2000000. (Answer = 499, 999, 500, 000). If the sum might 
             * be larger than 2 billion then the type of sum should be a 
             * long and not an int. */

            long sum = 0;
            int counter = 1000000;

            do
            {
                if (counter % 3 == 0)
                {
                    sum += counter;
                }
                counter++;
            } while (counter <= 2000000);

            Console.WriteLine($"The sum of all multiples of 3 between 1 million and 2 million is: {sum}");
        }
    }
}
