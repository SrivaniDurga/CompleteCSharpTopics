using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class DataTypeConversions
    {
        public static void Main(String[] args)
        {
            //Implicit Conversion (Converting smaller data type to larger data type)
            //char > int > long > float > double
            int num = 25;
            double res = num;
            Console.WriteLine(res);
            Console.WriteLine(res.GetType());

            char ch = 'a';
            int res2 = ch; //
            Console.WriteLine(res2);
            Console.WriteLine(res2.GetType());

            //Explicit Type Conversion
            //Converting larger data type to smaller data type. 
            float fl = 55.6f;
            int n = (int)fl;
            Console.WriteLine(n);
            Console.WriteLine(n.GetType());

            //float f = 567324172666546924.5f;
            //int b = Convert.ToInt32(f); //here it will give Overflow Exception.Convert class can't deal with large numbers.Only Explicit conversion is possible for large numbers. 
            //Console.WriteLine(b);

            float f1 = 567324172666546924.5f;
            int b1 = (int)f1; //It won't give Exception
            Console.WriteLine(b1);


            //To convert "String" data type to any other data type. You have to use Built in methods using "Convert class" or "Parse method".Explicit and Implicit conversion is not possible.
            string name = "1234";
            int res3 = Convert.ToInt32(name);
            Console.WriteLine(res3);
            Console.WriteLine(res3.GetType());


            //Using Parse method
            string str = "150";
            int a= int.Parse(str);
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            Console.ReadLine();
        }
    }
}
