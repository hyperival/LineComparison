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
            Console.WriteLine("Enter line 01 co-ordinates");
            Console.WriteLine("Enter start point of line  (x1) value in x axis");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter start points of line  (y1) value in y axis");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter end point of line (x2) value in x axis");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter end point of line (y2) value in y axis");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double Linelength_01 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Linelength calculated is :{0}", Linelength_01);
            Console.WriteLine("Enter line 02 co-ordinates");
            Console.WriteLine("Enter start point of line  (X1) value in x axis");
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter start points of line  (Y1) value in y axis");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter end point of line (X2) value in x axis");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter end point of line (Y2) value in y axis");
            double Y2 = Convert.ToDouble(Console.ReadLine());
            double Linelength_02 = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("Linelength calculated is :{0}", Linelength_02);
            if (Linelength_01.CompareTo(Linelength_02) == 0)
            {
                Console.WriteLine("Lines are equal");
            }
            else if (Linelength_01.CompareTo(Linelength_02) > 0)
            {
                Console.WriteLine("Line 01 is greater than line 02");
            }
            else
            {
                Console.WriteLine("Line 02 is greater than line 01");
            }
        }
    }
}