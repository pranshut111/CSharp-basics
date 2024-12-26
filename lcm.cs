using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class lcm
    {
       public static void Lcm()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int lcm = (num1 > num2) ? num1 : num2;
            while (true)
            {
                if (lcm % num1 == 0 && lcm % num2 == 0)
                {
                    Console.WriteLine($"LCM of {num1} and {num2} is {lcm}");
                    break;
                }
                lcm++;
            }
        }
    }
}
