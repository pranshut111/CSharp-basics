using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class ArrReverse
    {
       public static void arrReverse()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            int n = arr1.Length;
            for (int i = 0; i < arr1.Length / 2; i++)
            {
                int tempp = arr1[i];
                arr1[i] = arr1[n - 1 - i];
                arr1[n - 1 - i] = tempp;
            }

            for (int j = 0; j < n; j++)
            {
                Console.Write(arr1[j] + " ");
            }
        }
    }
}
