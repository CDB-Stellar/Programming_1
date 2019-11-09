using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 8, 2019

            /* Print the decimal, octal, and hexadecimal values of all characters between the start 
             * and stop characters entered by a user. For example, if the user enters an 'a' and a 'z', 
             * the program should print all the characters between a - z and their respective numerical 
             * values. Make sure that the second character entered by the user occurs later in the 
             * alphabet than the first character. If it does not, write a loop that repeatedly asks the 
             * user for a valid second character until one is entered.
             * Your output should be formatted as shown below:
             * Letter       Decimal  Octal    Hex
             * a            97       141      61
             * b            98       142      62
             * c            99       143      63
             * d            100      144      64
             * e            101      145      65  */

            char firstChar = 'z';
            char lastChar = 'a';

            while (firstChar > lastChar)
            {
                Console.WriteLine("Enter the range of characters to display below:");
                Console.Write("First character: ");
                firstChar = Convert.ToChar(Console.ReadLine());
                Console.Write("Last character: ");
                lastChar = Convert.ToChar(Console.ReadLine());

                if (firstChar > lastChar)
                {
                    Console.WriteLine("\nThe last character must come after the first character, please enter something different.\n");
                }
            }

            Console.WriteLine($"\n{"Letter",-13}{"Decimal",-9}{"Octal",-9}{"Hex"}");

            for (char currentChar = firstChar; currentChar <= lastChar; ++currentChar)
            {
                Console.WriteLine($"{currentChar,-13}{Convert.ToInt32(currentChar),-9}{Convert.ToString(currentChar,8),-9}{Convert.ToString(currentChar,16),-9}");
            }
        }
    }
}
