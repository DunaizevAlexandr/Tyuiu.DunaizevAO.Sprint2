using Tyuiu.DunaizevAO.Sprint2.Task3.V13.Lib;

namespace Tyuiu.DunaizevAO.Sprint2.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -20;
            double y = -219.95;
            var res = ds.Calculate(x);
            Assert.AreEqual(x, res);
        }
    }
}
