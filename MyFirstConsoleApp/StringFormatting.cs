using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//STRING CONCATINATION & STRING FORMATING

namespace MyFirstConsoleApp
{
    class StringFormatting
    {

        //string concatination

        //model-1:      
        static void Main(string[] args)
        {
            string s1 = "Siri";
            Console.WriteLine("Hello " + s1);

            //model-2:
            string s2 = "Hello";
            string s3 = "Siri";
            Console.WriteLine(s2 + " " + s3);

            //model-3:
            Console.WriteLine("Enter your name here: ");
            string name = Console.ReadLine();//reads input from the user
            int age = 25;
            string food = "chicken";
            char letter = 'A';   
            Console.WriteLine("Hello " + name + " her age is " + age + " she likes " + food + " her full name ends with " + letter);

            //string formatting(reduces complexity during string concatination)
            Console.WriteLine("Hello {0 } her age is {1 } she likes {2 } her full name ends with {3}",name,age,food,letter);

            //Read() method:
            Console.WriteLine("Enter your grade here: ");
            int grade = Console.Read(); //gives Ascii value
            Console.WriteLine("Your grade is {0} ",grade);

            Console.ReadKey();//if you write this line at the end of the program, it helps to prevent closing output console window immediatly, & holds the screen until you press enter
        }
        
    }

}
