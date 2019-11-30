﻿using System;
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

            /* Character Palindromes: "radar" "civic" "1drd1" Number Palindromes: "12321" "1221221"
             * [25 points] Write a console application that reads a word and display if it is number 
             * palindrome, character palindrome, or not a palindrome at all. The application should
             * ask for a new word until user enters word “end”. Before exiting application, print
             * out the list of all palindrome words that user has input.
             * [60 points] Make the code more readable and non-repetitive by use of the methods.
             * Your application should have at least one method that is called IsPalindrome that
             * returns true if the provided argument is a palindrome. */

            char[] comparisonNumbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] palindromes = { "Initializer" };

            AskForInputContinuously(comparisonNumbers, ref palindromes);
            DisplayAllPalindromes(palindromes);
        }

        static void AskForInputContinuously(char[] comparisonNumbers, ref string[] palindromes)
        {
            string userInput;

            do
            {
                Console.WriteLine("___________________________________________");
                Console.WriteLine("Enter a phrase to check (or \"end\" to exit): ");
                userInput = Console.ReadLine();

                if (userInput.ToUpper() != "END")
                {
                    if (IsPalindrome(userInput))
                    {
                        AddInputToArray(ref palindromes, userInput);
                        DisplayKindOfPalindrome(userInput, comparisonNumbers);
                    }
                    else
                        Console.WriteLine("This is not a palindrome.");
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

        static void AddInputToArray(ref string[] palindromes, string userInput)
        {
            Array.Resize(ref palindromes, palindromes.Length + 1);
            palindromes[palindromes.Length - 1] = userInput;
        }

        static void DisplayKindOfPalindrome(string userInput, char[] comparisonNumbers)
        {
            if (IsNumberPalindrome(comparisonNumbers, userInput))
                Console.WriteLine("This is a number palindrome.");
            else
                Console.WriteLine("This is a character palindrome.");
        }

        static bool IsNumberPalindrome(char[] comparisonNumbers, string characters)
        {
            bool[] flags = new bool[characters.Length];
            bool IsNumberPalindrome = true;

            for (int i = 0; i < characters.Length; ++i)
            {
                for (int x = 0; x < comparisonNumbers.Length; ++x)
                {
                    if (characters[i] == comparisonNumbers[x])
                        flags[i] = true;
                }
            }

            for (int i = 0; i < flags.Length; ++i)
            {
                if (flags[i] == false)
                    IsNumberPalindrome = false;
            }

            return IsNumberPalindrome;
        }

        static void DisplayAllPalindromes(string[] palindromes)
        {
            if (palindromes.Length > 1)
            {
                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("Here are all the palindromes you entered: ");
                for (int i = 1; i < palindromes.Length; ++i)
                {
                    if (i != palindromes.Length - 1)
                        Console.Write($"{palindromes[i]}, ");
                    else
                        Console.WriteLine(palindromes[i]);
                }
            }
        }
    }
}