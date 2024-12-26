using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Armstrong
    {
       public  static void armStrong()
        {
            Console.Write("Enter a number to check if it is an Armstrong number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, temp = num;
            int digitCount = num.ToString().Length;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digitCount);
                temp /= 10;
            }
            if (sum == num)
            {
                Console.WriteLine($"{num} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{num} is not an Armstrong number.");
            }
        }
    }
}
