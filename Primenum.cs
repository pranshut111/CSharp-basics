using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Primenum
    {
      public   static void prime()
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (a <= 1)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    isPrime = false;

                }
            }
            if (isPrime)
            {
                Console.WriteLine("The number is " + a + " is Prime");
            }
            else
            {
                Console.WriteLine("The number " + a + " is not Prime");
            }
        }
    }
}
