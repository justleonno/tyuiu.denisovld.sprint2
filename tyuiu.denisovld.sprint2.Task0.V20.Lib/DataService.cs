namespace tyuiu.denisovld.sprint2.Task0.V20.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint2;
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == x;
            res[1] = x != x;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = y <= x;
            res[5] = y >= x;
            return res;

        }
    }
}
