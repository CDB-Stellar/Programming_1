using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 30, 2019

            /* [Part 1: Question 7]
             * Write a method called DisplayMenu() */

            DisplayMenu();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("================Chloe’s Computer Systems==================");
            Console.WriteLine("|         1. To display Personal Information             |");
            Console.WriteLine("|         2. To calculate Tuition                        |");
            Console.WriteLine("|         3. To calculate area of a Circle               |");
            Console.WriteLine("|         4. To calculate the area of a Triangle         |");
            Console.WriteLine("|         5. To calculate sales commission               |");
            Console.WriteLine("|         6. To display sine table                       |");
            Console.WriteLine("|         0. To end program                              |");
            Console.WriteLine("|                                                        |");
            Console.WriteLine("==========================================================");
            Console.Write("          Enter the number of your choice ->");
        }
    }
}
