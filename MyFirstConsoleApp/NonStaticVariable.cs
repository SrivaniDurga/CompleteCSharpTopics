using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class NonStaticVariable
    {
        int x;
        string name;
        public NonStaticVariable(int x, string name)
        {
            this.x = x;
            this.name = name;
        }
        
        static void Main(string[] args)
        {
            NonStaticVariable obj1 = new NonStaticVariable(200,"jaggu");
            NonStaticVariable obj2 = new NonStaticVariable(300,"siri");

            Console.WriteLine("ID Number of Siri is "+obj1.x);
            Console.WriteLine("ID Number of Jaggu is " + obj2.x);
            Console.WriteLine("His name is " + obj1.name);
            Console.WriteLine("Her name is " + obj2.name);
            Console.ReadLine();
        }
        
    }
}
//if we want to assign multiple values to the same values accd to our requirement, then we need constructors.
