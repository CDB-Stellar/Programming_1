using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a program to display “Ontario” depending on the user input. 
             * The program should prompt the user to enter the two letter province 
             * code (as a single input). If the user enters “on” in any combination 
             * of uppercase or lowercase letter, the program should display “You live 
             * in Ontario”, otherwise it should display “You do not live in Ontario”. 
             * [Hint use the statement .ToUpper() or .ToLower() to transform the 
             * input to upper case or lower case letters] */

            string provinceCode;

            Console.WriteLine("Please enter your two letter province code:");
            provinceCode = Console.ReadLine();
            provinceCode = provinceCode.ToUpper();

            if (provinceCode == "ON")
            {
                Console.WriteLine("You live in Ontario");
            }
            else
            {
                Console.WriteLine("You do not live in Ontario");
            }
        }
    }
}
