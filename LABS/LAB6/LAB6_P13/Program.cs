using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program for a college’s admissions office. The user enters a 
             * numeric high school grade point average (for example, 3.2) and an 
             * admission test score. Print the message “Accept” if the student meets 
             * either of the following requirements: 
             * A grade point average of 3.0 or higher and an admission test score of at least 60 
             * A grade point average of less than 3.0 and an admission test score of at least 80 
             * If the student does not meet either of the qualification criteria, print "Reject" */

            const int GPA = 3;
            const int ADMISSION_TEST_60 = 60;
            const int ADMISSION_TEST_80 = 80;
            double gpa;
            double admissionTest;

            Console.WriteLine("Please enter the student's GPA and admission test score below:");
            Console.Write("GPA: ");
            gpa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Admission Test Score: ");
            admissionTest = Convert.ToDouble(Console.ReadLine());

            if (gpa >= 3 && admissionTest >= ADMISSION_TEST_60)
            {
                Console.WriteLine("Accept");
            }
            else if (gpa < 3 && admissionTest >= ADMISSION_TEST_80)
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
