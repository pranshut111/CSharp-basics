using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class sumN
    {
       public static void sumNnatural()
        {
            Console.Write("Enter a number for sum calculation: ");
            int n = int.Parse(Console.ReadLine());
            int sum = n * (n + 1) / 2;

            Console.WriteLine($"Sum of first {n} natural numbers is {sum}");
        }
    }
}
