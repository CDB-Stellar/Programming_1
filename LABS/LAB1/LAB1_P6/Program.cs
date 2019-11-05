using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_P6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Parker would like to get each of the females in his family the same gift 
             * for the holidays. He has an amount of money which he is willing to use 
             * up completely. Write a program that will prompt him for the price of the 
             * item and the amount of money that he has and then calculate and display 
             * the most items that he can buy and the left-over money. (There are 2 
             * outputs for this question) */

            double giftPrice;
            double totalMoneyToSpend;

            Console.Write("Please enter the amount of money you're willing to spend: $");
            totalMoneyToSpend = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the price of the gift: $");
            giftPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"You can buy {(int)(totalMoneyToSpend / giftPrice)} gifts with {totalMoneyToSpend:c}.");
            Console.WriteLine($"You will have {totalMoneyToSpend - (((int)(totalMoneyToSpend / giftPrice)) * giftPrice):c} left over.");
        }
    }
}
