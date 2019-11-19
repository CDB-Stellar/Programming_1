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

            /* Create a game similar to Hangman named GuessAWord in which a player guesses letters to 
             * try to replicate a hidden word. Store at least eight words in an array, and randomly 
             * select one to be the hidden word. Initially, display the hidden word using asterisks to 
             * represent each letter. Allow the user to guess letters to replace the asterisks in the 
             * hidden word until the user completes the entire word. If the user guesses a letter that 
             * is not in the hidden word, display an appropriate message. If the user guesses a letter 
             * that appears multiple times in the hidden word, make sure that each correct letter is 
             * placed. */

            string[] words = new string[8] {"below", "heart", "snowing", "balloon", "canine", "trudge", "precarious", "amazing"};
            char userGuess;
            string hiddenWord = "";
            Random ranNumGenerator = new Random();
            int randomNum;
            randomNum = ranNumGenerator.Next(0, words.Length - 1);
            string randomWord = words[randomNum];

            // Initializing hiddenWord as all asterisks
            for (int x = 0; x < randomWord.Length; ++x)
            {
                hiddenWord += "*";
            }

            while (hiddenWord != randomWord)
            {
                Console.WriteLine($"Word: {hiddenWord}");
                Console.WriteLine($"Guess a letter >> ");
                userGuess = Convert.ToChar(Console.ReadLine());

                for (int i = 0; i < randomWord.Length; ++i)
                {
                    if (userGuess == randomWord[i])
                    {
                        hiddenWord += userGuess;
                    }

                    else
                    {
                        hiddenWord += "*";
                    }
                }
                hiddenWord = "";
            }

            // This is definitely not right
        }
    }
}
