using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_05_if_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            double aNumber;

            Console.WriteLine("Please input a number");
            aNumber = Convert.ToDouble(Console.ReadLine());

            if (aNumber > 50)
            {
                Console.WriteLine($"{aNumber} > 50");
                Console.WriteLine("Done comparing");
            }
            else if (aNumber < 50)  //you can only use "else if" if there is only one statement, otherwise you must use if
            {
                Console.WriteLine($"{aNumber} < 50");
            }
            else
            {
                Console.WriteLine($"{aNumber} = 50");
            }
        }
    }
}
