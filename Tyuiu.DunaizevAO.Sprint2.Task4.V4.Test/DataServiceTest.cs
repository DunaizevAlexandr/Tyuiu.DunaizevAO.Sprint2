using Tyuiu.DunaizevAO.Sprint2.Task4.V4.Lib;

namespace Tyuiu.DunaizevAO.Sprint2.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 11.01;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
