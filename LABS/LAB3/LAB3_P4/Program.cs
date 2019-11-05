using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a program to display the tuition fee for students at Centennial College. 
             * Fees is depends on the number of courses taken and the residency status of 
             * the student and it calculated according the to the table below:
             * Residency    Number of courses       Price
             * Domestic     Less than 4 courses     $425.00 per course
             *                                      $350.00 per course
             * Foreign      Less than 4 courses     $1225.00 per course
             *                                      $1175.00 per course
             * The program should prompt the user to indicate if she is a domestic student or not. 
             * An input of Y or y would indicate domestic (any other input can be consider foreign). 
             * The program should then prompt the use for the number of course that she is taking. 
             * Based on the above table the program will print her tuition cost. [Hint use the 
             * statement .ToUpper() or .ToLower() to transform the input to upper case or lower 
             * case string] */

            string userAnswer;
            int howManyClasses;

            Console.WriteLine("Are you a domestic student (Y/N)?");
            userAnswer = Console.ReadLine().ToUpper();

            if (userAnswer == "Y")
            {
                Console.WriteLine("How many classes are you taking?");
                howManyClasses = Convert.ToInt32(Console.ReadLine());

                if (howManyClasses < 5)
                {
                    Console.WriteLine("$350.00");
                }
                else
                {
                    Console.WriteLine("$425.00");
                }
            }
            else
            {
                Console.WriteLine("How many classes are you taking?");
                howManyClasses = Convert.ToInt32(Console.ReadLine());

                if (howManyClasses < 5)
                {
                    Console.WriteLine("$1175.00");
                }
                else
                {
                    Console.WriteLine("$1225.00");
                }
            }
        }
    }
}
