using Tyuiu.EvseevEI.Sprint3.Task7.V25.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            int startValue = -5; int endValue = 5;
            int len = endValue - startValue + 1;
            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = 4.67;
            valueWaitArray[1] = 0.43;
            valueWaitArray[2] = -8.26;
            valueWaitArray[3] = -9.87;
            valueWaitArray[4] = -3.98;
            valueWaitArray[5] = 1; 
            valueWaitArray[6] = 0.02;
            valueWaitArray[7] = -1.87;
            valueWaitArray[8] = 3.74;
            valueWaitArray[9] = 16.43;
            valueWaitArray[10] = 24.67;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, endValue);
            CollectionAssert.AreEqual(valueWaitArray, res);


        }
    }
}
