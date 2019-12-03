using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_02._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 2: Question 4] 
             * Write a method that takes two arguments: a cost price and a two letter province code.
             * It will calculate and display the selling price. (If province is Ontario a tax of 13% 
             * is added to the price, if the province is Quebec a tax of 17% is added to the cost 
             * price. There is no tax for the rest of the provinces and territories). In your main, 
             * call this method enough times to fully test it. */

            DisplaySellingPrice(1f, "ON");
            DisplaySellingPrice(1f, "QC");
            DisplaySellingPrice(1f, "NT");
            DisplaySellingPrice(10f, "CY");
            DisplaySellingPrice(10f, "ON");
            DisplaySellingPrice(10f, "QC");
        }

        static void DisplaySellingPrice(double price, string province)
        {
            double sellingPrice = price;
            if (province.ToUpper() == "ON")
                sellingPrice = (price * 0.13) + price;
            else if (province.ToUpper() == "QC")
                sellingPrice = (price * 0.17) + price;
            Console.WriteLine($"The price in {province} is: {sellingPrice:c}.");
        }
    }
}
