using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            double gradePointAverage;
            double admissionTestScore;
            const double GPA_SCORE = 3;
            const double ADMISSION_1 = 60;
            const double ADMISSION_2 = 80;

            Console.WriteLine("Please enter your GPA: ");
            gradePointAverage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your admission test score: ");
            admissionTestScore = Convert.ToDouble(Console.ReadLine());

            if (gradePointAverage >= GPA_SCORE && admissionTestScore >= ADMISSION_1)
            {
                Console.WriteLine("Accept");
            }
            else if (gradePointAverage < GPA_SCORE && admissionTestScore >= ADMISSION_2)
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
