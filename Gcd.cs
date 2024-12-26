using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Gcd
    {
        public static void gcd()
        {
            Console.WriteLine("Enter the number A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number B: ");
            int b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine(a);
        }
    }
}
