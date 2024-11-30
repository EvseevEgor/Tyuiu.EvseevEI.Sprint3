using Tyuiu.EvseevEI.Sprint3.Task3.V27.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService service = new DataService();
            Assert.AreEqual(6, DataService.ConvertStringToInt("kjhgfuu gujut dtuu", 'u'));
        }
    }
}