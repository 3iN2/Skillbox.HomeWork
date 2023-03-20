using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1. Определение является число четным или нет.
            while (true)
            {
                Console.WriteLine("Введите число для проверки: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine($"Ваше число четное");
                    continue;
                }
                else
                {
                    Console.WriteLine("Ваше число нечетное");
                    continue;
                }
            }
            #endregion
        }
    }
}
