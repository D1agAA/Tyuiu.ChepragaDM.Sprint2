using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChepragaDM.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b) | (c <= d);
            res[1] = (a + 1000 == c) & (d != b);
            res[2] = (b > c) || (d >= a);
            res[3] = (b + 10 <= a) && (d == c);
            res[4] = !(res[0]);
            res[5] = (a < c) ^ (d + 1 == b);
            return res;
        }
    }
}
