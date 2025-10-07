using Tyuiu.ChepragaDM.Sprint2.Task2.V15.Lib;
namespace Tyuiu.ChepragaDM.Sprint2.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void validCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}
