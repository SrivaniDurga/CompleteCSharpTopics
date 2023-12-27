using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class WhileLoop
    {
        static void Main()
        {
            int i = 1; //Initialization
            while (i < 10) //Condition
            {
                Console.WriteLine("i " + i);
                i++;//Increment/Decrement--if you don't give this condition it will enterinto infinite loop
            }
            Console.WriteLine();

            int j = 1;
            while (j < 10)
            {
                if (j == 6)
                {
                    break;
                }
                Console.WriteLine("j "+j);
                j++;
            }
            Console.WriteLine();


            int p = 2;
            while (p < 10)
            {
                if (p == 7)
                {
                    p++;
                    continue;
                }
                Console.WriteLine("p " + p);//in this case it will print numbers after 6 also
                p++;
            }
        }
    }
}

   
