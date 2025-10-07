using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChepragaDM.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = new bool();
            if (x == 2)
            {
                if (y == 5 || y == 6 || y == 13)
                {
                    res = true;
                }

            }

            else if (x == 3)
            {
                if (y >= 3 && y <= 7 && y == 13)
                {
                    res = true;
                }
            }
            else if (x == 4)
            {
                if (y >= 3 && y <= 7 && y == 12)
                {
                    res = true;
                }
            }
            else if (x == 5)
            {
                if ((y >= 3 && y <= 7) || y == 9 || y == 10  || y == 12)
                {
                    res = true;
                }
            }
            else if (x == 6)
            {
                if (y >= 5 && y <= 12)
                {
                    res = true;
                }
            }
            else if (x == 7)
            {
                if (y >= 5 && y <= 8)
                {
                    res = true;
                }
            }
            else if (x == 8)
            {
                if (y >= 5 && y <= 8)
                {
                    res = true;
                }
            }
            else if (x == 9)
            {
                if (y >= 3 && y <= 8)
                {
                    res = true;
                }
            }
            else if (x == 10)
            {
                if (y >= 3 && y <= 8)
                {
                    res = true;
                }
            }
            else if (x == 11)
            {
                if (y >= 3 && y <= 11)
                {
                    res = true;
                }
            }
            else if (x == 12)
            {
                if (y >= 3 && y <= 12)
                {
                    res = true;
                }
            }
            else if (x == 13)
            {
                if ((y >= 6 && y <= 8) || y == 12)
                {
                    res = true;
                }
            }
            return res;
        }
    }
}
