using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PervuhinEY.Sprint2.Task5.V14.Lib;
namespace Tyuiu.PervuhinEY.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();


            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Понедельник", ds.FindDayName(8, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(1, 2));
            Assert.AreEqual("Вторник", ds.FindDayName(2, 1));
            Assert.AreEqual("Среда", ds.FindDayName(1, 3));
            Assert.AreEqual("Среда", ds.FindDayName(3, 1));
            Assert.AreEqual("Четверг", ds.FindDayName(1, 4));
            Assert.AreEqual("Четверг", ds.FindDayName(4, 1));
            Assert.AreEqual("Пятница", ds.FindDayName(1, 5));
            Assert.AreEqual("Пятница", ds.FindDayName(5, 1));
            Assert.AreEqual("Суббота", ds.FindDayName(1, 6));
            Assert.AreEqual("Суббота", ds.FindDayName(6, 1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(1, 7));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));
            Assert.AreEqual("Понедельник", ds.FindDayName(365, 1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(365, 7));
        }

        [TestMethod]
        public void InvalidDayOfYear()
        {
            DataService ds = new DataService();

            try
            {
                ds.FindDayName(0, 1);
                Assert.Fail("Ожидалось исключение ArgumentException");
            }
            catch (ArgumentException) { }

            try
            {
                ds.FindDayName(366, 1);
                Assert.Fail("Ожидалось исключение ArgumentException");
            }
            catch (ArgumentException) { }
        }
    }
    
}
