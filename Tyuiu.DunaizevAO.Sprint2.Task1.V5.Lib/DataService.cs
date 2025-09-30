using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DunaizevAO.Sprint2.Task1.V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            /*
            a = 154
            b = 163
            c = 134
            d = 137
            */
            bool[] result = new bool[6];
            result[0] = (a > b) | (a > c);
            result[1] = (a == b) & (a == c);
            result[2] = (d >= a) || (d >= b);
            result[3] = (a < b) && (a < c);
            result[4] = !(a <= c);
            result[5] = (a != b) ^ (a != c);
            return result;
        }
    }
}
