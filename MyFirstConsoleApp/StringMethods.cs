using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//STRING METHODS IN C#

namespace MyFirstConsoleApp
{
    internal class StringMethods
    {
        public static void Main(String[] args)
        {
            string name = "Code With Siri";
            //Upper and Lower Case
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            //Finding Index
            Console.WriteLine(name.IndexOf("e"));
            Console.WriteLine(name.IndexOf("Siri"));
            Console.WriteLine(name.LastIndexOf("i"));
            int lastIndex = name.LastIndexOf("i");
            Console.WriteLine("Last Index of i in gven string is: "+lastIndex);
            //inserting string/charecter
            string message = "Siri coding C#";
            Console.WriteLine(message.Insert(4," is"));
            //Replacing String
            Console.WriteLine(name.Replace("Siri","me"));
            string phnNum = "123-456-789";
            Console.WriteLine(phnNum.Replace("-", ""));
            //Finding Length of string
            Console.WriteLine(phnNum.Length);
            int length = phnNum.Length;
            Console.WriteLine("Length of the given String is: "+length);
            //Finding Substring
            Console.WriteLine(message.Substring(0,4));
            Console.WriteLine(message.Substring(5));
            //comparing two strings
            string res1 = "C#";
            string res2 = "c#";
            string res3 = ".Net";
            string res4 = "C#";
            Console.WriteLine(res1.Equals(res2));
            Boolean ans1 = res2.Equals(res3);
            Boolean ans2 = res1.Equals(res4);
            Console.WriteLine("res2 and res3 are equal: "+ans1);
            Console.WriteLine("res1 and res4 are equal: " + ans2);
            Console.ReadLine();

        }
    }
}
