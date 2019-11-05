using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* a)
             * Write an application for a lawn-mowing service. The lawn-mowing season 
             * lasts 20 weeks. The weekly fee for mowing a lot under 400 square feet 
             * is $25. The fee for a lot that is 400 square feet or more, but under 
             * 600 square feet, is $35 per week. The fee for a lot that is 600 square 
             * feet or over is $50 per week. Prompt the user for the length and width 
             * of a lawn, and then print the weekly mowing fee, as well as the total 
             * fee for the 20-week season. 
             * b)
             * To the Lawn application you created in Exercise 15a, add a prompt that 
             * asks the user whether the customer wants to pay (1) once, (2) twice, 
             * or (3) 20 times per year. If the user enters 1 for once, the fee for 
             * the season is simply the seasonal total. If the customer requests two 
             * payments, each payment is half the seasonal fee plus a $5 service 
             * charge. If the user requests 20 separate payments, add a $3 service 
             * charge per week. Display the number of payments the customer must make, 
             * each payment amount, and the total for the season. */

            const int SEASON_WEEKS = 20;
            const int LAWN_SIZE_400 = 400;
            const int LAWN_SIZE_600 = 600;
            const int SMALL_LAWN_FEE = 25;
            const int MEDIUM_LAWN_FEE = 35;
            const int LARGE_LAWN_FEE = 50;
            const int TWO_PAYMENT_CHARGE = 5;
            const int TWENTY_PAYMENT_CHARGE = 3;
            double lawnLength;
            double lawnWidth;
            double lawnSize;
            int payments;

            Console.WriteLine("Please enter the length and width of the lawn, and how many times you would like to pay below:");
            Console.Write($"{"Length in square feet", -25}: ");
            lawnLength = Convert.ToDouble(Console.ReadLine());
            Console.Write($"{"Width in square feet", -25}: ");
            lawnWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Payment options: \n(1)Pay once \n(2)Pay twice \n(3)Twenty separate payments");
            Console.Write($"{"Payments (1 | 2 | 3)",-25}: ");
            payments = Convert.ToInt32(Console.ReadLine());

            lawnSize = lawnLength * lawnWidth;

            switch (payments)
            {
                case 1:
                    if (lawnSize < LAWN_SIZE_400)
                    {
                        Console.WriteLine($"{"The weekly mowing fee is:",-30} {SMALL_LAWN_FEE,10:c}");
                        Console.WriteLine($"{"The season total is:",-30} {SMALL_LAWN_FEE * SEASON_WEEKS,10:c}");
                    }
                    else if (lawnSize >= LAWN_SIZE_400 && lawnSize < LAWN_SIZE_600)
                    {
                        Console.WriteLine($"{"The weekly mowing fee is:",-30} {MEDIUM_LAWN_FEE,10:c}");
                        Console.WriteLine($"{"The season total is:",-30} {MEDIUM_LAWN_FEE * SEASON_WEEKS,10:c}");
                    }
                    else
                    {
                        Console.WriteLine($"{"The weekly mowing fee is:",-30} {LARGE_LAWN_FEE,10:c}");
                        Console.WriteLine($"{"The season total is:",-30} {LARGE_LAWN_FEE * SEASON_WEEKS,10:c}");
                    }
                    break;
                case 2:
                    if (lawnSize < LAWN_SIZE_400)
                    {
                        Console.WriteLine($"{"The weekly mowing fee is:",-30} {SMALL_LAWN_FEE,10:c}");
                        Console.WriteLine($"{"First payment:",-30} {(SMALL_LAWN_FEE * SEASON_WEEKS) + TWO_PAYMENT_CHARGE,10:c}");
                        Console.WriteLine($"{"Second payment:",-30} {(SMALL_LAWN_FEE * SEASON_WEEKS) + TWO_PAYMENT_CHARGE,10:c}");
                        Console.WriteLine($"{"Total:",-30} {(SMALL_LAWN_FEE * SEASON_WEEKS) + (TWO_PAYMENT_CHARGE * 2),10:c}");
                    }
                    else if (lawnSize >= LAWN_SIZE_400 && lawnSize < LAWN_SIZE_600)
                    {
                        Console.WriteLine($"{"The weekly mowing fee is:",-30} {MEDIUM_LAWN_FEE,10:c}");
                        Console.WriteLine($"{"First payment:",-30} {(MEDIUM_LAWN_FEE * SEASON_WEEKS) + TWO_PAYMENT_CHARGE,10:c}");
                        Console.WriteLine($"{"Second payment:",-30} {(MEDIUM_LAWN_FEE * SEASON_WEEKS) + TWO_PAYMENT_CHARGE,10:c}");
                        Console.WriteLine($"{"Total:",-30} {(MEDIUM_LAWN_FEE * SEASON_WEEKS) + (TWO_PAYMENT_CHARGE * 2),10:c}");
                    }
                    else
                    {
                        Console.WriteLine($"{"The weekly mowing fee is:",-30} {LARGE_LAWN_FEE,10:c}");
                        Console.WriteLine($"{"First payment:",-30} {(LARGE_LAWN_FEE * SEASON_WEEKS) + TWO_PAYMENT_CHARGE,10:c}");
                        Console.WriteLine($"{"Second payment:",-30} {(LARGE_LAWN_FEE * SEASON_WEEKS) + TWO_PAYMENT_CHARGE,10:c}");
                        Console.WriteLine($"{"Total:",-30} {(LARGE_LAWN_FEE * SEASON_WEEKS) + (TWO_PAYMENT_CHARGE * 2),10:c}");
                    }
                    break;
                case 3:
                    if (lawnSize < LAWN_SIZE_400)
                    {
                        Console.WriteLine($"{"The weekly mowing fee is:",-30} {SMALL_LAWN_FEE,10:c}");
                        Console.WriteLine($"{"Twenty separate payments of:",-30} {((SMALL_LAWN_FEE * SEASON_WEEKS) / SEASON_WEEKS) + TWENTY_PAYMENT_CHARGE,10:c}");
                        Console.WriteLine($"{"Total:",-30} {(SMALL_LAWN_FEE * SEASON_WEEKS) + (TWENTY_PAYMENT_CHARGE * SEASON_WEEKS),10:c}");
                    }
                    else if (lawnSize >= LAWN_SIZE_400 && lawnSize < LAWN_SIZE_600)
                    {
                        Console.WriteLine($"{"The weekly mowing fee is:",-30} {MEDIUM_LAWN_FEE,10:c}");
                        Console.WriteLine($"{"Twenty separate payments of:",-30} {((MEDIUM_LAWN_FEE * SEASON_WEEKS) / SEASON_WEEKS) + TWENTY_PAYMENT_CHARGE,10:c}");
                        Console.WriteLine($"{"Total:",-30} {(MEDIUM_LAWN_FEE * SEASON_WEEKS) + (TWENTY_PAYMENT_CHARGE * SEASON_WEEKS),10:c}");
                    }
                    else
                    {
                        Console.WriteLine($"{"The weekly mowing fee is:",-30} {LARGE_LAWN_FEE,10:c}");
                        Console.WriteLine($"{"Twenty separate payments of:",-30} {((LARGE_LAWN_FEE * SEASON_WEEKS) / SEASON_WEEKS) + TWENTY_PAYMENT_CHARGE,10:c}");
                        Console.WriteLine($"{"Total:",-30} {(LARGE_LAWN_FEE * SEASON_WEEKS) + (TWENTY_PAYMENT_CHARGE * SEASON_WEEKS),10:c}");
                    }
                    break;
                default:
                    Console.WriteLine("Error. Invalid payment option.");
                    break;
            }
        }
    }
}
