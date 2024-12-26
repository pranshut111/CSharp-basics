using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Squareofnumber
    {
       public static void squareOfnumber()
        {
            Console.WriteLine(" Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("the square of number is " + n * n);
        }
    }
}
