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
            string res = "понедельник";
            Assert.AreEqual(res, ds.FindDayName(1));
        }
        [TestMethod]
        public void Test2()
        {
            DataService ds = new DataService();
            string res = "вторник";
            Assert.AreEqual(res, ds.FindDayName(2));
        }
        [TestMethod]
        public void Test3()
        {
            DataService ds = new DataService();
            string res = "среда";
            Assert.AreEqual(res, ds.FindDayName(3));
        }
        [TestMethod]
        public void Test4()
        {
            DataService ds = new DataService();
            string res = "четверг";
            Assert.AreEqual(res, ds.FindDayName(4));

        }
        [TestMethod]
        public void Test5()
        {
            DataService ds = new DataService();
            string res = "пятница";
            Assert.AreEqual(res, ds.FindDayName(5));
        }
        [TestMethod]
        public void Test6()
        {
            DataService ds = new DataService();
            string res = "суббота";
            Assert.AreEqual(res, ds.FindDayName(6));
        }
        [TestMethod]
        public void Test7()
        {
            DataService ds = new DataService();
            string res = "воскресенье";
            Assert.AreEqual(res, ds.FindDayName(7));
        }
    }
}