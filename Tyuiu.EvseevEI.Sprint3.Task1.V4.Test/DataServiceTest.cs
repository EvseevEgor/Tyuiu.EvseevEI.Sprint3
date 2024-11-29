using Tyuiu.EvseevEI.Sprint3.Task1.V4.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            var varForTest = 0.968;
            Assert.AreEqual(varForTest, ds.GetSumSeries(1, 15));
        }

        
    }
}