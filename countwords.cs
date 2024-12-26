using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class countwords
    {
       public static void CountWords()
        {
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();
            string s1 = s.Trim();
            Console.WriteLine("The length of the string  is : " + s1.Length);
        }
    }
}
