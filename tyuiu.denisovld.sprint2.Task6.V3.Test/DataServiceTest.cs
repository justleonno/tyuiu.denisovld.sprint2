using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint2.Task6.V3.Lib;
namespace tyuiu.denisovld.sprint2.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test1()
        {
            DataService ds = new DataService();
            string res = "Понедельник";
            Assert.AreEqual(res, ds.FindDayName(1));
        }
        [TestMethod]
        public void Test2()
        {
            DataService ds = new DataService();
            string res = "Вторник";
            Assert.AreEqual(res, ds.FindDayName(2));
        }
        [TestMethod]
        public void Test3()
        {
            DataService ds = new DataService();
            string res = "Среда";
            Assert.AreEqual(res, ds.FindDayName(3));
        }
        [TestMethod]
        public void Test4()
        {
            DataService ds = new DataService();
            string res = "Четверг";
            Assert.AreEqual(res, ds.FindDayName(4));

        }
        [TestMethod]
        public void Test5()
        {
            DataService ds = new DataService();
            string res = "Пятница";
            Assert.AreEqual(res, ds.FindDayName(5));
        }
        [TestMethod]
        public void Test6()
        {
            DataService ds = new DataService();
            string res = "Суббота";
            Assert.AreEqual(res, ds.FindDayName(6));
        }
        [TestMethod]
        public void Test7()
        {
            DataService ds = new DataService();
            string res = "Воскресенье";
            Assert.AreEqual(res, ds.FindDayName(7));
        }
    }
}