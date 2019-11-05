using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* Display numbers 20 ... 60 on separate lines skipping the multiple 
             * of 3. You must print a blank line for each multiple. */

            int counter = 19;

            do
            {
                if ((counter + 1) % 3 != 0)
                {
                    Console.WriteLine(counter + 1);
                }
                else
                {
                    Console.WriteLine("");
                }
                counter++;
            } while (counter < 60);
        }
    }
}
