using System;
using Tyuiu.PervuhinEY.Sprint2.Task2.V8.Lib;

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
            Console.WriteLine("* Задание #2                                                       *");
            Console.WriteLine("* Вариант #8                                                       *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                         *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с      *");
            Console.WriteLine("* клавиатуры и вычисляет находится ли точка с координатами X,Y     *");
            Console.WriteLine("* в заштрихованной области*                                        *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds1 = new DataService();
            bool res = ds1.CheckDotInShadedArea(x, y);


            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат                                                        *");
            Console.WriteLine("********************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
       
        }
    }
}
