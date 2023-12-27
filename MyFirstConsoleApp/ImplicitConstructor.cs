using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//Constructors

//1.Constructors are the special methods present inside every class which are used to initialize values to the variables.
//2.Constructor name should be the same name as class name.
//3.If we want to create instance of the class, then we use these constructors.
//4.Even if we don't declare constructor Explicitly, Compiler implicitly creates constructors and initialize variables with their default values.
//5.Implicit Constructors are always Public and they don't have any parameters.
//6.If we create constructors by our own, then those cons are called "Explicit Constructors".
//7.Explicit Constructors can contain both parameter and without parameter.

namespace MyFirstConsoleApp
{
    internal class ImplicitConstructor
    {
        class Test
        {
            int i;//here I don't define any value to i. But implicit constructor assigns 0 as a default value to integer i.
            int j = 18;
            bool b;
            string s;
            public Test() //Even if we don't write from step num 29 to 34, compiler automatically creates implicit constructor and initialize values to given variables internally.
            {
                i = 0;
                b = false;
                s = null;
            }
            public static void Main(string[] args)
            {
                Test t = new Test(); //creating instance of class
                Console.WriteLine("Value of i is " + t.i);
                Console.WriteLine("Value of j is " + t.j);
                Console.WriteLine("Value of b is " + t.b);
                Console.WriteLine("Value of s is " + t.s);
            }
        }
        
    }
}
//note: so whenever we create an Instance of the class, automatically there will be an 
//implicit call to the constructor. and that constructor is responsible for initializing values to given variables.
