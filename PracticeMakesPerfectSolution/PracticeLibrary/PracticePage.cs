using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary
{
    class PracticePage
    {
        int[] ar = { 1, 2, 3, 4, 10, 11 };

        static int simpleArraySum(int n, int[] ar)
        {
            int x = 0;
            for (int i = 0; i <= ar.Length; i++)
            {
                x += i;
            }
            return x;
        }



        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = simpleArraySum(n, ar);
            Console.WriteLine(result);
        }
    }
}
