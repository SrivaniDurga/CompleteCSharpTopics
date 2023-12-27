using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Common Operators in C#

namespace MyFirstConsoleApp
{
    internal class CommonOperators
    {
        public static void Main(string[] args) 
        {
            int x = 10;
            int y = 20;
            Console.WriteLine(x>y);
            Console.WriteLine(x<y);
            Console.WriteLine(y/x); //gives you quotient
            Console.WriteLine(y%x); //gives you reminder
            int res = y % x;
            Console.WriteLine("Reminder = {0}", res);
            Console.WriteLine(x*y);
            int res1 = y / x;
            Console.WriteLine("Quotient = {0}",res1);

            // == , != operators
            int m = 22;
            int n = 22;
            Console.WriteLine(m==n);
            bool ans = m == n;
            Console.WriteLine("m==n is {0}", ans);
            Console.WriteLine(m!=n);

            // && , || operators
            Console.WriteLine(m == 22 && n == 22);
            bool res2 = m == 22 && n == 22;
            Console.WriteLine("Result ={0}", res2);
            Console.WriteLine(m == 22 && n == 20);
            Console.WriteLine(m == 22 || n == 22);
            Console.WriteLine(m == 22 || n == 20);

            //Ternary operator
            if (m >= n)
            {
                Console.WriteLine("Hello Siri");
            }
            else
            {
                Console.WriteLine("Bye Siri");
            }

            bool isEqual = m >= n ? true : false;//Ternary Operator
            Console.WriteLine("Final result is {0}", isEqual);
            bool isEqual1 = m > n ? true : false;
            Console.WriteLine("Final result is {0}", isEqual1);

        }
    }
}
