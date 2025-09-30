using Tyuiu.DunaizevAO.Sprint2.Task2.V2.Lib;

namespace Tyuiu.DunaizevAO.Sprint2.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 6;
            bool wait = true;
            bool res;
            res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
