using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DunaizevAO.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((y - Math.Sin(x)) < 0) && (y >= 0 && y <= 0.5) && (x >= 0 && x <= 3.1415))
            {
                res = true;
            }
            else { res = false; }
            return res;
        }
    }
}
