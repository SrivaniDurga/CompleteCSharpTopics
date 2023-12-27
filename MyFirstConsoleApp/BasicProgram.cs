//Always program exicution starts from Main Method.Wherever you write Main()
//Method in your program , from that place only program excutes.so in this example, before Main() method,Main1() is written.but complier checks only for Main() method.
//so directly it excutes Main() method first and after that we call Main1() method in Main()
//method. so compiler now enters into that method and excutes that one.

//BASIC PROGRAM 
namespace MyFirstConsoleApp
{
    class BasicProgram
    {
        public static void Main1()
        {
            Console.WriteLine("Hello, .NET!");
        }
        public static void Main()
        {
            Console.WriteLine("Hello, World!");
            Main1();
        }
    }
}

