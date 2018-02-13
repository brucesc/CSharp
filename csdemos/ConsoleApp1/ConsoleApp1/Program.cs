using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a method that can take a lunch order (combo number) and yield what is included in that order (drink, main dish, side dish)
           
        }
        static string OrderLunch(int drink, string mainDish, string sideDish)
        {
            string drinkText;
            switch (drink)
            {
                case 1: drinkText = "Coke"; break;
                case 2: drinkText = "Diet Coke"; break;
                case 3: drinkText = "Fanta"; break;
                case 4: drinkText = "RootBeer"; break;
                case 5: drinkText = "Sprite"; break;
                default: drinkText = "Water, sucka!";
                    break;
            }
            return string.Format("You have ordered a {0} with {1} and {2}", drinkText, mainDish, sideDish); //because the method calls for a string return and there is an int parameter, we must format the return
        }
        static string OrderLunch(int drink, string mainDish)
        {
            return OrderLunch(drink, mainDish, "no side dish");

        }
    }
}
