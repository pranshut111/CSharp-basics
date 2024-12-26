using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Asciivalue
    {
      public  static void asciiValue()
        {
            Console.Write("Enter a single character: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int ascii = (int)input;
            Console.WriteLine(ascii);
        }
    }
}
