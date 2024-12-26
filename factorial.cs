using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class factorial
    {
        public static void fact()
        {
            
                int n = 5;
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                Console.WriteLine("The factorial of" + n + " is " + fact);
            
        }
    }
}
