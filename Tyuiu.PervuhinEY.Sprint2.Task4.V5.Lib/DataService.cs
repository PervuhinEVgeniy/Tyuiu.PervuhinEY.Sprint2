using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PervuhinEY.Sprint2.Task4.V5.Lib
{
    public class DataService : ISprint2Task4V5
    {
        public double Calculate(double x, double y)
        {
            double Z = x > y + 5 ? (y * Math.Pow((x + 2) / (y + 5), x)) : (Math.Pow(x, 2) + 10 * x + (1.0 / y));
            return Math.Round(Z, 3);

        }
    }
}
