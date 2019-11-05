using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            string name;
            string streetAddress;
            string city;
            string state;
            string zipCode;
            int blenderQuantity;
            const double BLENDER_PRICE = 39.95;
            const double TAX = 0.07;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Street address: ");
            streetAddress = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State: ");
            state = Console.ReadLine();
            Console.Write("Zip code: ");
            zipCode = Console.ReadLine();
            Console.Write("How many magic blenders do you want to order? ");
            blenderQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nReceipt for:");
            Console.WriteLine($"{name}");
            Console.WriteLine($"{streetAddress}");
            Console.WriteLine($"{city}, {state} {zipCode}");

            Console.WriteLine($"\n{blenderQuantity} blenders ordered @{BLENDER_PRICE:c} each");

            Console.WriteLine($"\nTotal: {(blenderQuantity * BLENDER_PRICE), 12:c}");
            Console.WriteLine($"Tax: {(blenderQuantity * BLENDER_PRICE * TAX), 12:c}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Due: {(blenderQuantity * BLENDER_PRICE) + (blenderQuantity * BLENDER_PRICE * TAX), 14:c}");
        }
    }
}
