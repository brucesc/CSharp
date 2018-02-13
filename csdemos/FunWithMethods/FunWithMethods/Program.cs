using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
       static void Main(string[] args) 
        {
            static int Add(int x, int y)
        {
            int ans = x + y;
            x = 10000;
            y = 88888;
            return ans;
            }   
        }
    }
}
