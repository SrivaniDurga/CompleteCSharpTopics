using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class ParametarizedConstructor
    {
        int x;
        public ParametarizedConstructor(int i)
        {
            Console.WriteLine("Prameterized Constructor is called "+i);
        }
        public void Display()
        {
            Console.WriteLine("The value of x is "+x);
        }
        static void Main(string[] args)
        {
            ParametarizedConstructor p1 = new ParametarizedConstructor(10); //calling constructor
            ParametarizedConstructor p2 = new ParametarizedConstructor(20);
            p1.Display(); //default value of int is 0
            p2.Display();
        }
    }
}
