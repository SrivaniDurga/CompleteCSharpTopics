using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class DoWhileLoop
    {
        static void Main()
        {
            int counter = 0;
            do
            {
                counter++;
                Console.WriteLine(counter);

            }
            while (counter < 5);
            Console.WriteLine();

            //example2: using break statement
            int counter1 = 0;
            do
            {
                counter1++;
                if (counter1 >= 8)
                {
                    break;
                }
                Console.WriteLine(counter1);
            }
            while (counter1<10);
            Console.WriteLine();

            //example3: using continue statement
            int counter2 = 0;
            do
            {
                counter2++;
                if (counter2 >= 8)
                {
                    counter2++;
                    continue;
                }
                Console.WriteLine(counter2);
            }
            while (counter2 < 14);
        }       
    }
}
