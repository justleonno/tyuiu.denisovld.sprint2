using tyuiu.denisovld.sprint2.Task7.V3.Lib;
namespace tyuiu.denisovld.sprint2.Task7.V3.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.7;
            bool exp = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.Equal(exp, res);

        }
    }
}