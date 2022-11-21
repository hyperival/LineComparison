using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to line comparision problem");
            Console.WriteLine("Enter start point of line  (x1) value in x axis");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter start points of line  (y1) value in y axis");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter end point of line (x2) value in x axis");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter end point of line (y2) value in y axis");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double lineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Linelength calculated is :" + lineLength);
        }
    }
}