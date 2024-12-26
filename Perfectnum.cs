using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Perfectnum
    {
       public static void perfectNumber()
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int a = n;
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (a == sum)
            {
                Console.WriteLine("perfect number");
            }
            else
            {
                Console.WriteLine("Not a perfect number");
            }
        }
    }
}
