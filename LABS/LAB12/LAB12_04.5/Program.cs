using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_04._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 4: Question 5]
             * Write a method that takes three parameters of type double: the first represents an
             * angle, the other two represents the sine and cosine of the angle respectively. The
             * method must be able to change the actual value of the second and third argument. 
             * In your main method call the above method ten times with values 0.500, 0.501, 
             * 0.502 ... 0.509 and print out the values for angle, sine and cosine in a tabular 
             * format. */

            double sineOfAngle = 0f;
            double cosineOfAngle = 0f;

            AngleSineCosine(0.500, ref sineOfAngle, ref cosineOfAngle);
            Console.WriteLine($"{0.500}, {sineOfAngle:f3}, {cosineOfAngle}");
            AngleSineCosine(0.501, ref sineOfAngle, ref cosineOfAngle);
            Console.WriteLine($"{0.501}, {sineOfAngle}, {cosineOfAngle}");
            AngleSineCosine(0.502, ref sineOfAngle, ref cosineOfAngle);
            Console.WriteLine($"{0.502}, {sineOfAngle}, {cosineOfAngle}");
            AngleSineCosine(0.503, ref sineOfAngle, ref cosineOfAngle);
            Console.WriteLine($"{0.503}, {sineOfAngle}, {cosineOfAngle}");
            AngleSineCosine(0.504, ref sineOfAngle, ref cosineOfAngle);
            Console.WriteLine($"{0.504}, {sineOfAngle}, {cosineOfAngle}");
            AngleSineCosine(0.505, ref sineOfAngle, ref cosineOfAngle);
            Console.WriteLine($"{0.505}, {sineOfAngle}, {cosineOfAngle}");
            AngleSineCosine(0.506, ref sineOfAngle, ref cosineOfAngle);
            Console.WriteLine($"{0.506}, {sineOfAngle}, {cosineOfAngle}");
            AngleSineCosine(0.507, ref sineOfAngle, ref cosineOfAngle);
            Console.WriteLine($"{0.507}, {sineOfAngle}, {cosineOfAngle}");
            AngleSineCosine(0.508, ref sineOfAngle, ref cosineOfAngle);
            Console.WriteLine($"{0.508}, {sineOfAngle}, {cosineOfAngle}");
            AngleSineCosine(0.509, ref sineOfAngle, ref cosineOfAngle);
            Console.WriteLine($"{0.509}, {sineOfAngle}, {cosineOfAngle}");
        }

        static void AngleSineCosine(double angle, ref double sineOfAngle, ref double cosineOfAngle)
        {
            sineOfAngle = Math.Sin(angle);
            cosineOfAngle = Math.Cos(angle);
        }
    }
}
