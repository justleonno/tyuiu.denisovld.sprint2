using tyuiu.denisovld.sprint2.Task4.V14.Lib;
namespace tyuiu.denisovld.sprint2.Task4.V14.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 1;
            double res = ds.Calculate(x, y);
            double exp = Math.Pow((2 + 1 / Math.Pow(x, 2)), y);
            exp = Math.Round(exp, 3);
            Assert.Equal(res, exp);
            
        }
        [Fact]
        public void Test2()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 1;
            double res = ds.Calculate(x, y);
            double exp = (Math.Pow(y, 2) - Math.Pow(Math.Cos(x), 2) + 10) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(y), 2) + 12);
            exp = Math.Round(exp, 3);
            Assert.Equal(res, exp);

        }
    }
}