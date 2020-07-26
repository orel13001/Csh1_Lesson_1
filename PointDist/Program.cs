using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double dist = GetDist(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками ({x1};{y1}) и ({x2};{y2}): {dist:F2}");

            Console.ReadKey();
        }

        private static double GetDist(double x1, double y1, double x2, double y2)
        {
            return (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }
    }
    
}
