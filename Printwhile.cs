using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Printwhile
    {
       public static void printWhile()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= num)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
