using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* 1.(25 points) Prompt a user to input minimum and maximum number. 
             * a) A minimum number must be a positive number. Keep asking a user until the positive number is provided.
             * b) A maximum number must be greater thanthe minimum number. Keep asking user until the correct number is provided.
             * c) Generate a random number between provided minimum and maximum number. (for instance, if the user inputs 1 and 10 for minimum and 
             * maximum number, the number that can be generated is any number between 1 and 10 inclusive)
             * 2.(40 points) Keep asking a user to guess the random number until the number is guest correctly. For each try that is not correct 
             * display a message indicating whether the user’s guess was too high, too low. If the number is correct,display the message that the 
             * number is correct and the number of trays the user made before correctly guessing the random number.
             * 3.(20 points) On each try the player is criticized for making a “dumb” guess. For example, if the player guesses that the random number 
             * is 4 and is told that the guess is too low, and then the player subsequently makes a guess lower than 4, display a message that the 
             * user should have known not to make such a low guess. */

            int randomNumber;
            int min;
            int max;
            int userGuess;
            int tries = 0;
            int lastGuess = 0;

            Console.WriteLine("Please enter the minimum and maximum number below:\n");

            do
            {
                Console.Write("Minimum: ");
                min = Convert.ToInt32(Console.ReadLine());

                if (min < 0)
                {
                    Console.WriteLine("The minimum number must be positive, enter another number.");
                }
            } while (min < 0);

            do
            {
                Console.Write("Maximum: ");
                max = Convert.ToInt32(Console.ReadLine());

                if (min > max)
                {
                    Console.WriteLine("The maximum must be greater than the minimum, enter another number.");
                }
            } while (min > max);

            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(min, max);

            Console.WriteLine($"\nA random number has been generated between {min} and {max} inclusive. Now try to guess what it is.\n");

            do
            {
                Console.Write("Guess the number: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                ++tries;

                if (userGuess < randomNumber)
                {
                    if (userGuess <= lastGuess && lastGuess < randomNumber && tries > 1)
                    {
                        Console.WriteLine("\nYou were told the last number was too low, you should have known better...");
                    }

                    else
                    {
                        Console.WriteLine("\nToo low, try again.");
                    }

                    lastGuess = userGuess;
                }

                else if (userGuess > randomNumber)
                {
                    if (userGuess >= lastGuess && lastGuess > randomNumber && tries > 1)
                    {
                        Console.WriteLine("\nYou were told the last number was too high, you should have known better...");
                    }

                    else
                    {
                        Console.WriteLine("\nToo high, try again.");
                    }
                    
                    lastGuess = userGuess;
                }

                else
                {
                    if (tries == 1)
                    {
                        Console.WriteLine($"\nCongratulations, you got it right on your first try!.");
                    }

                    else
                    {
                        Console.WriteLine($"\nCongratulations, you got it right! It took you {tries} tries.");
                    }
                }
            } while (userGuess != randomNumber);
        }
    }
}
