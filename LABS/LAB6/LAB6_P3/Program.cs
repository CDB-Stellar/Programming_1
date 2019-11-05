using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - October 24, 2019

            /* Write a program that prompts the user for the number of courses and 
             * residency status (domestic or international) and calculates tuition 
             * cost. Cost is based on the table below: 
             * Domestic         $325 per course
             * International    $1375 per course
             * You decide how you want the user to enter her/his residency status 
             * and prompt accordingly, also you should use named constants for the 
             * cost per course. */

            const int DOMESTIC_COST_PER_COURSE = 325;
            const int INTERNATIONAL_COST_PER_COURSE = 1375;
            char residencyStatus;
            int numberOfCourses;

            Console.Write("Please enter your residency status ('D'omestic or 'I'nternational): ");
            residencyStatus = Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter the number of courses being taken: ");
            numberOfCourses = Convert.ToInt32(Console.ReadLine());

            switch (residencyStatus)
            {
                case 'D':
                    Console.WriteLine($"{numberOfCourses} courses will be {numberOfCourses * DOMESTIC_COST_PER_COURSE:c}.");
                    break;
                case 'I':
                    Console.WriteLine($"{numberOfCourses} courses will be {numberOfCourses * INTERNATIONAL_COST_PER_COURSE:c}.");
                    break;
                default:
                    Console.WriteLine("Invalid.");
                    break;
            }
        }
    }
}
