using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class CopyCons2
    {
        string name, CompanyName;
        int JoiningDate;
        public CopyCons2(string n, string cn, int jd) //Parametarized Constructor
        {
            name = n;
            CompanyName = cn;
            JoiningDate = jd;
        }
        public CopyCons2(CopyCons2 obj)
        {
            name = obj.name;
            CompanyName = obj.CompanyName;
            JoiningDate = obj.JoiningDate;
        }
        public void Display()
        {
            Console.WriteLine(name + " is selected in " + CompanyName+" and her joinin date is "+JoiningDate);
        }
        static void Main(string[] args)
        {
            
            CopyCons2 cs1 = new CopyCons2("Srivani", "DWP Global Corp", 6);
            CopyCons2 cs2 = new CopyCons2(cs1);
            cs1.Display();
          
            cs1.name = "Jagadeesh";
            cs2.Display();
            Console.WriteLine(cs1.name);
            Console.WriteLine(cs2.name);

        }
    }
}
