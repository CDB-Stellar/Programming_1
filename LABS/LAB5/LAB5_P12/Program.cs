using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* In the game Rock Paper Scissors, two players simultaneously choose 
             * one of three options: rock, paper, or scissors. If both players 
             * choose the same option, then the result is a tie. However, if they 
             * choose differently, the winner is determined as follows:
             * - Rock beats scissors, because a rock can break a pair of scissors.
             * - Scissors beats paper, because scissors can cut paper.
             * - Paper beats rock, because a piece of paper can cover a rock. 
             * Create a console-based game in which the computer randomly chooses 
             * rock, paper, or scissors. Let the user enter a character, ‘r’, ‘p’, 
             * or ‘s’, each representing one of the three choices. Then, determine 
             * the winner. */

            char userChoice;
            int randomNumber;
            char computerChoice;

            Random ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    computerChoice = 'r';
                    break;
                case 2:
                    computerChoice = 'p';
                    break;
                default:
                    computerChoice = 's';
                    break;
            }

            Console.WriteLine("Let's play rock, paper, scissors.");
            Console.WriteLine("The computer has chosen. What is your choice? ('r', 'p', 's')");
            userChoice = Convert.ToChar(Console.ReadLine());

            if (userChoice == computerChoice)
            {
                Console.WriteLine($"Computer chose: {computerChoice} \nYou chose: {userChoice} \nit's a tie.");
            }
            else if (userChoice == 'r' && computerChoice == 's')
            {
                Console.WriteLine($"Computer chose: {computerChoice} \nYou chose: {userChoice} \nYou win!");
            }
            else if (userChoice == 's' && computerChoice == 'p')
            {
                Console.WriteLine($"Computer chose: {computerChoice} \nYou chose: {userChoice} \nYou win!");
            }
            else if (userChoice == 'p' && computerChoice == 'r')
            {
                Console.WriteLine($"Computer chose: {computerChoice} \nYou chose: {userChoice} \nYou win!");
            }
            else
            {
                Console.WriteLine($"Computer chose: {computerChoice} \nYou chose: {userChoice} \nYou lose.");
            }
        }
    }
}
