using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBoarding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Corrected Version

            double dogWeight;
            int numberOfDaysBoarded;
            const double DOLLARS_PER_POUND_PER_DAY = 0.5;

            Console.WriteLine("Please enter the dog's weight in pounds:");
            dogWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the amount of days to be boarded:");
            numberOfDaysBoarded = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nThe total price of boarding the dog is {dogWeight * numberOfDaysBoarded * DOLLARS_PER_POUND_PER_DAY:c}.");
        }
    }
}
