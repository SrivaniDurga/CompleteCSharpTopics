using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static constructor is excuted");
        }
        static void Main()
        {
            Console.WriteLine("Main method is excuted");
        }
    }
}
//Note: 1) Static constructors are no need to call explicitly. They are Implicitly called.
// 2) Static constructors donot contain any parameters and hence they cannot be Overloaded.
// 3) They are first to excute in the program.
// 4) Static Constructors are also Implicitly Defined, but only if the class contains static variables.

