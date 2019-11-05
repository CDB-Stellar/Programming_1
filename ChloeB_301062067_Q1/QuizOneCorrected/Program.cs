using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOneCorrected
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double userInputPounds;
            double userInputOunces;
            int poundsToKilograms;
            double ouncesToGrams;

            Console.WriteLine("Please enter weight in pounds and ounces.");
            Console.Write("Pounds? ");
            userInput = Console.ReadLine();
            userInputPounds = Convert.ToDouble(userInput);
            Console.Write("Ounces? ");
            userInput = Console.ReadLine();
            userInputOunces = Convert.ToDouble(userInput);

            ouncesToGrams = (userInputPounds * 16 + userInputOunces) * 453.592 / 16;
            poundsToKilograms = (int)(ouncesToGrams / 1000);   //(int) is a cast
            //poundsToKilograms = (ouncesToGrams - ouncesToGrams % 1000) / 1000;   to use this line instead of the pervious one, kilos must be double
            ouncesToGrams = ouncesToGrams % 1000;

            Console.WriteLine($"{userInputPounds}lb {userInputOunces}oz is {poundsToKilograms}kg {ouncesToGrams}g");
        }
    }
}
