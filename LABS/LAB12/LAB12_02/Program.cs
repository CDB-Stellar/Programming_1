using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 29, 2019

            /* write a method called CalculateTuition(), that prompts the user for the number of courses 
             * and then calculates and displays the tuition cost. (cost = number of course * 569.99). Call 
             * this method from main. */

            CalculateTuition();
        }

        static void CalculateTuition()
        {
            int numberOfCourses;
            double tuitionCost;

            Console.Write("Please enter the number of courses you're taking: ");
            numberOfCourses = Convert.ToInt32(Console.ReadLine());
            tuitionCost = numberOfCourses * 569.99;
            Console.WriteLine($"The tuition cost is: {tuitionCost:c}");
        }
    }
}
