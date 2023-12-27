using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Arrays are one of the Data Structures that store multiple values with a similar Data Type in a Single Variable.

namespace MyFirstConsoleApp
{
    internal class Arrays
    {
        public static void Main(String[] args)
        {
            int[] OddNumbers = new int[3]; //size of the Array is 3
            OddNumbers[0] = 1;
            OddNumbers[1] = 3;  
            OddNumbers[2] = 5;
            Console.WriteLine("Result is "+OddNumbers[1]);
        }
        

    }
}
