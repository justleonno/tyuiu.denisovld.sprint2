using tyuiu.denisovld.sprint2.Task3.V19.Lib;

namespace tyuiu.denisovld.sprint2.Task3.V19.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = 4 + Math.Pow((3 / 1), 2);
            Assert.Equal(res, ds.Calculate(x));


        }
        [Fact]
        public void Test2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = Convert.ToDouble(14) / Convert.ToDouble(9);
            res = Math.Round(res, 3);
            Assert.Equal(res, ds.Calculate(x));


        }
        [Fact]
        public void Test3()
        {
            DataService ds = new DataService();
            double x = -4;
            double res = Math.Pow(Convert.ToDouble(1) + (Convert.ToDouble(1)/Convert.ToDouble(16)), Convert.ToDouble(-4));
            res = Math.Round(res, 3);
            Assert.Equal(res, ds.Calculate(x));


        }
        [Fact]
        public void Test4()
        {
            DataService ds = new DataService();
            double x = -25;
            double res = x + x * 10 - (1/x);
            res = Math.Round(res, 3);
            Assert.Equal(res, ds.Calculate(x));


        }
    }

}