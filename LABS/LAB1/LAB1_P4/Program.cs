using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Narendra Airlines would like a program that will calculate and display 
             * the cost of flying an aircraft betweenvarious locations. Write a 
             * program that will compute the cost which is based on the fuel efficiency 
             * (amount of fuel used for each km travelled) of the aircraft, the unit 
             * price of fuel and the length of the journey. */

            int fuelPerKilometer;
            int fuelPrice;
            int journeyLength;
            int totalPriceOfFlying;

            Console.WriteLine("This program will calculate the cost of flying aircraft.");

            Console.Write("Please enter how much fuel is used per km: ");
            fuelPerKilometer = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the price of fuel: $");
            fuelPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the length of the journey in km: ");
            journeyLength = Convert.ToInt32(Console.ReadLine());

            totalPriceOfFlying = fuelPerKilometer * fuelPrice * journeyLength;

            Console.WriteLine($"The cost of flying the aircraft is ${totalPriceOfFlying}.");
        }
    }
}
