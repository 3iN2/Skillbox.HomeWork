using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Переменные
            string fullName = "Ruslan";      //имя человека
            string lastName = "Sopin";       //фамилия человека
            string patronymic = "Sergeevih"; //отчество человека
            string Email = "qwerty@mail.ru"; //электронная почта

            int age = 28;                    //сколько лет


            double pointProgramming = 71.75; //балл по программированию
            double pointMathematics = 76.3;  //балл по математике
            double pointPhysics = 65.33;     //балл по физике

            double amountPoint; //Сумма баллов всех предметов
            double arithmeticMean; //Среднее арифметическое
            #endregion

            #region Команда вывода значений в консоль
            Console.WriteLine(
                              $" Имя: {fullName}\n " +
                              $"Фамилия: {lastName}\n " +
                              $"Отчество: {patronymic}\n " +
                              $"Электронная почта: {Email}\n " +
                              $"Сколько лет: {Convert.ToString(age)}\n " +
                              $"Балл по программированию: {Convert.ToString(pointProgramming)}\n " +
                              $"Балл по математике: {Convert.ToString(pointMathematics)}\n " +
                              $"Балл по физике: {Convert.ToString(pointPhysics)} "
                              ) ;

            Console.ReadKey();

            amountPoint = pointProgramming + pointMathematics + pointPhysics;
            arithmeticMean = amountPoint / 3;

            string amountPointText = amountPoint.ToString("#.#"); //Переменная для сокращение написания дробного числа (Суммарного балла)
            string arithmeticMeanText = arithmeticMean.ToString("#.###"); //Переменная для сокращение написания дробного числа (Среднего арифметического)

            Console.WriteLine(
                              $" Суммарный бал: {amountPointText}\n " +
                              $"Среднее арифметическое: {arithmeticMeanText}" 
                              );
            Console.ReadKey();
            #endregion

        }




    }
}
