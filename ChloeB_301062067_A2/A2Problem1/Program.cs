using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067 - COMP100-005

            /* Create a program that calculates and displays the number of rolls of 
             * wall-paper needed to cover a room. The salesclerk will provide the length, 
             * width, and ceiling height of the room, in feet. He or she will also provide 
             * the number of square feet a single roll will cover. (You may assume that 
             * the paper will fit the wall exactly and there is no wastage) */

            const int SYMMETRICAL_WALLS = 2;
            double lengthOfRoom;
            double widthOfRoom;
            double heightOfRoom;
            double singleRollCoverage;
            double totalNumberOfRolls;

            Console.WriteLine("This program will calculate the number of wall-paper rolls needed to cover a room.\n");

            Console.Write("Please enter the length of the room in feet: ");
            lengthOfRoom = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the width of the room in feet: ");
            widthOfRoom = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the height of the room in feet: ");
            heightOfRoom = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter how many square feet a single roll of wall-paper will cover: ");
            singleRollCoverage = Convert.ToDouble(Console.ReadLine());

            totalNumberOfRolls = ((lengthOfRoom * heightOfRoom * SYMMETRICAL_WALLS) + (widthOfRoom * heightOfRoom * SYMMETRICAL_WALLS)) / singleRollCoverage;
            
            if (totalNumberOfRolls % 1 != 0)
            {
                totalNumberOfRolls += 1;
            }

            Console.WriteLine($"\nThe total number of wall-paper rolls to cover the room is {(int)totalNumberOfRolls}.");
        }
    }
}
