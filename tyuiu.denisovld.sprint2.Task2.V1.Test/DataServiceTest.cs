using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint2.Task2.V1.Lib;
namespace tyuiu.denisovld.sprint2.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test1()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 8;
            bool lol = ds.CheckDotInShadedArea(x, y);
            bool exp = true;
            Assert.AreEqual(exp, lol);


        }
    }
}