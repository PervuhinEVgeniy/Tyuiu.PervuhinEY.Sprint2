using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PervuhinEY.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            bool blok1 = (x >= 3 && x <= 5 && y >= 3 && y <= 7);
            bool blok2 = (x >= 6 && x <= 9 && y >= 9 && y <= 11);
            bool blok3 = (x >= 9 && x <= 11 && y >= 2 && y <= 4);
            bool blok4 = (x >= 6 && x <= 9 && y >= 5 && y <= 6);
            bool blok5 = (x >= 10 && x <= 13 && y >= 6 && y <= 7);
            bool blok6 = (x >= 12 && x <= 13 && y >= 8 && y <= 9);
            bool line1 = (y == 11 && x >= 3 && x <= 5);
            bool line2 = (x == 6 && y >= 7 && y <= 8);
            bool line3 = (x == 9 && y >= 7 && y <= 8);
            bool line4 = (y == 12 && x >= 7 && x <= 9);
            bool block1 = (x == 12 && y == 3);
            bool block2 = (x == 14 && y == 7);

            if (blok1 || block2 || blok3 || blok3 || blok4 || blok5 || blok6 || line1 || line2 || line3 || line4 || block1 || block2)
            {
                res = true;

            }
            else
            {
                res = false;
            }
            return res;


        }
    }

}

