using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Simplecalc
    {
        public static void simpleCalculator()
        {
            Console.WriteLine("Enter the number A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "+": Console.WriteLine(a + b); break;
                case "-": Console.WriteLine(a - b); break;
                case "*": Console.WriteLine(a * b); break;
                case "/": Console.WriteLine(a / b); break;
                case "%": Console.WriteLine(a % b); break;
                default: break;
            }
        }
    }
}
