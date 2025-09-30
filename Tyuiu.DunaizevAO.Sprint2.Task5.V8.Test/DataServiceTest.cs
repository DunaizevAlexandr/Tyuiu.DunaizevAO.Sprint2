using Tyuiu.DunaizevAO.Sprint2.Task5.V8.Lib;

namespace Tyuiu.DunaizevAO.Sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int m = 7;
            int n = 1;
            string wait = "630";
            var res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
