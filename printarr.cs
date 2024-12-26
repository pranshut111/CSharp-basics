using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class printarr
    {
       public  static void PrintArray(int[] array)
        {
            Console.Write("Array elements: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); // Move to the next line after printing
        }
    }
}
