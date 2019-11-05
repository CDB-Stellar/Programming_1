using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* Display the numbers 1 ... 20 on separate lines. */

            int counter = 0;

            do
            {
                Console.WriteLine(counter + 1);
                counter++;
            } while (counter < 20);
        }
    }
}
