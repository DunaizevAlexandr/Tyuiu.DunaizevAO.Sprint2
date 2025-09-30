using Tyuiu.DunaizevAO.Sprint2.Task1.V5.Lib;

namespace Tyuiu.DunaizevAO.Sprint2.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 154;
            int b = 163;
            int c = 134;
            int d = 137;
            bool[] wait = new bool[6] { true, false, false, false, true, false };
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
