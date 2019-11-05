using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* You can create a random number that is at least min but less 
             * than max using the following statements:
             * Random ranNumberGenerator = new Random();
             * int randomNumber;
             * randomNumber = ranNumberGenerator.Next(min, max);
             * Write a console-based program that generates a random number 
             * between 1 and 10. (In other words, min is 1 and max is 11.) 
             * Ask a user to guess the random number, then display the random 
             * number and a message indicating whether the user’s guess was 
             * too high, too low, or correct. */

            Random ranNumberGenerator = new Random();
            int randomNumber;
            int userGuess;

            randomNumber = ranNumberGenerator.Next(1, 11);

            Console.WriteLine("A random number between 1 and 10 has been generated. Guess what it is:");
            userGuess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number was {randomNumber}.");

            if (userGuess == randomNumber)
            {
                Console.WriteLine($"You guessed {userGuess}, correct!");
            }
            else if (userGuess < randomNumber)
            {
                Console.WriteLine($"You guessed {userGuess}, too low.");
            }
            else
            {
                Console.WriteLine($"You guessed {userGuess}, too high.");
            }
        }
    }
}
