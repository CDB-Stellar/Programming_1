using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double userInputPounds;
            double userInputOunces;
            double poundsToKilograms;
            double ouncesToGrams;

            Console.WriteLine("Please enter weight in pounds and ounces.");
            Console.Write("Pounds? ");
            userInput = Console.ReadLine();
            userInputPounds = Convert.ToDouble(userInput);
            Console.Write("Ounces? ");
            userInput = Console.ReadLine();
            userInputOunces = Convert.ToDouble(userInput);

            poundsToKilograms = userInputPounds * 443.592 / 1000;
            ouncesToGrams = (userInputOunces / 16) * 443.592;

            Console.WriteLine($"{userInputPounds}lb {userInputOunces}oz is {poundsToKilograms}kg {ouncesToGrams}g");
        }
    }
}
