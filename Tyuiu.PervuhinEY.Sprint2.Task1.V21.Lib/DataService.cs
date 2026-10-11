using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PervuhinEY.Sprint2.Task1.V21.Lib
{
    public class DataService : ISprint2Task1V21
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b);

            res[1] = (a + 2 > b);

            res[2] = (a > b) || (c < d);

            res[3] = (a + 2 > b) && (c < d);

            res[4] = !(res[0]);

            res[5] = (a > b) ^ (c < d);

            return res;
        }
    }
}
