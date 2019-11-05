using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - COMP100-005

            /* Gerard-The Plumber bills customers by the length of a job as well as the 
             * number of joins that is needed. Write a program that prompts the user 
             * for the length of the job, the number of joins and the unit price per 
             * length and joins. The program calculates and displays the total cost 
             * of the job. */

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
