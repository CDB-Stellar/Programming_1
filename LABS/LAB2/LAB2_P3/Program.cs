using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* When Jacob Steinberg began his trip to California, he filled his 
             * car’s tank with gas and reset his trip meter to zero. After 
             * traveling some distance (324 miles), Jacob stopped at a gas 
             * station to refuel; the gas tank required fuel (17 gallon). 
             * Create a program that Jacob can use to display his car gas 
             * mileage – the number of miles his car can be driven per gallon 
             * of gas. */

            double distance;
            double fuel;

            Console.WriteLine("Please enter the distance you traveled and the amount of fuel used below.");
            Console.Write("Distance in miles: ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fuel in gallons: ");
            fuel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Your gas mileage is {distance / fuel:f2} miles per gallon.");
        }
    }
}
