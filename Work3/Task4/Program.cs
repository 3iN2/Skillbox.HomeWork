using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько чисел в вашей последовательности:");
            int length = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Введите число: ");
                int Number = int.Parse(Console.ReadLine());

                bool a = (Number < minNumber);

                if (a == true)
                {
                    minNumber = Number;
                    Console.WriteLine($"Минимальное число {minNumber}");
                }
                else if (a == false)
                {
                    Console.WriteLine($"Есть число меньше это {minNumber}");
                }
            }



        }
    }
}
