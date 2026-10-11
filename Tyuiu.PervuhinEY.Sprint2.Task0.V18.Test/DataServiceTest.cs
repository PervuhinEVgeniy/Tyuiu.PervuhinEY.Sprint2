using Tyuiu.PervuhinEY.Sprint2.Task0.V18.Lib;
namespace Tyuiu.PervuhinEY.Sprint2.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 5105;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}