using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
	internal class largest
	{
		public static void largest1()
		{
            Console.WriteLine("Enter a number: ");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter a number: ");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter a number: ");
			int c = int.Parse(Console.ReadLine());
			if (a > b && a > c)
			{
				Console.WriteLine("The largest number is :" + a);
			}
			else if (b > a && b > c)
			{
				Console.WriteLine("The largest number is : " + b);
			}
			else if (c > a && c > b)
			{
				Console.WriteLine("The largest number is : " + c);
			}
			else
			{
				Console.WriteLine("All numbers are equal");
			}
		}
	}
}