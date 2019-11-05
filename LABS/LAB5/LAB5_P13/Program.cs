using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Create a console-based lottery game application. Generate three 
             * random numbers, each between 1 and 4. Allow the user to guess 
             * three numbers. Compare each of the user’s guesses to the three 
             * random numbers and display a message that includes the user’s 
             * guess, the randomly determined three-digit number, and the amount 
             * of money the user has won as follows:
             * Matching Numbers                 Award($)
             * Any one matching                 10
             * Two matching                     100
             * Three matching, not in order     1,000
             * Three matching, in order         10,000
             * No matches                       0 
             * Make certain that your application accommodates repeating digits. For 
             * example, if a user guesses 1, 2, and 3, and the randomly generated 
             * digits are 1, 1, and 1, do not give the user credit for three correct 
             * guesses—just one. */

            int randomNumber1;
            int randomNumber2;
            int randomNumber3;
            int userGuess1;
            int userGuess2;
            int userGuess3;
            int allCorrectMarker = 0;

            Random ranNumberGenerator = new Random();
            randomNumber1 = ranNumberGenerator.Next(1, 4);
            randomNumber2 = ranNumberGenerator.Next(1, 4);
            randomNumber3 = ranNumberGenerator.Next(1, 4);

            Console.WriteLine("Three random numbers between 1 and 3 have been generated, try to guess them:");
            Console.Write("Guess the first number:");
            userGuess1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Guess the second number:");
            userGuess2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Guess the third number:");
            userGuess3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nThe random number was: {randomNumber1}{randomNumber2}{randomNumber3}");

            //Determining how many matches
            if (userGuess1 == randomNumber1 && userGuess2 == randomNumber2 && userGuess3 == randomNumber3)
            {
                randomNumber1 = 0;
                randomNumber2 = 0;
                randomNumber3 = 0;
                allCorrectMarker = 1;
            }
            if (randomNumber1 == userGuess1 || randomNumber1 == userGuess2 || randomNumber1 == userGuess3)
            {
                if (randomNumber1 == userGuess1)
                {
                    randomNumber1 = 0;
                    userGuess1 = 0;
                }
                if (randomNumber1 == userGuess2)
                {
                    randomNumber1 = 0;
                    userGuess2 = 0;
                }
                if (randomNumber1 == userGuess3)
                {
                    randomNumber1 = 0;
                    userGuess3 = 0;
                }
                if (randomNumber2 == userGuess1 || randomNumber2 == userGuess2 || randomNumber2 == userGuess3)
                {
                    if (randomNumber2 == userGuess1)
                    {
                        randomNumber2 = 0;
                        userGuess1 = 0;
                    }
                    if (randomNumber2 == userGuess2)
                    {
                        randomNumber2 = 0;
                        userGuess2 = 0;
                    }
                    if (randomNumber2 == userGuess3)
                    {
                        randomNumber2 = 0;
                        userGuess3 = 0;
                    }
                    if (randomNumber3 == userGuess1 || randomNumber3 == userGuess2 || randomNumber3 == userGuess3)
                    {
                        if (randomNumber3 == userGuess1)
                        {
                            randomNumber3 = 0;
                            userGuess1 = 0;
                        }
                        if (randomNumber3 == userGuess2)
                        {
                            randomNumber3 = 0;
                            userGuess2 = 0;
                        }
                        if (randomNumber3 == userGuess3)
                        {
                            randomNumber3 = 0;
                            userGuess3 = 0;
                        }
                    }
                }
            }
            if (randomNumber2 == userGuess1 || randomNumber2 == userGuess2 || randomNumber2 == userGuess3)
            {
                if (randomNumber2 == userGuess1)
                {
                    randomNumber2 = 0;
                    userGuess1 = 0;
                }
                if (randomNumber2 == userGuess2)
                {
                    randomNumber2 = 0;
                    userGuess2 = 0;
                }
                if (randomNumber2 == userGuess3)
                {
                    randomNumber2 = 0;
                    userGuess3 = 0;
                }
                if (randomNumber3 == userGuess1 || randomNumber3 == userGuess2 || randomNumber3 == userGuess3)
                {
                    if (randomNumber3 == userGuess1)
                    {
                        randomNumber3 = 0;
                        userGuess1 = 0;
                    }
                    if (randomNumber3 == userGuess2)
                    {
                        randomNumber3 = 0;
                        userGuess2 = 0;
                    }
                    if (randomNumber3 == userGuess3)
                    {
                        randomNumber3 = 0;
                        userGuess3 = 0;
                    }
                }
            }
            if (randomNumber3 == userGuess1 || randomNumber3 == userGuess2 || randomNumber3 == userGuess3)
            {
                if (randomNumber3 == userGuess1)
                {
                    randomNumber3 = 0;
                    userGuess1 = 0;
                }
                if (randomNumber3 == userGuess2)
                {
                    randomNumber3 = 0;
                    userGuess2 = 0;
                }
                if (randomNumber3 == userGuess3)
                {
                    randomNumber3 = 0;
                    userGuess3 = 0;
                }
            }
            
            //Console.WriteLine($"{userGuess1}{userGuess2}{userGuess3}"); [for testing]

            //In case of one match
            if (randomNumber1 == 0 && randomNumber2 != 0 && randomNumber3 != 0)
            {
                Console.WriteLine("You got one match. You win $10.00");
            }
            if (randomNumber2 == 0 && randomNumber1 != 0 && randomNumber3 != 0)
            {
                Console.WriteLine("You got one match. You win $10.00");
            }
            if (randomNumber3 == 0 && randomNumber1 != 0 && randomNumber2 != 0)
            {
                Console.WriteLine("You got one match. You win $10.00");
            }

            //In case of two matches
            if (randomNumber1 == 0 && randomNumber2 == 0 && randomNumber3 != 0)
            {
                Console.WriteLine("You got two matches. You win $100.00");
            }
            if (randomNumber2 == 0 && randomNumber3 == 0 && randomNumber1 != 0)
            {
                Console.WriteLine("You got two matches. You win $100.00");
            }
            if (randomNumber1 == 0 && randomNumber3 == 0 && randomNumber2 != 0)
            {
                Console.WriteLine("You got two matches. You win $100.00");
            }

            //In case of three matches, not in order
            if (randomNumber1 == 0 && randomNumber2 == 0 && randomNumber3 == 0 && allCorrectMarker == 0)
            {
                Console.WriteLine("You got three matches. You win $1,000.00");
            }

            //In case of three matches, in order
            if (randomNumber1 == 0 && randomNumber2 == 0 && randomNumber3 == 0 && allCorrectMarker == 1)
            {
                Console.WriteLine("You matched the number exactly! You win $10,000.00");
            }

            //In case of no matches
            if (randomNumber1 != 0 && randomNumber2 != 0 && randomNumber3 != 0)
            {
                Console.WriteLine("You got no matches.");
            }
        }
    }
}
