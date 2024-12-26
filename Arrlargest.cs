using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Arrlargest
    {
       public static void arrLargest()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int lar = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (lar < arr[i])
                {
                    lar = arr[i];
                }
            }
            Console.WriteLine("Largest element from the array : " + lar);
        }

    }
}
