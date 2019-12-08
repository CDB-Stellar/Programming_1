using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB13_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 6, 2019

            /* 1. Write a method that takes four arguments. The first two arguments are ints, the third is a char
             * and the last is an int. The first argument represents two ints that will be operands for an 
             * arithmetic operation, the third argument represents the arithmetic operation to be performed on 
             * the first two numbers and the last argument represent the result of the computation. The method 
             * must be coded so that the result of the calculation is available to the calling method i.e the 
             * fourth argument must be decorated so that its value is available to the calling method From your 
             * main, call this method twice with different arithmetic operators and display the result in a simple
             * readable format. [Hint: the following code statements in main will call the method]
             *      int a = 10, b = 5, result;
             *      char operation = '+'
             *      Method(a, b, operation, out result);
             *      Console.WriteLine("{0} {2} {1} = {3}", a, b, operation, result);
             * 2. Modify the method in Question 1 to return a bool value. (This is better programming style, 
             * because the returned value will be checked before the value of the last argument is used.) The 
             * method will return true if the third argument represents a valid operation and false otherwise. The
             * method should still do the computation as specified by the third argument. From your main, call 
             * this method twice with once with a valid arithmetic operator and once with an invalid operator such
             * as ‘&’ or ‘$’. You should check the return value and then display the result or an error message. 
             * 3. Re-implement question 2 using a different parameter modifier i.e. if you used the out keyword 
             * then re-implement using the ref keyword or if you used the ref keyword then re-implement using the 
             * out keyword. 
             * 4. Write a method that returns a double and takes two double arguments, one mandatory and one 
             * optional. The first argument represents the cost of an article and the second represent the tax rate
             * (the default tax rate is 0.14). The will calculate the tax and return this value. From your main, 
             * call this method twice, once with one argument and then with two arguments and displaying the both 
             * results in simple format. */

            int a = 10, b = 5, result = 0;
            char operation = '+';

            if (DoAnOperation(a, b, operation, ref result))
                Console.WriteLine("{0} {2} {1} = {3}", a, b, operation, result);
            else
                Console.WriteLine("Error. {0} is not a vaid operator.", operation);
            operation = '&';
            if (DoAnOperation(a, b, operation, ref result))
                Console.WriteLine("{0} {2} {1} = {3}", a, b, operation, result);
            else
                Console.WriteLine("Error. {0} is not a vaid operator.", operation);

            Console.WriteLine("__________________________________________");

            Console.WriteLine($"Tax = {CalculateTax(10):c}");
            Console.WriteLine($"Tax = {CalculateTax(10, 0.1):c}");
        }

        static bool DoAnOperation(int operand1, int operand2, char operation, ref int result)
        {
            bool validOperation = true;

            result = 0;
            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    result = operand1 / operand2;
                    break;
                default:
                    validOperation = false;
                    break;
            }
            return validOperation;
        }

        static double CalculateTax(double costOfArticle, double taxRate = 0.14)
        {
            double tax = costOfArticle * taxRate;
            return tax;
        }
    }
}
