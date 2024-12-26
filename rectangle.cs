using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class rectangle
    {
       public static void perimeterRectangle()
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            double perimeter = 2 * (length + width);
            Console.WriteLine($"Perimeter of the rectangle: {perimeter}");
        }
       public static void areaRectangle()
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            Console.WriteLine($"Area of the rectangle: {area}");
        }

    }
}
