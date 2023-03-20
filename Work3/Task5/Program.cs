using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int maxNumber = int.Parse(Console.ReadLine());

            Random r = new Random();
            int rNumber = r.Next(maxNumber);

            Console.WriteLine($"Угадайте загаданное компьютером число от 0 до {maxNumber} ");

            while (true)
            {
                string a = (Console.ReadLine());
                if (a == "")
                {
                    Console.WriteLine($"Загаданным числом было {rNumber}");
                    break;
                }

                int b = int.Parse(a);
                if (rNumber == b)
                {
                    Console.WriteLine("Поздравляю вы угадали!");
                    break;
                }
                else if (rNumber < b)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                else if (rNumber > b)
                {
                    Console.WriteLine("Загаданное число больше");
                }
            }
        }
    }
}
