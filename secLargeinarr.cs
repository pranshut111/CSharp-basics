using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class secLargeinarr
    {
      public  static void secondLargest()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Array.Sort(arr);
            int n = arr.Length;
            Console.WriteLine("The second largest is : " + arr[n - 2]);
        }
    }
}
