using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class TakingInput
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");//Writing to Console
            string firstName = Console.ReadLine();//Reading from Console
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello "+firstName+" "+lastName);//string concatination
            Console.WriteLine("Hello {0} {1}",firstName, lastName);//string formatting
        }
        
    }
}
