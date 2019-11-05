using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 29, 2019

            /* Display five asterisks on a single line. Each asterisk must be 
             * separated by a space. You must use a do-while loop to solve this 
             * program. */

            int counter = 0;

            do
            {
                Console.Write("* ");
                counter++;
            } while (counter < 5);
        }
    }
}
