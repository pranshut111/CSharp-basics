using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Strlen
    {
        public static void strLen()
        {
            Console.WriteLine("Enter a string : ");
            string s = Console.ReadLine();
            char[] chars = s.ToCharArray();
            int count = 0;
            foreach (var item in chars)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
