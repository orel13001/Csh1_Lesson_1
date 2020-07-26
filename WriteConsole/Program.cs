using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите свою фамилию: ");
            string secondName = Console.ReadLine();
            Console.Write("Введите свой город: ");
            string sity = Console.ReadLine();
            Print(firstName, secondName, sity);

            Console.ReadKey();
        }

        private static void Print(string firstName, string secondName, string sity)
        {
            string s = $"Имя: {firstName}; Фамилия: {secondName}; Город: {sity}";
            Console.CursorLeft = Math.Max(0, Console.WindowWidth / 2 - s.Length / 2);
            Console.WriteLine(s);

        }
    
    }
}
