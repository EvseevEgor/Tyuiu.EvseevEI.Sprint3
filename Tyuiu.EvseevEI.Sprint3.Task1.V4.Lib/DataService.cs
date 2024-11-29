using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.EvseevEI.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            var i = startValue;
            while (i <= stopValue)
            {
                sumSeries +=Math.Pow((0-1)/i,2);
                i++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
