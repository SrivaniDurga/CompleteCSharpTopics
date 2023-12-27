using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ESCAPE SEQUENCES IN C#
namespace MyFirstConsoleApp
{
    internal class EscapeSequences
    {
        static void Main(string[] args)
        {
            string name = "One\nTwo\nThree"; //prints in new line
            Console.WriteLine(name);
            string location = "C:\\CSharp\\MyFirstConsoleApp\\EscapeSequence";//it'll consider it as a single back slash
            Console.WriteLine(location);
            string location1 = @"C:\\CSharp\\MyFirstConsoleApp\\EscapeSequence";//now it'll consider it as a double slash
            Console.WriteLine(location1);
        }
    }
}
