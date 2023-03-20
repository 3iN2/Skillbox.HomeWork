using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день игрок. Сколько у вас на руках карт? ");
            int numberСards = int.Parse(Console.ReadLine());
            int sum = 0;
            int Number = 0;
            Console.WriteLine("Введите наминал каждой карты.\nДля карт наминалом выше 10 используйте следующие обозначения:\n Валет - J\n Дама - Q\n Король - K\n Туз - T");

            for (int i = 1; i <= numberСards; i++)
            {
                string priceCard = (Console.ReadLine());
                switch (numberСards)
                {

                    case 1:
                        {
                            if (priceCard == "J")
                                sum = sum + 10;
                             else if (priceCard == "Q")
                                sum = sum + 10;
                             else if (priceCard == "K")
                                sum = sum + 10;
                             else if (priceCard == "T")
                                sum = sum + 10;
                             else
                                Number = int.Parse(priceCard);
                                sum = sum + Number;
                             break;

                        }
                    case 2:
                        {
                            if (priceCard == "J")
                                sum = sum + 10;
                            else if (priceCard == "Q")
                                sum = sum + 10;
                            else if (priceCard == "K")
                                sum = sum + 10;
                            else if (priceCard == "T")
                                sum = sum + 10;
                            else
                                Number = int.Parse(priceCard);
                                sum = sum + Number;
                            break;
                        }
                    case 3:
                        {
                            if (priceCard == "J")
                                sum = sum + 10;
                            else if (priceCard == "Q")
                                sum = sum + 10;
                            else if (priceCard == "K")
                                sum = sum + 10;
                            else if (priceCard == "T")
                                sum = sum + 10;
                            else
                                Number = int.Parse(priceCard);
                                sum = sum + Number;
                            break;
                        }
                    case 4:
                        {
                            if (priceCard == "J")
                                sum = sum + 10;
                            else if (priceCard == "Q")
                                sum = sum + 10;
                            else if (priceCard == "K")
                                sum = sum + 10;
                            else if (priceCard == "T")
                                sum = sum + 10;
                            else
                                Number = int.Parse(priceCard);
                                sum = sum + Number;
                            break;
                        }
                    case 5:
                        {
                            if (priceCard == "J")
                                sum = sum + 10;
                            else if (priceCard == "Q")
                                sum = sum + 10;
                            else if (priceCard == "K")
                                sum = sum + 10;
                            else if (priceCard == "T")
                                sum = sum + 10;
                            else
                                Number = int.Parse(priceCard);
                                sum = sum + Number;
                            break;
                        }
                    case 6:
                        {
                            if (priceCard == "J")
                                sum = sum + 10;
                            else if (priceCard == "Q")
                                sum = sum + 10;
                            else if (priceCard == "K")
                                sum = sum + 10;
                            else if (priceCard == "T")
                                sum = sum + 10;
                            else
                                Number = int.Parse(priceCard);
                                sum = sum + Number;
                            break;
                        }
                }
            }
            Console.WriteLine($"Суммарный наминал ваших карт  = {sum}");
            Console.ReadKey();
        }
    }
}
