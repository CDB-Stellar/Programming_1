using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_04._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 4: Question 3]
             * Write a method with the following header: 
             * static void CaculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees). This
             * method will calculate and assign the required fees amount to the third argument. [Fees = number
             * of courses * cost per course + 15.25]. Call the CaculateTuitionFee() method four times from your
             * program Main() method supplying different arguments each time and display the value of the third
             * argument. */

            double fees = 0f;

            CaculateTuitionFee(4, 250f, ref fees);
            Console.WriteLine($"Four courses: {fees:c}");
            CaculateTuitionFee(5, 250f, ref fees);
            Console.WriteLine($"Five courses: {fees:c}");
            CaculateTuitionFee(6, 250f, ref fees);
            Console.WriteLine($"Six courses: {fees:c}");
            CaculateTuitionFee(7, 250f, ref fees);
            Console.WriteLine($"Seven courses: {fees:c}");
        }

        static void CaculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = numberOfCourses * costPerCourse + 15.25;
        }
    }
}
