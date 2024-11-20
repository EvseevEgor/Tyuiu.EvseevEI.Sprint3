using Tyuiu.EvseevEI.Sprint3.Task3.V27.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService dataService = new DataService();
            string value = "?aa !!!!aa563dd 77";
            dataService.ConvertStringToInt(value);
            double wait = 563;
        }
    }
}