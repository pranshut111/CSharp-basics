using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class StrtoInt
    {
       public static void strToint()
        {
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
            Console.WriteLine(a);
        }
    }
}
