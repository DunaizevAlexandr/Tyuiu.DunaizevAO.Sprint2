using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DunaizevAO.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int proshG = g;
            int proshM = m;
            int proshN = n-1;

            switch (m)
            {
                case 1:
                    if (n == 1)
                    {
                        proshG = g-1;
                        proshM = 12;
                        proshN = 31;
                    }
                    break;
                case 3:
                    if (n == 1)
                    {
                        proshM = 2;
                        proshN = 28;
                    }
                    break;
                case 5:
                case 7:
                case 10:
                case 12:
                    if (n == 1)
                    {
                        proshM = m - 1;
                        proshN = 30;
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
                        proshM = m - 1;
                        proshN = 31;
                    }
                    break;
            }

            string god = Convert.ToString(proshG);
            string mes = Convert.ToString(proshM);
            string chis = Convert.ToString(proshN);
            string res = "0" + chis + ".0" + mes + "." + god;
            return res;

        }
    }
}


