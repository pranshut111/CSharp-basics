using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Leapyear
    {
       public static void leapYear()
        {
            Console.WriteLine("Enter the year: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 4 == 0 && (n % 100 != 0 || n % 400 == 0))
            {
                Console.WriteLine("The year is a leap year");
            }
            else
            {
                Console.WriteLine("The year is not a leap year");
            }
        }
    }
}
