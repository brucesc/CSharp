using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday_2_12_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to order for lunch?");
            Console.ReadLine();
            Console.WriteLine(OrderLunch(3, "Pizza"));

            Console.ReadLine();
        }

        static string OrderLunch(int comboNbr)
        {
            if (comboNbr == 1)
            {
                return "You have ordered a Diet Coke, Double Cheeseburger and Fries";

            }
            else if (comboNbr == 2)
            {
                return "You have ordered a Coke, Chicken Sandwich and side Salad";
            }
            else if (comboNbr == 3)
            {
                return "You have ordered a Water and Baked Potato";
            }
            else return "That item is not on the menu, sorry";

        }
        //static string OrderLunch(int Drink, string MainDish, string SideDish)
        //{
        //    string drinkText = "some drink";
        //    if (Drink == 1)
        //    {
        //        drinkText = "Coke";
        //    }
        //    else if (Drink == 2)
        //    {
        //        drinkText = "Diet Coke";
        //    }
        //    return string.Format("You ordered {0}, {1}, and {2}", drinkText, MainDish, SideDish);
        
        static string OrderLunch(int Drink, string MainDish, string SideDish = "no side dish")
        {
            //string drinkText;
            //if (Drink == 1)
            //{
            //    drinkText = "Coke";
            //}
            //else if (Drink == 2)
            //{
            //    drinkText = "Diet Coke";
            //}
            //else if (Drink == 3)
            //{
            //    drinkText = "Water";

            //}
            //else drinkText = "no drink selected";
            string drinkText; // more compact way of writing the if statements
            switch (Drink)
            { case 1: drinkText = "Coke"; break;
            case 2: drinkText = "Diet Coke"; break;
            case 3: drinkText = "Water"; break;
            default: drinkText = "No Drink"; break;

        }
            return string.Format("You ordered a {0}, {1}, and {2}!", drinkText, MainDish, SideDish);

            }
        static string OrderLunch(int Drink, string MainDish)
        {
            return OrderLunch(Drink, MainDish, "No side dish");

        }
}
    }


