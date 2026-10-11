using System;
// Убедитесь, что здесь правильное пространство имен вашего DataService
using Tyuiu.PervuhinEY.Sprint2.Task1.V21.Lib;

namespace Tyuiiu.PervuhinEY.Sprint2.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            // Исходные данные из условия Варианта 21
            int a = 696;
            int b = 987;
            int c = 696;
            int d = 155;

            // Получаем массив логических значений
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            // Вывод оформления (как на вашем скриншоте)
            Console.WriteLine("**********************************************");
            Console.WriteLine("** ИСХОДНЫЕ ДАННЫЕ:                         **");
            Console.WriteLine("**********************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("**********************************************");
            Console.WriteLine("** РЕЗУЛЬТАТ:                               **");
            Console.WriteLine("**********************************************");

            // Цикл для вывода всех 6 элементов массива
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}