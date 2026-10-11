namespace tyuiu.denisovld.sprint2.Task2.V1.Lib
{
    using System.ComponentModel.Design;
    using tyuiu.cources.programming.interfaces.Sprint2;
    public class DataService : ISprint2Task2V1
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((x >= 3 & x <= 4) &  (y >= 3 & y <= 5)) | ((x >= 3 & x <= 4) & (y == 9)) | ((x >= 3 & x <= 4) & (y == 12)) | 
                    ((x >= 5 & x <= 6) & (y >= 5 & y <= 12)) | (x == 6 & y == 13) | ((x == 7) & (y >= 3 & y <= 13)) | 
                    ((x == 8) & (y >= 6 & y <= 8)) | ((x == 8) & (y >= 12 & y <= 13)) | ((x >=9 & x <= 10) & (y >= 6 & y <= 8)) |
                    ((x >= 9 & x <= 10) & (y == 12)) | ((x == 11) & (y >= 3 & y <= 8)) | ((x == 11) & (y == 12)) |
                    ((x == 12) & (y == 4)) | ((x == 12) & (y >= 7 & y <= 8)) | ((x == 13) & (y == 4)))
                    {
                res = true;
                    }
            else
            {  res = false; }
            return res;
        }   
    }
}
