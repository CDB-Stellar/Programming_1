using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - November 10, 2019

            /* a) Modify the program written for LAB8_13 to initially prompt the user for the amount of money initially 
             * deposited in the account. 
             * b) Modify the program written for LAB8_13 to initially prompt the user for both the amount of money initially 
             * deposited and the number of years that should be displayed. 
             * c) Modify the program written for LAB8_13 to initially prompt for the amount of money initially deposited, 
             * the interest rate to be used, and the number of years to be displayed. */

            const int AMOUNT_DEPOSITED_YEARLY = 1000;
            double startingAmount;
            int years;
            double interestRate;
            
            Console.Write("Enter the initial amount of money in the account: $");
            startingAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter how many years to show: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the interest rate: ");
            interestRate = Convert.ToDouble(Console.ReadLine());

            double bankTotal = startingAmount;

            Console.WriteLine($"\n{"",-8}{"Interest",-10}{"Account",-20}");
            Console.WriteLine($"{"Year",-8}{"Rate (%)",-10}{"Total",-20}");
            Console.WriteLine("________________________________");

            for (int count = 1; count <= years; ++count)
            {
                bankTotal += (interestRate / 10) * bankTotal;
                Console.WriteLine($"{count,-8}{interestRate,-10}{bankTotal,-20:c}");
                bankTotal += AMOUNT_DEPOSITED_YEARLY;
            }
        }
    }
}
