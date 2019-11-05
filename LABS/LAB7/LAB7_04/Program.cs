using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* Display the numbers 1 ... 20 on separate lines with an asterisk 
             * next to multiples of 5. (multiples besides asterisk) */

            int counter = 0;

            do
            {
                if ((counter + 1) % 5 == 0)
                {
                    Console.Write("*");
                }
                Console.WriteLine(counter + 1);
                counter++;
            } while (counter < 20);
        }
    }
}
