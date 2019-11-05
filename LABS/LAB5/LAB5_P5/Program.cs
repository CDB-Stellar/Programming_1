using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_P5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chloe Baker - 301062067

            /* Write a console-based program that accepts a user’s message 
             * and determines whether it is short enough for a social networking 
             * service that does not accept messages of more than 140 characters. 
             * [Hint: if the user’s input is assigned to the variable message 
             * then message.Length with give the number of characters in the 
             * input] */

            string userMessage;
            const int MAX_CHARACTERS = 140;

            Console.WriteLine("Enter your whole message below:");
            userMessage = Console.ReadLine();

            if (userMessage.Length <= MAX_CHARACTERS)
            {
                Console.WriteLine("This message length is good.");
            }
            else
            {
                Console.WriteLine("This message is too long.");
            }
        }
    }
}
