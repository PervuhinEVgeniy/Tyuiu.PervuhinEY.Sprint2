using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PervuhinEY.Sprint2.Task0.V18.Lib
{
    public class DataService : ISprint2Task0V18
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y + 4631;
            res[1] = x != y;
            res[2] = y + 46301 > x;
            res[3] = x > y;
            res[4] = x <= y + 4630;
            res[5] = y >= x;

            return res;
        }
    }
}
