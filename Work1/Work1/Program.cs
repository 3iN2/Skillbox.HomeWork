using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    internal class Program
    {
        /// <summary>
        /// Код который выполняется в первую очередь
        /// </summary>
        /// <param name="args">параметры запуска</param>
        static void Main(string[] args)
        {
            #region "Привет мир" через Write Line
            Console.WriteLine("Привет мир!!!"); //Задание 1
            Console.ReadKey();
            #endregion

            #region "Привет мир" через Write
            Console.Write("Привет "); //Задание 2
            Console.Write("мир ");
            Console.Write("!!!");
            Console.ReadKey();
            #endregion
        }
    }
}
