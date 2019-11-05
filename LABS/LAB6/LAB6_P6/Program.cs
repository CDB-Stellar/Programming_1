using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* The average cost of a college textbook is $125. There is a premium 
             * of 20% on hardcover text and a discount of 5% on sales of more 
             * than 4 textbooks. Write a program to prompt the user for the 
             * appropriate inputs and compute and display the before-tax cost of 
             * the textbooks. Sample calculation: 
             * price of 10 hardcover text = 10 * 125 + premium – discount 
             * price = 1250 + 20% of 1250 – 5% of 1250
             * price = $1437.50 */

            const double OVER_4_DISCOUNT = 0.05;
            const double HARDCOVER_PREMIUM = 0.2;
            char hardcover;
            double bookPrice;
            int numberOfBooks;
            double totalBeforeTax;

            Console.WriteLine("Please enter the price of the textbook, how many textbooks you want to buy, and whether or not they are hardcover.");
            Console.Write("Price of one textbook: $");
            bookPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of textbooks: ");
            numberOfBooks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Are the books hardcover (Y/N): ");
            hardcover = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (hardcover)
            {
                case 'Y':
                    if (numberOfBooks > 4)
                    {
                        totalBeforeTax = (numberOfBooks * bookPrice) + (numberOfBooks * bookPrice * HARDCOVER_PREMIUM) - (numberOfBooks * bookPrice * OVER_4_DISCOUNT);
                        Console.WriteLine($"The cost before tax is {totalBeforeTax:c}");
                    }
                    else
                    {
                        totalBeforeTax = (numberOfBooks * bookPrice) + (numberOfBooks * bookPrice * HARDCOVER_PREMIUM);
                        Console.WriteLine($"The cost before tax is {totalBeforeTax:c}");
                    }
                    break;
                case 'N':
                    if (numberOfBooks > 4)
                    {
                        totalBeforeTax = (numberOfBooks * bookPrice) - (numberOfBooks * bookPrice * OVER_4_DISCOUNT);
                        Console.WriteLine($"The cost before tax is {totalBeforeTax:c}");
                    }
                    else
                    {
                        totalBeforeTax = (numberOfBooks * bookPrice);
                        Console.WriteLine($"The cost before tax is {totalBeforeTax:c}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid hardcover response.");
                    break;
            }
        }
    }
}
