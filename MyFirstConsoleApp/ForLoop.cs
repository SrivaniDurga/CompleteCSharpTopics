using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class ForLoop
    {
        static void Main()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Hello Siri " + i);
            }
            int[] Numbers = new int[3];
            Numbers[0] = 21;
            Numbers[1] = 22;
            Numbers[2] = 23;
            for(int i=0; i<Numbers.Length; i++)
            {
                Console.WriteLine("Hello C# " + Numbers[i]);
            }
        }
    }
}    
    

