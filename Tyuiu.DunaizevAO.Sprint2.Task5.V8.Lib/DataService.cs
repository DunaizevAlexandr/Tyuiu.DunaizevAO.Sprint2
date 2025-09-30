using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DunaizevAO.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int prochM = m;
            int prochN = n - 1;

            switch (m)
            {
                case 1:
                    if (n == 1)
                    {
                        prochM = 12;
                        prochN = 31;
                    }
                    break;
                case 3:
                    if (n == 1)
                    {
                        prochM = 2;
                        prochN = 28;
                    }
                    break;
                case 5:
                case 7:
                case 10:
                case 12:
                    if (n == 1)
                    {
                        prochM = m - 1;
                        prochN = 30;
                    }
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    if (n == 1)
                    {
                        prochM = m - 1;
                        prochN = 31;
                    }
                    break;
            }
            string mes = Convert.ToString(prochM);
            string chis = Convert.ToString(prochN);
            string res = chis + ".0" + mes;
            return res;
        }
    }
}
