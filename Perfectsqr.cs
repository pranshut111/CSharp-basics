using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Perfectsqr
    {
       public static void perfectsqr()
        {
            Console.Write("Enter a number to check if it is a perfect square: ");
            int number = int.Parse(Console.ReadLine());
            int sqrt = (int)Math.Sqrt(number);
            if (sqrt * sqrt == number)
            {
                Console.WriteLine($"{number} is a perfect square.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect square.");
            }
        }
    }
}
