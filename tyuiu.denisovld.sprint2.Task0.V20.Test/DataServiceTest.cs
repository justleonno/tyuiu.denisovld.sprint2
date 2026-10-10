namespace tyuiu.denisovld.sprint2.Task0.V20.Test
{
    using tyuiu.denisovld.sprint2.Task0.V20.Lib;
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int x = 1075;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] exp = new bool[6] { true, false, true, false, true, false };
            Assert.Equal(res, exp);

        }
    }
}