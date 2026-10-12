using System;
using Tyuiu.PervuhinEY.Sprint2.Task4.V5.Lib;

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
            Console.WriteLine("* Задание #4                                                       *");
            Console.WriteLine("* Вариант #8                                                       *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                         *");
            Console.WriteLine("* Написать программу на, которая запрашивает значение x            *");
            Console.WriteLine("* и вычисляет згачение по формуле                                  *");
            Console.WriteLine("* если x > y + 5, то z = y((x+2)/(y+5))^x иначе x^2 + 10x + (1/y)  *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = Convert.ToInt32(Console.ReadLine());

            DataService ds2 = new DataService();
            double res = ds2.Calculate(x,y);
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат                                                        *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine($" Значение Y =  {res:F3}");
            Console.ReadKey();

        }
    }
}