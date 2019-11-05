using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* Display the numbers 10 ... 40 on separate lines with an asterisk 
             * before the multiples of 7. (asterisk besides multiples) */

            int counter = 9;

            do
            {
                if ((counter + 1) % 7 == 0)
                {
                    Console.Write("*");
                }
                Console.WriteLine(counter + 1);
                counter++;
            } while (counter < 40);
        }
    }
}
