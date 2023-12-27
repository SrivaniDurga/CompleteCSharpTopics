using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class StaticVariable
    {
        static int x = 100;
        static string s = "Siri";
        static void Main(string[] args)
        {
            Console.WriteLine("Value of x is "+x);
            Console.WriteLine("My name is "+s);
        }
    }
}
