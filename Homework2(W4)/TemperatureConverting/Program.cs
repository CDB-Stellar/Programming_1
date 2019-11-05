using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;       //the number in Fahrenheit the user will enter
            float numberToConvert;  //the user input number converted to a float
            float numberInCelsius;  //the user input number converted to celsius

            //Asking the user for a number to convert to celsius.
            Console.WriteLine("Please enter the temperature you wish to convert from Fahrenheit to Celsius.");
            userInput = Console.ReadLine();

            //Converting the user input to a float, and then converting fahrenheit to celsius.
            numberToConvert = Convert.ToSingle(userInput);
            numberInCelsius = (numberToConvert - 32) * 5 / 9;

            //Displaying the converted temperature.
            Console.Write(numberToConvert);
            Console.Write(" degrees Fahrenheit converted to Celsius is: ");
            Console.WriteLine(numberInCelsius);
        }
    }
}
