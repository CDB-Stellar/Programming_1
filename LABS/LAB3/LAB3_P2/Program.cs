using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a program to display “Pass” or “Fail” depending on the user input. 
             * The program prompts for a score (whichmay contain a decimal point), if 
             * the score is more than 70 then the output should be “Pass” otherwise the 
             * output should be “Fail”. */

            double grade;

            Console.WriteLine("Please enter your grade: ");
            grade = Convert.ToDouble(Console.ReadLine());

            if (grade >= 70)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
