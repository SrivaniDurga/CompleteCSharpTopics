using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class CopyConstructor
    {
        int x;
        public CopyConstructor(int i) //Prametarized Constructor
        {
            Console.WriteLine("CopyConstructor is called "+i);
            x = i;
        }
        public CopyConstructor(CopyConstructor obj) //Copy Constructor
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine("The value of x is "+x);
        }
        static void Main(string[] args)
        {
            CopyConstructor c1 = new CopyConstructor(10);
            CopyConstructor c2 = new CopyConstructor(c1);
            CopyConstructor c3 = new CopyConstructor(c1);
            c1.Display();
            c2.Display();
            c3.Display();

        }
    }
}
//Note: 1) Copy Constructors creates objects by copying variables from another objects.
// 2) If we want to create multiple instances with same value , then we use Copy Constructors.
// 3) Thse constructors takes class name as parameter to it