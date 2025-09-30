using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DunaizevAO.Sprint2.Task3.V13.Lib
{
    public class DataService : ISprint2Task3V13
    {
        public double Calculate(double x)
        {
            double y;
            if (x > 1)
            {
                y = x - Math.Pow(((x + 1) / (x - 1)), x);
            }
            else if (x == 0)
            {
                y = (7 * x * x - Math.Cos(x * x) + 10) / (8 * x * x - Math.Sin(x * x) + 12);
            }
            else if (x> -17 && x < 2)
            {
                y = Math.Pow((3 + 8 / (x * x)), x);
            }
            else if (x < -17)
            {
                y = x + 10 * x - (1 / x);
            }
            else
            {
                y = 0;
            }
            double res = Math.Round(y, 3);
            return res;
        }
    }
}
