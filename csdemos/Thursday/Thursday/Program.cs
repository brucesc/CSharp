using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thursday
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime mydate = DateTime.Now;
            //Console.WriteLine(mydate.AddDays(1));
            //Console.ReadLine();

            //DateTime mydate = new DateTime(2018, 12, 25);


            //Console.WriteLine(mydate);


            //Console.ReadLine();
            //int[] p = { 56, 12, 19, 7, 43, 81, 9 };
            //Array.Sort(p);

            //foreach (int item in p)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.ReadLine();
            //int total = 0;


            //int[] things = new int[6];
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine("Enter a number: ");
            //    string theString = Console.ReadLine();
            //    things[i] = int.Parse(theString);
            //    total = total + things[i];
            //}
            //Console.WriteLine(total);

            //Console.ReadLine();


            //ArrayList money = new ArrayList();
            //money.Add(5000.99M);
            //money.Add(45.99M);
            //money.Add(768.01M);

            //money.Sort();

            //foreach (object item in money)
            //{
            //    Console.WriteLine((decimal)item*2);

            //}
            //Console.ReadLine();

            //Stack myqueue = new Stack();







            //Hashtable products = new Hashtable();
            //products.Add("A100", 1000);
            //products.Add("A200", 50);
            //products.Add("B123", 123);
            //products.Add("Z100-Red-Large-oversize", 12);

            //// want a report on these

            //Console.WriteLine((int)products["A200"] * 2);

            // if you want to do math with this, we need to cast the product into a type (int, decimal, ...)



            List<int> mylist = new List<int>();
            mylist.Add(123);
            mylist.Add(456);
            mylist.Add(789);
            mylist.Sort();
            foreach (var item in mylist)
            {
                Console.WriteLine(item *3);
            }

            

            Console.ReadLine();



        }
    }
}
