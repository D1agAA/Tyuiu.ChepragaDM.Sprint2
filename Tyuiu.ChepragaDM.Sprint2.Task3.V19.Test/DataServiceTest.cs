using Tyuiu.ChepragaDM.Sprint2.Task3.V19.Lib;
namespace Tyuiu.ChepragaDM.Sprint2.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = -24.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(-263.958, res);
        }
    }
}
