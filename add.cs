using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class add
    {
        public static int add1()
        {
            Console.WriteLine("Enter a number x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number Y: ");
            int y = int.Parse(Console.ReadLine());


            return x + y;
        }
    }
}
