using Tyuiu.EvseevEI.Sprint3.Task4.V24.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.AreEqual(1, dataService.Calculate(-5, 5));
        }
    }
}