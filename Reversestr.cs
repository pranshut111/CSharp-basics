using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Reversestr
    {
      public  static void reverseString()
        {
            Console.WriteLine("Enter the String : ");
            String s = Console.ReadLine();
            //String s = "Pranshu";
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length / 2; i++)
            {
                char c = ch[i];
                ch[i] = ch[ch.Length - 1 - i];
                ch[ch.Length - 1 - i] = c;
            }
            string sh = new string(ch);
            Console.WriteLine(sh);
        }
    }
}
