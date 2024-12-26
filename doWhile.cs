using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class doWhile
    {
       public static void dowhile()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            do
            {
                Console.WriteLine($"Count: {count}");
                count++;
            } while (count < num);
        }
    }
}
