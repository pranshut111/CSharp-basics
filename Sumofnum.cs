using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Sumofnum
    {
       public static void sumOfnumber()
        {
            int a = 101012;
            int n = a;
            int sum = 0;
            while (a > 0)
            {
                int temp = a % 10;
                sum += temp;
                a /= 10;
            }
            Console.WriteLine("The sum of " + n + " is " + sum);
        }
    }
}
