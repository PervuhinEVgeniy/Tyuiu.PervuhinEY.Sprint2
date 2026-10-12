using System;
using Tyuiu.PervuhinEY.Sprint2.Task3.V1.Lib;

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
            Console.WriteLine("* Задание #3                                                       *");
            Console.WriteLine("* Вариант #1                                                       *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                         *");
            Console.WriteLine("* Написать программу на, которая запрашивает значение x            *");
            Console.WriteLine("* и вычисляет згачение по формуле                                  *");
            Console.WriteLine("*                                                                  *");
            Console.WriteLine("*      {e^x - 12x + cos(x)    ; есди x > 0                         *");
            Console.WriteLine("*      {x + (15/x)            ; если x = 2                         *");
            Console.WriteLine("*  y = {x + 10x - (1/x)       ; если -5 < x < 3                    *");
            Console.WriteLine("*      {x + 10x -(1/(x^3 + 3)); если x < -5                        *");
            Console.WriteLine("*                                                                  *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToInt32(Console.ReadLine());

            DataService ds2 = new DataService();
            double res = ds2.Calculate(x);
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат                                                        *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine($" Значение Y =  {res:F3}");
            Console.ReadKey();

        }
    }
}