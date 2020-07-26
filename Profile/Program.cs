using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_IMB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите свою фамилию: ");
            string secondName = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свой рост (см): ");
            double height = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Введите свой вес (кг): ");
            int mas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstName + " " + secondName + " " + age + " " + height + " " + mas);
            Console.WriteLine("{0} {1} {2} {3} {4}", firstName, secondName, age, height, mas);
            Console.WriteLine($"{firstName} {secondName} {age} {height} {mas}");

            double imb = mas / (height * height);
            Console.WriteLine($"Рост: {height} м., Масса: {mas} кг., ИМТ: {imb}");

            Console.ReadKey();

        }
    }
}
