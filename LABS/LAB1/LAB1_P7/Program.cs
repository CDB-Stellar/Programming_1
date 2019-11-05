using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_P7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Quincy “The Plumber” bills customer for pipe installation based on the 
             * length as well as the number of joins of the job. Build a program that 
             * will prompt for length rate, join rate, the length, the number of join 
             * and calculate and display the total cost. 
             * [cost = (length * lengthRate) + (numberOfJoins * joinRate)] */

            double jobLength;
            double pricePerHour;
            double numberOfJoins;
            double costOfJoin;
            double totalCostOfJob;

            Console.WriteLine("This program will calculate the total cost of the job.\n");

            Console.Write("Please enter the length of the job in hours: ");
            jobLength = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the price per hour of work: $");
            pricePerHour = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the number of joins used: ");
            numberOfJoins = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the cost of one join: $");
            costOfJoin = Convert.ToDouble(Console.ReadLine());

            totalCostOfJob = ((int)jobLength * pricePerHour) + (numberOfJoins * costOfJoin);

            Console.WriteLine($"\nThe total cost of the job is {totalCostOfJob:c}.");
        }
    }
}
