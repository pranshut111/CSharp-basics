using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class CountVowels
    {
        static void countVowels()
        {
            Console.WriteLine("Enter a name : ");
            string name = Console.ReadLine();
            char[] chars = name.ToCharArray();
            int COUNT = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                switch (c)
                {
                    case 'a': COUNT++; break;
                    case 'e': COUNT++; break;
                    case 'i': COUNT++; break;
                    case 'o': COUNT++; break;
                    case 'u': COUNT++; break;
                    case 'A': COUNT++; break;
                    case 'E': COUNT++; break;
                    case 'I': COUNT++; break;
                    case 'O': COUNT++; break;
                    case 'U': COUNT++; break;
                    default: break;
                }
            }
            Console.WriteLine("THE NUMBER OF VOWELS ARE: " + COUNT);
        }
    }
}
