using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Arrsmallest
    {
       public  static void arrSmallest()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int small = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (small > arr[i])
                {
                    small = arr[i];
                }
            }
            Console.WriteLine("Largest element from the array : " + small);
        }
    }
}
