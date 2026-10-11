namespace tyuiu.denisovld.sprint2.Task2.V1.Test
{
    using tyuiu.denisovld.sprint2.Task2.V1.Lib;
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 8;
            bool lol = ds.CheckDotInShadedArea(x, y);
            bool exp = true;
            Assert.Equal(exp, lol);


        }
    }
}