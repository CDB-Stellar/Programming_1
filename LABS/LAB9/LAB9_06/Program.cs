using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 18, 2019

            /* Write a console app that ask user to input the phrase. Create and then display array that 
             * will contain the numbers of each letter in alphabet in the phrase. The letter frequencies 
             * are displayed from highest to lowest. (Use parrallel arrays, and write your own sort) */

            int[] numberOfLetters = new int[26];
            int[] letters = new int[26];
            string phrase;
            int temporary;
            bool done = false;

            for (int i = 0; i < letters.Length; ++i)
            {
                letters[i] = (char)('a' + i);
            }

            Console.WriteLine("Please enter any phrase below:");
            phrase = Console.ReadLine();

            Console.WriteLine("\nHere are the number of letters in that phrase:");

            for (int i = 0; i < letters.Length; ++i)
            {
                for (int x = 0; x < phrase.Length; ++x)
                {
                    if (phrase[x] == letters[i])
                    {
                        ++numberOfLetters[i];

                    }
                }
                Console.Write($"\n'{(char)letters[i]}'s: {numberOfLetters[i]}");
            }
            Console.WriteLine();

            // Sorting
            while (done == false)
            {
                for (int i = 0; i < numberOfLetters.Length; ++i)
                {
                    if (numberOfLetters[i] < numberOfLetters[0])
                    {
                        done = true;
                    }
                }
            }

            // you have to write your own sort



            // first part of the problem
            //int[] letters = new int[26];
            //int[] numberOfLetters = new int[26];
            //string phrase;

            //Console.WriteLine("Please enter any phrase below:");
            //phrase = Console.ReadLine();

            //Console.WriteLine("\nHere are the number of letters in that phrase:");

            //for (int i = 0; i < numberOfLetters.Length; ++i)
            //{
            //    letters[i] = 'a' + i;

            //    for (int x = 0; x < phrase.Length; ++x)
            //    {
            //        if (phrase[x] == letters[i])
            //        {
            //            ++numberOfLetters[i];
            //        }
            //    }
            //    Console.Write($"\n'{(char)letters[i]}'s: {numberOfLetters[i]}");
            //}
            //Console.WriteLine();
        }
    }
}
