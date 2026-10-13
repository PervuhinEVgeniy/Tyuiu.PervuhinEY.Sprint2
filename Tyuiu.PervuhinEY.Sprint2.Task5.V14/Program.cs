using System;
using Tyuiu.PervuhinEY.Sprint2.Task5.V14.Lib;

namespace Tyuiu.PervuhinEY.Sprint2.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Первухин Е. Ю.| АСОиУБ-26-1";
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Спринт #2                                                        *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                 *");
            Console.WriteLine("* Задание #5                                                       *");
            Console.WriteLine("* Вариант #14                                                      *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                         *");
            Console.WriteLine("* Написать программу, которая определяет день недели по дню года   *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
            Console.WriteLine("********************************************************************");

            Console.Write("Введите номер дня года (от 1 до 365): ");
            int k = Convert.ToInt32(Console.ReadLine());

   
            Console.Write("Введите день недели 1 января (от 1 - Пн до 7 - Вс): ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат                                                        *");
            Console.WriteLine("********************************************************************");
            try
            {
                string res = ds.FindDayName(k, d);
                Console.WriteLine($"День недели для {k}-го дня года: {res}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}