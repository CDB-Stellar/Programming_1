using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 3] 
             * Write a method called CaculateTuitionFee(int numberOfCourses, double costPerCourse). This method
             * will calculate and return the required fees amount. 
             * [Fees = number of courses * cost per course + 15.25]. Call the CaculateTuitionFee() method four 
             * times from your program Main() method supplying different arguments each time. */

            Console.WriteLine($"{CaculateTuitionFee(4,350f):c}");
            Console.WriteLine($"{CaculateTuitionFee(4, 230.50):C}");
            Console.WriteLine($"{CaculateTuitionFee(3, 500f):c}");
            Console.WriteLine($"{CaculateTuitionFee(6, 250f):c}");
        }

        static double CaculateTuitionFee(int numberOfCourses, double costPerCourse)
        {
            double fees = numberOfCourses * costPerCourse + 15.25;
            return fees;
        }
    }
}
