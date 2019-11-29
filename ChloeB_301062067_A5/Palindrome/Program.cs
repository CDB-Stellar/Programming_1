using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 30, 2019

            /* Character Palindrome: "radar" "civic" "1drd1"    Number Palindrome: "12321" "1221221"
             * [25 points] Write a console application that reads a word and display if it is number palindrome, 
             * character palindrome, or not a palindrome at all. The application should ask for a new word 
             * until user enters word “end”.  Before exiting application, print out the list of all palindrome 
             * words that user has input. 
             * [60 points] Make the code more readable and non-repetitive by use of the methods. Your application 
             * should have at least one method that is called IsPalindrome that returns true if the provided 
             * argument is a palindrome. */

            string[] palindromes;
            string userInput;

            do
            {
                Console.Write("Enter a phrase to check: ");
                userInput = Convert.ToString(Console.ReadLine());

                if (userInput.ToUpper() != "END")
                {
                    if (IsPalindrome(userInput) == true)
                    {
                        palindromes = new string[userInput];
                        Console.WriteLine("It is a palindrome.");
                    }
                    else
                        Console.WriteLine("It is not a palindrome.");
                }
            } while (userInput.ToUpper() != "END");
        }

        static bool IsPalindrome(string characters)
        {
            bool isPalindrome = true;
            int countForward = 0;
            
            for (int countBackward = characters.Length - 1; countBackward >= 0; --countBackward)
            {
                if (characters[countForward] != characters[countBackward])
                    isPalindrome = false;
                ++countForward;
            }

            return isPalindrome;
        }

        //static bool IsPalindrome(int characters)
        //{
        //    bool isPalindrome = true;
        //    int countForward = 0;

        //    for (int countBackward = characters.Length - 1; countBackward >= 0; --countBackward)
        //    {
        //        if (characters[countForward] != characters[countBackward])
        //            isPalindrome = false;
        //        ++countForward;
        //    }

        //    return isPalindrome;
        //}
    }
}
