using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_Printing_Numbers_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 10, 2019
            //You can do this using switch instead

            string aNumber;

            Console.WriteLine("Please enter a number");
            aNumber = Console.ReadLine();

            if (aNumber == "1")
            {
                Console.WriteLine("One");
            }
            else if (aNumber == "2")
            {
                Console.WriteLine("Two");
            }
            else if (aNumber == "4")
            {
                Console.WriteLine("Four");
            }
            else if (aNumber == "5")
            {
                Console.WriteLine("Five");
            }
            else
            {
                Console.WriteLine("I don't know");
            }
        }
    }
}
