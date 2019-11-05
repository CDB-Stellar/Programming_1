using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* To the Lawn application you created in question 8, add a prompt 
             * that asks the user whether the customer wants to pay (1) once, 
             * (2) twice, or (3) 20 times per season. If the user enters 1 for 
             * once, the fee for the season is simply the seasonal total. If the 
             * customer requests two payments, each payment is half the seasonal 
             * fee plus a $5 service charge. If the user requests 20 separate 
             * payments, add a $3 service charge per week. Display the number of 
             * payments the customer must make, each payment amount, and the 
             * total for the season. */

            const int WEEKS_IN_SEASON = 20;
            const int WEEKLY_FEE_UNDER_400SF = 25;
            const int WEEKLY_FEE_UNDER_600SF = 35;
            const int WEEKLY_FEE_OVER_600SF = 50;
            const int LAWN_SIZE1 = 400;
            const int LAWN_SIZE2 = 600;
            const int TWO_PAYMENT_SERVICE_CHARGE = 5;
            const int TWENTY_PAYMENT_SERVICE_CHARGE = 3;
            double lengthOfLawn;
            double widthOfLawn;
            double totalFee;
            int numberOfPayments;

            Console.WriteLine("Please enter the length and width of the lawn below:");
            Console.Write("Length in square feet: ");
            lengthOfLawn = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width in square feet: ");
            widthOfLawn = Convert.ToDouble(Console.ReadLine());
            Console.Write("Would you like to pay once(1), twice(2), or 20 separate payments(3)? ");
            numberOfPayments = Convert.ToInt32(Console.ReadLine());

            if (numberOfPayments == 1)
            {
                if ((lengthOfLawn * widthOfLawn) < LAWN_SIZE1)
                {
                    totalFee = WEEKS_IN_SEASON * WEEKLY_FEE_UNDER_400SF;
                    Console.WriteLine($"Weekly Mowing Fee: {WEEKLY_FEE_UNDER_400SF:c} \nTotal Season Fee: {totalFee:c}");
                }
                else if ((lengthOfLawn * widthOfLawn) >= LAWN_SIZE1 && (lengthOfLawn * widthOfLawn) < LAWN_SIZE2)
                {
                    totalFee = WEEKS_IN_SEASON * WEEKLY_FEE_UNDER_600SF;
                    Console.WriteLine($"Weekly Mowing Fee: {WEEKLY_FEE_UNDER_600SF:c} \nTotal Season Fee: {totalFee:c}");
                }
                else
                {
                    totalFee = WEEKS_IN_SEASON * WEEKLY_FEE_OVER_600SF;
                    Console.WriteLine($"Weekly Mowing Fee: {WEEKLY_FEE_OVER_600SF:c} \nTotal Season Fee: {totalFee:c}");
                }
            }
            else if (numberOfPayments == 2)
            {
                if ((lengthOfLawn * widthOfLawn) < LAWN_SIZE1)
                {
                    totalFee = (WEEKS_IN_SEASON * WEEKLY_FEE_UNDER_400SF) + (2 * TWO_PAYMENT_SERVICE_CHARGE);
                    Console.WriteLine($"Weekly Mowing Fee: {WEEKLY_FEE_UNDER_400SF:c}");
                    Console.WriteLine($"First Payment (+ $5.00 service charge): {totalFee / 2:c}");
                    Console.WriteLine($"Second Payment (+ $5.00 service charge): {totalFee / 2:c}");
                    Console.WriteLine($"Total Payment: {totalFee:c}");
                }
                else if ((lengthOfLawn * widthOfLawn) >= LAWN_SIZE1 && (lengthOfLawn * widthOfLawn) < LAWN_SIZE2)
                {
                    totalFee = (WEEKS_IN_SEASON * WEEKLY_FEE_UNDER_600SF) + (2 * TWO_PAYMENT_SERVICE_CHARGE);
                    Console.WriteLine($"Weekly Mowing Fee: {WEEKLY_FEE_UNDER_600SF:c}");
                    Console.WriteLine($"First Payment (+ $5.00 service charge): {totalFee / 2:c}");
                    Console.WriteLine($"Second Payment (+ $5.00 service charge): {totalFee / 2:c}");
                    Console.WriteLine($"Total Payment: {totalFee:c}");
                }
                else
                {
                    totalFee = (WEEKS_IN_SEASON * WEEKLY_FEE_OVER_600SF) + (2 * TWO_PAYMENT_SERVICE_CHARGE);
                    Console.WriteLine($"Weekly Mowing Fee: {WEEKLY_FEE_OVER_600SF:c}");
                    Console.WriteLine($"First Payment (+ $5.00 service charge): {totalFee / 2:c}");
                    Console.WriteLine($"Second Payment (+ $5.00 service charge): {totalFee / 2:c}");
                    Console.WriteLine($"Total Payment: {totalFee:c}");
                }
            }
            else
            {
                if ((lengthOfLawn * widthOfLawn) < LAWN_SIZE1)
                {
                    totalFee = (WEEKS_IN_SEASON * WEEKLY_FEE_UNDER_400SF) + (TWENTY_PAYMENT_SERVICE_CHARGE * WEEKS_IN_SEASON);
                    Console.WriteLine($"Weekly Mowing Fee: {WEEKLY_FEE_UNDER_400SF:c}");
                    Console.WriteLine($"Twenty Separate Payments of (+ $3.00 service charge per week): {totalFee / WEEKS_IN_SEASON:c}");
                    Console.WriteLine($"Total Payment: {totalFee:c}");
                }
                else if ((lengthOfLawn * widthOfLawn) >= LAWN_SIZE1 && (lengthOfLawn * widthOfLawn) < LAWN_SIZE2)
                {
                    totalFee = (WEEKS_IN_SEASON * WEEKLY_FEE_UNDER_600SF) +(TWENTY_PAYMENT_SERVICE_CHARGE * WEEKS_IN_SEASON);
                    Console.WriteLine($"Weekly Mowing Fee: {WEEKLY_FEE_UNDER_600SF:c}");
                    Console.WriteLine($"Twenty Separate Payments of (+ $3.00 service charge per week): {totalFee / WEEKS_IN_SEASON:c}");
                    Console.WriteLine($"Total Payment: {totalFee:c}");
                }
                else
                {
                    totalFee = (WEEKS_IN_SEASON * WEEKLY_FEE_OVER_600SF) + (TWENTY_PAYMENT_SERVICE_CHARGE * WEEKS_IN_SEASON);
                    Console.WriteLine($"Weekly Mowing Fee: {WEEKLY_FEE_OVER_600SF:c}");
                    Console.WriteLine($"Twenty Separate Payments of (+ $3.00 service charge per week): {totalFee / WEEKS_IN_SEASON:c}");
                    Console.WriteLine($"Total Payment: {totalFee:c}");
                }
            }
        }
    }
}
