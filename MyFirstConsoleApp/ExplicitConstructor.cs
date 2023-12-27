using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class ExplicitConstructor
    {
        bool b;
        public ExplicitConstructor()
        {
            Console.WriteLine("Constructor is called");
        }
        static void Main(string[] args)
        {
            ExplicitConstructor e1 = new ExplicitConstructor();
            ExplicitConstructor e2 = new ExplicitConstructor();
            Console.WriteLine(e1.b);
        }
    }
}
//Note : So here we create two instances. so two times constructor is called.
//Here implicit constructor gave default value for boolean is "false"
