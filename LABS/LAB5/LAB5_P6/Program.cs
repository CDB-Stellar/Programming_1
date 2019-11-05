using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a console-based program for a college’s admissions office. 
             * The user enters a numeric high school grade point average (for 
             * example, 3.2) and an admission test score. Display the message 
             * “Accept” if the student meets either of the following requirements: 
             *      A grade point average of 3.0 or higher and an admission test score of at least 60
             *      A grade point average of less than 3.0 and an admission test score of at least 80
             *      If the student does not meet either of the qualification criteria, display “Reject" */

            double gpa;
            double admissionTest;
            const double GPA = 3;
            const double ADMISSION_TEST1 = 60;
            const double ADMISSION_TEST2 = 80;

            Console.WriteLine("Please enter the student's GPA and Admission Test Score below:");
            Console.Write("GPA: ");
            gpa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Admission Test Score: ");
            admissionTest = Convert.ToDouble(Console.ReadLine());

            if (gpa >= GPA && admissionTest >= ADMISSION_TEST1)
            {
                Console.WriteLine("Accept");
            }
            else if (gpa < GPA && admissionTest >= ADMISSION_TEST2)
            {
                Console.WriteLine("Accept");
            }
            else
            {
                Console.WriteLine("Reject");
            }
        }
    }
}
