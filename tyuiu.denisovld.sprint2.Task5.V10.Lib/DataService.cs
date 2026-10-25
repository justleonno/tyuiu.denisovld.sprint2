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
                    if ((Convert.ToString(n).Length == 1) & (Convert.ToString(m).Length == 1))
                        {
                        res = "0" + Convert.ToString(n - 1) + "." + "0" + Convert.ToString(m) + "." + Convert.ToString(g); break;
                        }
                    else if ((Convert.ToString(n).Length == 1) & (Convert.ToString(m).Length == 2))
                    {
                        res = "0" + Convert.ToString(n - 1) + "." + Convert.ToString(m) + "." + Convert.ToString(g); break;
                    }
                    else if ((Convert.ToString(n).Length == 2) & (Convert.ToString(m).Length == 1))
                    {
                        res = Convert.ToString(n - 1) + "." + "0" + Convert.ToString(m) + "." + Convert.ToString(g); break;
                    }
                    else
                    {
                        res = Convert.ToString(n - 1) + "." + Convert.ToString(m) + "." + Convert.ToString(g); break;
                    }


                case (_, 5 or 7 or 10 or 12, 1):
                    if (Convert.ToString(m-1).Length == 1)
                    {
                        res = Convert.ToString(30) + "." + "0" + Convert.ToString(m-1) + "." + Convert.ToString(g); break;
                    }
                    else
                    {
                        res = Convert.ToString(30) + "." + Convert.ToString(m-1) + "." + Convert.ToString(g); break;
                    }


                case (_, 2 or 4 or 6 or 8 or 9 or 11, 1):
                    if (Convert.ToString(m - 1).Length == 1)
                    {
                        res = Convert.ToString(31) + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g); break;
                    }
                    else
                    {
                        res = Convert.ToString(31) + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g); break;
                    }


                case (_, 3, 1):
                    res = Convert.ToString(28) + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g); break;


                case (_, 1, 1):
                    res = Convert.ToString(31) + "." + Convert.ToString(12) + "." + Convert.ToString(g-1); break;

                default:
                    throw new ArgumentException($"Ошибка: такой даты не существует. Значение {Convert.ToString(g) + Convert.ToString(m) + Convert.ToString(n)}");
            }
            return res;
        }
    }
}
