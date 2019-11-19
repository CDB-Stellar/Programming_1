using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067

            /* Create a game similar to Hangman named GuessAWord in which a player guesses 
             * letters to try to replicate a hidden word. Store at least eight words in an 
             * array, and randomly select one to be the hidden word. Initially, display the 
             * hidden word using asterisks to represent each letter. Allow the user to 
             * guess letters to replace the asterisks in the hidden word until the user 
             * completes the entire word. If the user guesses a letter that is not in the 
             * hidden word, display an appropriate message. If the user guesses a letter 
             * that appears multiple times in the hidden word, make sure that each correct 
             * letter is placed. */

            string[] words = new string[8] {"below", "heart", "snowing", "balloon", "canine", "trudge", "precarious", "amazing"};
            char userGuess;
            bool done = false;
            bool changed = false;
            Random ranNumGenerator = new Random();
            int randomNum;
            randomNum = ranNumGenerator.Next(0, words.Length - 1);
            string wordToGuess = words[randomNum];
            char[] hiddenWord = new char[wordToGuess.Length];

            // Initializing hiddenWord as all asterisks
            for (int currentLetter = 0; currentLetter < wordToGuess.Length; ++currentLetter)
            {
                hiddenWord[currentLetter] = '*';
            }

            while (done == false)
            {
                Console.Write("Word: ");
                for (int currentLetter = 0; currentLetter < wordToGuess.Length; ++currentLetter)
                {
                    Console.Write(hiddenWord[currentLetter]);
                }

                Console.Write($"\nGuess a letter >> ");
                userGuess = Convert.ToChar(Console.ReadLine());

                for (int i = 0; i < wordToGuess.Length; ++i)
                {
                    if (userGuess == wordToGuess[i])
                    {
                        hiddenWord[i] = userGuess;
                        changed = true;
                    }
                }

                if (changed == true)
                {
                    Console.WriteLine($"Yes! {userGuess} is in the word");
                }

                else
                {
                    Console.WriteLine($"Sorry, {userGuess} is not in the word");
                }
                changed = false;

                done = true;
                for (int i = 0; i < wordToGuess.Length; ++i)
                {
                    if (hiddenWord[i] != wordToGuess[i])
                    {
                        done = false;
                    }
                }

                Console.WriteLine("______________________________");
            }

            Console.WriteLine("\nCongratulations! You completed the word!");
        }
    }
}
