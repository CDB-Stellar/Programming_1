using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Montgomery Entertainment Corp. is looking into the profitability of hosting 
             * MMA XXII at the Rogers Center. Write a program that will calculate and 
             * display the profit that will result from hosting such as event. The program 
             * will calculate the income (you must prompt for each of the following) from 
             * the sale of tickets, broadcasting rights and advertising and subtract the 
             * cost of renting the Center. */

            int ticketPrice;
            int broadcastingRights;
            int advertising;
            int rentCost;
            int totalProfit;

            Console.WriteLine("This program will calculate the total profit of hosting MMA XXII at the Rogers Center.");

            Console.Write("Please enter the ticket price: $");
            ticketPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the broadcasting rights income: $");
            broadcastingRights = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the advertising income: $");
            advertising = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the rent cost: $");
            rentCost = Convert.ToInt32(Console.ReadLine());

            totalProfit = ticketPrice + broadcastingRights + advertising - rentCost;

            Console.WriteLine($"The total profit of hosting the event is ${totalProfit}.");
        }
    }
}
