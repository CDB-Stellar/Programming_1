using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 26, 2019

            /* (Complete all questions in a single project) 
             * 1. Write a method to display the menu, and call it from the main. 
             * 2. Modify main so that it will keep asking for a choice until user enters 0.
             * 3. Write a method to calculate sum, call it in main when user enters 1.
             * 4. Write a method to calculate sum of squares, call it in main when user enters 2.
             * 5. Write a method to calculate sum of cubes, call it when user enters 3. 
             * 6. Write a method to calculate average, call it when user enters 4. */

            int menuChoice;
            int numberOfNumbers;

            do
            {
                DisplayMenu();
                menuChoice = Convert.ToInt32(Console.ReadLine());

                switch(menuChoice)
                {
                    case 1:
                        Console.Write("\nPlease enter how many numbers you will add together: ");
                        numberOfNumbers = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\nThe sum of the numbers is {CalculateSum(numberOfNumbers)}.\n");
                        break;
                    case 2:
                        Console.Write("\nPlease enter how many numbers you will add together: ");
                        numberOfNumbers = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\nThe sum of the numbers is {CalculateSumOfSquares(numberOfNumbers)}.\n");
                        break;
                    case 3:
                        Console.WriteLine($"\nThe sum of the numbers is {CalculateSumOfCubes()}.\n");
                        break;
                    case 4:
                        Console.WriteLine($"\nThe average of the numbers is {CalculateAverage()}.\n");
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Not a valid menu choice.");
                        break;
                }
            } while (menuChoice != 0);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("_________________________________");
            Console.WriteLine("1) Calculate Sum");
            Console.WriteLine("2) Calculate Sum of Squares");
            Console.WriteLine("3) Calculate Sum of Cubes");
            Console.WriteLine("4) Calculate Average");
            Console.WriteLine("0) To Exit");
            Console.Write("\nEnter the number that corresponds to your choice: ");
        }

        static int CalculateSum(int numberOfNumbers)
        {
            int sum = 0;
            int enteredNumber;

            for (int count = 0; count < numberOfNumbers; ++count)
            {
                Console.Write("Please enter a number to add: ");
                enteredNumber = Convert.ToInt32(Console.ReadLine());
                sum += enteredNumber;
            }

            return sum;
        }

        static int CalculateSumOfSquares(int numberOfNumbers)
        {
            int sumOfSquares = 0;
            int enteredNumber;

            for (int count = 0; count < numberOfNumbers; ++count)
            {
                Console.Write("Please enter a number to add: ");
                enteredNumber = Convert.ToInt32(Console.ReadLine());
                sumOfSquares += enteredNumber * enteredNumber;
            }

            return sumOfSquares;
        }

        static int CalculateSumOfCubes()
        {
            int sumOfCubes = 0;
            int enteredNumber;
            int numberOfNumbers;

            Console.Write("\nPlease enter how many numbers you will add together: ");
            numberOfNumbers = Convert.ToInt32(Console.ReadLine());

            for (int count = 0; count < numberOfNumbers; ++count)
            {
                Console.Write("Please enter a number to add: ");
                enteredNumber = Convert.ToInt32(Console.ReadLine());
                sumOfCubes += enteredNumber * enteredNumber * enteredNumber;
            }

            return sumOfCubes;
        }

        static double CalculateAverage()
        {
            double average;
            int sum = 0;
            int enteredNumber;
            int numberOfNumbers;

            Console.Write("\nPlease enter how many numbers you will average together: ");
            numberOfNumbers = Convert.ToInt32(Console.ReadLine());

            for (int count = 0; count < numberOfNumbers; ++count)
            {
                Console.Write("Please enter a number to add to the average: ");
                enteredNumber = Convert.ToInt32(Console.ReadLine());
                sum += enteredNumber;
            }

            average = sum / numberOfNumbers;

            return average;
        }
    }
}
