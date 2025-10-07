using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChepragaDM.Sprint2.Task3.V19.Lib
{
    public class DataService : ISprint2Task3V19
    {
        public double Calculate(double x)
        {
            double res = new double();
            if (x > 1.0)
            {
                res = ((x * x) + Math.Pow((x + 1.0) / (x - 1.0), x));
            }
            else if (x == 0.0)
            {
                res = (((x * x) + Math.Cos(Math.Pow(x, 2)) + 13.0) / ((x * x) + Math.Sin(Math.Pow(x, 2)) + 9.0));
            }
            else if ((x > -23.0) && (x < 2.0))
            {
                res = Math.Pow(1.0 + (1.0 / (x*x)), x);
            }
            else if (x < -23.0)
            {
                res = (x + (10 * x) - (1.0 / x));
            }
            return Math.Round(res, 3);
        }
    }
}
