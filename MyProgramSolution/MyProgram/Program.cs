using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;


namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Constants constants = new Constants();

            Console.WriteLine(constants.HelloWorld);
            Console.ReadKey();

        }
    }
}
