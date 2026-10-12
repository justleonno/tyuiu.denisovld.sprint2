using tyuiu.cources.programming.interfaces.Sprint2;
namespace tyuiu.denisovld.sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res;
            switch (g,  m, n)
            {   
                case (_, >= 1 and <= 12, > 1 and <= 31):
                    res = Convert.ToString(g) + "." + Convert.ToString(m) + "." + Convert.ToString(n-1); break;
                case (_, 5 or 7 or 10 or 12, 1):
                    res = Convert.ToString(g) + "." + Convert.ToString(m-1) + "." + Convert.ToString(30); break;
                case (_, 2 or 4 or 6 or 8 or 9 or 11, 1):
                    res = Convert.ToString(g) + "." + Convert.ToString(m - 1) + "." + Convert.ToString(31); break;
                case (_, 3, 1):
                    res = Convert.ToString(g) + "." + Convert.ToString(m - 1) + "." + Convert.ToString(28); break;
                case (_, 1, 1):
                    res = Convert.ToString(g-1) + "." + Convert.ToString(12) + "." + Convert.ToString(31); break;
                default:
                    throw new ArgumentException($"Ошибка: такой даты не существует. Значение {Convert.ToString(g) + Convert.ToString(m) + Convert.ToString(n)}");
            }
            return res;
        }
    }
}
