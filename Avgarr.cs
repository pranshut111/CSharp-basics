using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Avgarr
    {
        public static void avgArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int sum = 0; int avg = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            avg = sum / arr.Length;
            Console.WriteLine("the avg of array is " + avg);
        }
    }
}
