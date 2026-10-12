using Tyuiu.PervuhinEY.Sprint2.Task4.V5.Lib;

namespace Tyuiu.PervuhinEY.Sprint2.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 71.031;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 75.200;
            Assert.AreEqual(wait, res);

        }
    }

}
