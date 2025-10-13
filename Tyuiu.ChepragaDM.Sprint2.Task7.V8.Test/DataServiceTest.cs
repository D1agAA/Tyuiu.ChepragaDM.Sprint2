using Tyuiu.ChepragaDM.Sprint2.Task7.V8.Lib;
namespace Tyuiu.ChepragaDM.Sprint2.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()

        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);

        }
    }
}
