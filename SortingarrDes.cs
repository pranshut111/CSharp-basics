using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class SortingarrDes
    {
       public static void sortingDsc()
        {
            int[] arr = { 2, 3, 4, 1, 2, 3 };
            printarr.PrintArray(arr);
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                // PrintArray(arr);
            }
            Console.WriteLine(" Final sorted array : ");
            printarr.PrintArray(arr);
        }
    }
}
