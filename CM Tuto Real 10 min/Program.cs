using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Tuto_Real_10_min
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 55;
            string s = "test";
            Console.WriteLine("Hello " + i + " " + s); 
            TestFunction();
            bool b = SecondTestFunction(55);
            Console.WriteLine("Hello " + b);
            Console.ReadKey();
        }

        static void TestFunction()
        {

        }

        static bool SecondTestFunction(int i)
        {
            return i < 100;
        }
    }
}
