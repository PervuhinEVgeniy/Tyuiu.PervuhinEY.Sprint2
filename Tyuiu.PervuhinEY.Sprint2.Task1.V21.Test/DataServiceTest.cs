using Tyuiu.PervuhinEY.Sprint2.Task1.V21.Lib;

namespace Tyuiu.PervuhinEY.Sprint2.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations1()
        {
            DataService ds = new DataService();
            int a = 696;
            int b = 987;
            int c = 696;
            int d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
