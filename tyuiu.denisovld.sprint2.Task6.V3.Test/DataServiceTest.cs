using tyuiu.denisovld.sprint2.Task6.V3.Lib;
namespace tyuiu.denisovld.sprint2.Task6.V3.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            string res = "Понедельник";
            Assert.Equal(res, ds.FindDayName(1));
        }
        [Fact]
        public void Test2()
        {
            DataService ds = new DataService();
            string res = "Вторник";
            Assert.Equal(res, ds.FindDayName(2));
        }
        [Fact]
        public void Test3()
        {
            DataService ds = new DataService();
            string res = "Среда";
            Assert.Equal(res, ds.FindDayName(3));
        }
        [Fact]
        public void Test4()
        {
            DataService ds = new DataService();
            string res = "Четверг";
            Assert.Equal(res, ds.FindDayName(4));

        }
        [Fact]
        public void Test5()
        {
            DataService ds = new DataService();
            string res = "Пятница";
            Assert.Equal(res, ds.FindDayName(5));
        }
        [Fact]
        public void Test6()
        {
            DataService ds = new DataService();
            string res = "Суббота";
            Assert.Equal(res, ds.FindDayName(6));
        }
        [Fact]
        public void Test7()
        {
            DataService ds = new DataService();
            string res = "Воскресенье";
            Assert.Equal(res, ds.FindDayName(7));
        }
    }
}