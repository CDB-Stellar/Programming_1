using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* After surveying a number of new-home electrical installations, Kelly 
             * Builder’s Inc. has worked out what the length of wire a typical house 
             * would require. Write a program that will prompt the user for the 
             * average length required for a home and the number of houses to wire. 
             * The program will then calculate and display the total length of wire 
             * required for the specified number of houses. */

            int lengthOfWire;
            int numberOfHouses;
            int totalLengthOfWire;

            Console.WriteLine("Please enter the average length of wire and the number of houses to wire.");
            Console.Write("Average length? ");
            lengthOfWire = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of houses? ");
            numberOfHouses = Convert.ToInt32(Console.ReadLine());

            totalLengthOfWire = lengthOfWire * numberOfHouses;

            Console.WriteLine($"For {numberOfHouses} houses, you will need {totalLengthOfWire} of wire.");
            //maybe change this one?
        }
    }
}
