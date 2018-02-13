using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_Practice
{
    class Program
    {
        //Returning a reference..
        public static ref string SampleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }
        string[] stringArray = { "one", "two", "three" };






        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
        static void Main(string[] args)
        {
            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);
            Console.ReadLine();


        }
    }
}
