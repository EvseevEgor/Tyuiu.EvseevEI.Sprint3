using Tyuiu.EvseevEI.Sprint3.Task3.V27.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string value = "!bt, g567kid f!";
            int res = ds.ConvertStringToInt(value);
            int wait = 567;
            Assert.AreEqual(res, wait);
        }
    }
}