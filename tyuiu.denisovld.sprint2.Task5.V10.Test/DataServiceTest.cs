using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint2.Task5.V10.Lib;

namespace tyuiu.denisovld.sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("2001.12.14", ds.FindDateOfPreviousDay(2001, 12, 15));
            Assert.AreEqual("2001.11.30", ds.FindDateOfPreviousDay(2001, 12, 1));
            Assert.AreEqual("2001.10.31", ds.FindDateOfPreviousDay(2001, 11, 1));
            Assert.AreEqual("2001.2.28", ds.FindDateOfPreviousDay(2001, 3, 1));
            Assert.AreEqual("2000.12.31", ds.FindDateOfPreviousDay(2001, 1, 1));
            Assert.AreEqual("2001.7.31", ds.FindDateOfPreviousDay(2001, 8, 1));
            Assert.AreEqual("2000.12.31", ds.FindDateOfPreviousDay(2001, 1, 1));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2001, 13, 1);
            });


            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2001, 11, -1);
            });


            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2001, 0, 6);
            });


            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2001, 11, 32);
            });

        }
    }
}