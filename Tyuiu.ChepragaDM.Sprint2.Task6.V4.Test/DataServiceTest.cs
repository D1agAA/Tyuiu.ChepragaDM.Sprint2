using Tyuiu.ChepragaDM.Sprint2.Task6.V4.Lib;
namespace Tyuiu.ChepragaDM.Sprint2.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardSuit()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.FindCardSuit(x);
            Assert.AreEqual("трефы", res);
        }
    }
}
