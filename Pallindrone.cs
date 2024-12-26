using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Pallindrone
    {
        public static void pallindroneStr()
        {
            Console.WriteLine("Enter the string : ");
            string s = Console.ReadLine();
            int n = s.Length;
            char[] chars = s.ToCharArray();
            bool ispallin = true;
            for (int i = 0; i < chars.Length / 2; i++)
            {
                if (chars[i] != chars[n - 1 - i])
                {
                    ispallin = false; break;
                }
            }

            if (ispallin)
            {
                Console.WriteLine("The string is pallindrone");
            }
            else
            {
                Console.WriteLine("The string is not Pallindrone");
            }
        }
    }
}
