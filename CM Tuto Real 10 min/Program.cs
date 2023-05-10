using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Tuto_Real_10_min
{
    internal class Program
    {
        static void TestFunction()
        {

        }
        static bool SecondTestFunction(int i)
        {
            return i < 100;
        }
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

            // Print the age and convert it to an int
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            Console.ReadKey();
        }
    }
}
