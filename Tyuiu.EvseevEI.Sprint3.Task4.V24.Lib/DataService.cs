﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.EvseevEI.Sprint3.Task4.V24.Lib
{
    public class DataService : ISprint3Task4V24
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1;
            for (int i = -5; i <= 5; i++)
            {
                if (i == 0)
                {
                    break;
                }
                result *= (Math.Sin(i) / i) + 2;
            }
            return Math.Round(result, 3);
        }
    }
}
