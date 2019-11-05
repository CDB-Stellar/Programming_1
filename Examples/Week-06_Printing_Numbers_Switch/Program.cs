using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_Printing_Numbers_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 10, 2019
            //Switch version of "Week-06_Printing_Numbers_if"

            int aNumber;

            Console.WriteLine("Please enter a number");
            aNumber = Convert.ToInt32(Console.ReadLine());

            switch (aNumber)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case int x when x < 10:
                    Console.WriteLine(x);
                    break;
                default:
                    Console.WriteLine("I don't know");
                    break;
            }
        }
    }
}
