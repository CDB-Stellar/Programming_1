using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_01._8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - November 30, 2019

            /* [Part 1: Questions 1 - 8] 
             * Add another method called ShowMenu() to your project. This method will call the method in question 7 continuously 
             * until the user presses 0. (You will have to invoke the method in a loop body, read in the user input as well as 
             * check the input). You will need to hook up all the methods that you wrote previously. */

            ShowMenu();
        }

        static void DisplayPersonalInfo()
        {
            Console.WriteLine($"{"Name:",18} Chloe Baker");
            Console.WriteLine($"{"School:",18} Centennial College");
            Console.WriteLine($"{"Program:",18} Game-Programming");
            Console.WriteLine($"{"Favourite Course:",18} Programming :)");
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

        static void CalculateAreaOfCircle()
        {
            double radius;
            double area;

            Console.Write("Please enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = (3.14 * radius) * (3.14 * radius);
            Console.WriteLine($"The area is: {area}");
        }

        static void CalculateAreaOfTriangle()
        {
            double baseOfTriangle;
            double height;
            double area;

            Console.Write("Enter the base of the triangle: ");
            baseOfTriangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the triangle: ");
            height = Convert.ToDouble(Console.ReadLine());
            area = baseOfTriangle * height / 2;
            Console.WriteLine($"The area of the triangle is: {area}");
        }

        static void CalculateSaleCommission()
        {
            double salesFigure;
            double commission;

            Console.Write("Enter the sales figure: ");
            salesFigure = Convert.ToDouble(Console.ReadLine());

            if (salesFigure > 1000)
                commission = 0.25 * salesFigure;
            else
                commission = 0;

            Console.WriteLine($"The commision is: {commission:c}");
        }

        static void DisplaySineTable()
        {
            double startValue;
            double stepSize;

            Console.Write("Enter the starting value: ");
            startValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the step value: ");
            stepSize = Convert.ToDouble(Console.ReadLine());

            for (int count = 0; count < 10; ++count)
            {
                Console.WriteLine($"{startValue,4:f2}     {Math.Sin(startValue),6:f4}");
                startValue += stepSize;
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("================Chloe’s Computer Systems==================");
            Console.WriteLine("|         1. To display Personal Information             |");
            Console.WriteLine("|         2. To calculate Tuition                        |");
            Console.WriteLine("|         3. To calculate area of a Circle               |");
            Console.WriteLine("|         4. To calculate the area of a Triangle         |");
            Console.WriteLine("|         5. To calculate sales commission               |");
            Console.WriteLine("|         6. To display sine table                       |");
            Console.WriteLine("|         0. To end program                              |");
            Console.WriteLine("|                                                        |");
            Console.WriteLine("==========================================================");
            Console.Write("          Enter the number of your choice -> ");
        }

        static void ShowMenu()
        {
            int menuChoice;

            do
            {
                DisplayMenu();
                menuChoice = Convert.ToInt32(Console.ReadLine());

                switch (menuChoice)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("\n\n");
                        DisplayPersonalInfo();
                        break;
                    case 2:
                        Console.WriteLine("\n\n");
                        CalculateTuition();
                        break;
                    case 3:
                        Console.WriteLine("\n\n");
                        CalculateAreaOfCircle();
                        break;
                    case 4:
                        Console.WriteLine("\n\n");
                        CalculateAreaOfTriangle();
                        break;
                    case 5:
                        Console.WriteLine("\n\n");
                        CalculateSaleCommission();
                        break;
                    case 6:
                        Console.WriteLine("\n\n");
                        DisplaySineTable();
                        break;
                    default:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Invalid menu choice.");
                        break;
                }
            } while (menuChoice != 0);
        }
    }
}
