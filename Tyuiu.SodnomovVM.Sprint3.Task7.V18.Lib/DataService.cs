using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SodnomovVM.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double [] value;
            int len = (stopValue - startValue) + 1;
            value = new double[len];
            int count = 0;
            int x;
            for ( x = startValue; x <= stopValue; x++) ;
            {
                if ((Math.Cos(x) + x) == 0)
                {
                    value[x] = 0;
                }
                else
                {
                    value[x] = Math.Round(((2 * x - 3) / (Math.Cos(x) + x) + 5),2);
                }
                count++;
            }
            return value;
        }
    }
}
