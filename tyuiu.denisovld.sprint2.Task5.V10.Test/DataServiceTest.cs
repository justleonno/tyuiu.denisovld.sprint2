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
            Assert.AreEqual("14.12.2001", ds.FindDateOfPreviousDay(2001, 12, 15));
            Assert.AreEqual("30.11.2001", ds.FindDateOfPreviousDay(2001, 12, 1));
            Assert.AreEqual("31.10.2001", ds.FindDateOfPreviousDay(2001, 11, 1));
            Assert.AreEqual("28.02.2001", ds.FindDateOfPreviousDay(2001, 3, 1));
            Assert.AreEqual("31.12.2000", ds.FindDateOfPreviousDay(2001, 1, 1));
            Assert.AreEqual("31.07.2001", ds.FindDateOfPreviousDay(2001, 8, 1));
            Assert.AreEqual("02.07.2001", ds.FindDateOfPreviousDay(2001, 7, 3));

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