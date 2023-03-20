using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int Number = int.Parse(Console.ReadLine());
            int ostatok = Number-1;
            bool a = false;
            while (ostatok > 1)
            {
                //Console.WriteLine($"{ostatok}");
                a = (Number % ostatok == 0);
                //Console.WriteLine($"{a}");
                ostatok--;
                if (a == true)
                {
                    Console.WriteLine("Число не простое");
                    break;
                }
            }
            if (a == false)
                Console.WriteLine("Число простое");
        }
    }
}
