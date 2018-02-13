using System;

using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int length;
            //int width;

            //Console.WriteLine("Please enter the Length:");
            //Console.WriteLine("Please enter the Width:");
            //length = Console.WriteLine("Please enter the Length:");
            //width = Console.WriteLine("Please enter the Width:");

            //int Area = length * width;

            //Console.WriteLine("The Area is: {0}" Area)

            Console.WriteLine("What's the length? ");
            string stringLength = "";
            stringLength = Console.ReadLine();
            decimal length = 0;
            length = decimal.Parse(stringLength);

            Console.Write("What's the width?");
            string stringWidth = "";
            stringWidth = Console.ReadLine();
            decimal width = 0;
            width = decimal.Parse(stringWidth);

            Console.WriteLine("The area is " + length * width);

            Console.ReadLine();
              
        }
    }
}
