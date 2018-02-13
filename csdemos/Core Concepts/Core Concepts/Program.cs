using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            AskSportsQuestion();
            Console.ReadLine();


        }

        private static void AskSportsQuestion()
        {
            string input;
            do
            {
                // get input

                Console.WriteLine("Enter the best baseball team!");
                input = Console.ReadLine();

                // test input (we have if and switch statements for testing)
                if (input == "Reds" ||
                    input == "Cincinnati" ||
                    input == "Cincinnati Reds") // when you wrap something in () it generally means do this. || is or. && is and.
                {
                    Console.WriteLine("Bingo!");
                }
                else //this is the closing statement for the if statement
                {
                    Console.WriteLine("Boooooooo! Try again!");

                }

                Console.ReadLine();


                //maybe respond to input

                //maybe do it again
            } while (!(input == "Reds" ||
                    input == "Cincinnati" ||
                    input == "Cincinnati Reds")); // true in the while() would create an endless loop

            Console.WriteLine("Good job!");
        }
    }
}
