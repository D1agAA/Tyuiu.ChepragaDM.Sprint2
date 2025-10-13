using Tyuiu.ChepragaDM.Sprint2.Task5.V2.Lib;
namespace Tyuiu.ChepragaDM.Sprint2.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();
            int x = 12;
            var res = ds.FindMonthSeason(x);
            Assert.AreEqual("Зима", res);
        }
    }
}
