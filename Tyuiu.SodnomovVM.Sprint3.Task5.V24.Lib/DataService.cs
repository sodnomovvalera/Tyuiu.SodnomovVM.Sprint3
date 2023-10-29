using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SodnomovVM.Sprint3.Task5.V24.Lib
{
    public class DataService : ISprint3Task5V24
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            
            int j, i;
            for (j = startValue1; j<=stopValue1; j++)
            {
                for (i = startValue2; i<=stopValue2, i++)
                {
                    res = res + (Math.Pow(x, i) + 2) * Math.Sin(i);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
