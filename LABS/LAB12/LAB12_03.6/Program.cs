using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_03._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067 - December 2, 2019

            /* [Part 3: Question 6]
             * Write a method called CalculateGravitationalAttraction() that takes three double arguments
             * (masses of the two bodies and the distance between them). The method will calculate and 
             * return the force of attraction between them. [F=G*m1*m2/d^2, where G = 6.673x10^-11]. In your 
             * main call this method with the masses of the earth, moon and the distance between them and 
             * display the resulting force. Mass of Earth = 5.972 × 10^24, moon = 7.34767309 × 10^22, 
             * Distance = 384,400000m */

            Console.WriteLine($"{CalculateGravitationalAttraction(5.972 * Math.Pow(10,24), 7.34767309 * Math.Pow(10, 22), 384400000)}");
        }

        static double CalculateGravitationalAttraction(double massBody1, double massBody2, double distance)
        {
            double GRAVITY = 6.673 * Math.Pow(10,-11);
            double attractionForce = GRAVITY * ((massBody1 * massBody2) / (distance * distance));
            return attractionForce;
        }
    }
}
