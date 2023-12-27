using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2=int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Sum of two numbers {0}", sum);
            Console.ReadKey();
        }
    }
}
