using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PervuhinEY.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            if (k < 1 || k > 365 || d < 1 || d > 7)
            {
                throw new ArgumentException("Некорректные входные данные");
            }
            int dayOfWeek = ((k - 1) + (d - 1)) % 7 + 1;
            switch (dayOfWeek)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: throw new ArgumentException("Ошибка вычисления");
            }
        }
    }
}
