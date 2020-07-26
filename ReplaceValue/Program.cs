using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("val_1=");
            double val1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("val_2=");
            double val2 = Convert.ToDouble(Console.ReadLine());
            double buf = val1;
            val1 = val2;
            val2 = buf;
            Console.WriteLine($"val_1={val1}; val_2={val2}");

            val1 = val1 + val2;
            val2 = val1 - val2;
            val1 = val1 - val2;
            Console.WriteLine($"val_1={val1}; val_2={val2}");

            Console.ReadKey();
        }
    }
}
