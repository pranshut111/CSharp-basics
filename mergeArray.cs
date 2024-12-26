using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class mergeArray
    {
       public static void merge()
        {
            int[] arr = { 2, 3, 4, 1, 2, 3 };
            int[] arr1 = { 2, 3, 4, 1, 2, 3 };
            printarr.PrintArray(arr1);
            printarr.PrintArray(arr);
            int[] result = new int[arr.Length + arr1.Length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result[j++] = arr[i];
            }
            for (int k = 0; k < arr1.Length; k++)
            {
                result[j++] = arr[k];
            }
            printarr.PrintArray(result);

        }
    }
}
