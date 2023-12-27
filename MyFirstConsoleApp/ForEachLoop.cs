using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class ForEachLoop
    {
        static void Main(string[] args)
        {
            char[] ch = { 'H', 'E', 'L', 'L', 'O' };
            foreach(char c in ch)
            {
                Console.Write(c+" ");
                
            }
            Console.WriteLine();

//Example2:
            string[] str = new string[3];
            str[0] = "hello ";
            str[1] = "siri ";
            str[2] = "Good Morning!";
            foreach(string s in str)
            {
                Console.Write(s);
            }

//Example3:using foreach loop to check whether element is present in the array or not
            char[] ch2 = { 'a', 'b', 'c', 'f','i', 'j', 'k','m'};
            int male = 0; int female = 0;
            foreach (char letter in ch2)
            {
                if (letter == 'f')
                {
                    female++;
                }
                if(letter=='m')
                {
                    male++;
                }
            }
            Console.WriteLine("Number of females are "+female);
            Console.WriteLine("Number of males are " + male);

            //Example4:foreach loop using for List of numbers
            var numbers = new List<int>() { 5, -8, 3, 14, 9, 17, 0, 4 };
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadLine();
        }
        
    }
}
