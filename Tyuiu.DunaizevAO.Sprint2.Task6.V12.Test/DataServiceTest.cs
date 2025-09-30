using Tyuiu.DunaizevAO.Sprint2.Task6.V12.Lib;

namespace Tyuiu.DunaizevAO.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2025;
            int m = 5;
            int n = 10;
            string wait = "9.05.2025";
            var res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
