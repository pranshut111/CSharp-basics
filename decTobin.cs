using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class decTobin
    {
       public static void decTObin()
        {
            Console.Write("Enter a decimal number to convert to binary: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(decimalNumber, 2);
            Console.WriteLine($"Binary representation: {binary}");
        }
    }
}
