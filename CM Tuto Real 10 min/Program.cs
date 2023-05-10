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
            bool bFalse = SecondTestFunction(105);
            bool bTrue = SecondTestFunction(50);
            Console.WriteLine("Hello " + bFalse + " " + bTrue);

            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

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
