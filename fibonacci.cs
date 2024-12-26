using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class fibonacci
    {
        public static void fibbonacci()
        {
            int a = 10;
            int first = 0; int second = 1;
            int next;
            //Console.WriteLine(fibb);
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(first);
                next = first + second;
                first = second;
                second = next;

            }
        }
    }
}
