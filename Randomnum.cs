using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Randomnum
    {
        public static void randomNO()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            Console.WriteLine($"Random number between 1 and 100: {randomNumber}");
        }
    }
}
