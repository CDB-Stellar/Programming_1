using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a console-based program for a lawn-mowing service. 
             * The lawn-mowing season lasts 20 weeks. The weekly fee for 
             * mowing a lot under 400 square feet is $25. The fee for a 
             * lot that is 400 square feet or more, but under 600 square 
             * feet, is $35 per week. The fee for a lot that is 600 squarefeet 
             * or over is $50 per week. Prompt the user for the length and 
             * width of a lawn, and then display the weekly mowing fee, as 
             * well as the total fee for the 20-week season. */
             
            const int WEEKS_IN_SEASON = 20;
            const int WEEKLY_FEE_UNDER_400SF = 25;
            const int WEEKLY_FEE_UNDER_600SF = 35;
            const int WEEKLY_FEE_OVER_600SF = 50;
            const int LAWN_SIZE1 = 400;
            const int LAWN_SIZE2 = 600;
            double lengthOfLawn;
            double widthOfLawn;
            double totalFee;

            Console.WriteLine("Please enter the length and width of the lawn below:");
            Console.Write("Length in square feet: ");
            lengthOfLawn = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width in square feet: ");
            widthOfLawn = Convert.ToDouble(Console.ReadLine());

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
    }
}
