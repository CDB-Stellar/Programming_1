using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Write a program that continuously requests a grade to be entered. If the grade is 
             * less than 0 or greater than 100, your program should print an appropriate message 
             * informing the user that an invalid grade has been entered, else the grade should be 
             * added to a total. When a grade of 999 is entered the program should exit the repetition 
             * loop and compute and display the average of the valid grades entered. */

            const int END_VALUE = 999;
            const int MIN_GRADE = 0;
            const int MAX_GRADE = 100;
            int total = 0;
            int grade = 0;
            int count = 0;

            Console.WriteLine("To end the program, enter a grade of 999");

            while (grade != END_VALUE)
            {
                Console.Write("Enter a grade: ");
                grade = Convert.ToInt32(Console.ReadLine());

                if (grade < MIN_GRADE || grade > MAX_GRADE && grade != END_VALUE)
                {
                    Console.WriteLine("That is an invalid grade, it must be between 0 - 100.");
                }

                else
                {
                    total += grade;
                }

                ++count;
            }
            
            Console.WriteLine($"The average grade is {(total - END_VALUE) / count}");
        }
    }
}
