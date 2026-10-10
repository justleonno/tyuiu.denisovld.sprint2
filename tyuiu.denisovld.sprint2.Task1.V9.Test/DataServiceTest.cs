namespace tyuiu.denisovld.sprint2.Task1.V9.Test
{
    using tyuiu.denisovld.sprint2.Task1.V9.Lib;
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int a = 15;
            int b = 335;
            int c = 174;
            int d = 478;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] exp = new bool[6] { false, false, true, false, true, false };
            Assert.Equal(res, exp);

        }
    }
}