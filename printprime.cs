using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class printprime
    {
       public static void printPrime()
        {
            Console.Write("Enter a number to list prime numbers up to it: ");
            int upperLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers:");
            for (int i = 2; i <= upperLimit; i++)
            {
                if (isprime.IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
