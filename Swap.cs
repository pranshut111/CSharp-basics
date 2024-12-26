using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Swap
    {
       public static void swap()
        {
            Console.WriteLine("Enter a number A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number B: ");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swaping\nA becomes: " + a + "\nB becomes : " + b);
        }
    }
}
