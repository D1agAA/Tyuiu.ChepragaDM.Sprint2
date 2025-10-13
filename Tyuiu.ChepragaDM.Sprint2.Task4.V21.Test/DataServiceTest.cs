using Tyuiu.ChepragaDM.Sprint2.Task4.V21.Lib;
namespace Tyuiu.ChepragaDM.Sprint2.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate ()
        {
            DataService ds = new DataService ();
            double x = 1;
            double y = 0;
            var res = ds.Calculate (x, y);
            Assert.AreEqual (0.986, res);
        }
    }
}
