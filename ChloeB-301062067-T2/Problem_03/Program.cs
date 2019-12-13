using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chloe Baker - 301062067

            // Side1^2 + Side2^2 = Hypotenuse^2 if true is a triplet

            const int LIMIT = 500;
            int side1 = 1;
            int side2 = 1;
            int hypotenuse = 1;

            while (side1 <= LIMIT)
            {
                while (side2 <= LIMIT)
                {
                    while (hypotenuse <= LIMIT)
                    {
                        if ((side1 * side1) + (side2 * side2) == (hypotenuse * hypotenuse))
                        {
                            Console.WriteLine($"{side1,-4}, {side2,-4}, {hypotenuse,-4} is a Pythagorean Triple.");
                        }

                        ++hypotenuse;
                    }
                    hypotenuse = 1;

                    ++side2;
                }
                side2 = 1;

                ++side1;
            }
        }
    }
}
