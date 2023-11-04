using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SodnomovVM.Sprint3.Task1.V12.Lib
{
    public class DataService : ISprint3Task1V12
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double mult = 0;
            while (startValue<=stopValue)
            {
                mult = mult + Math.Pow((1 / (Math.Pow(startValue, value))), 2);
                startValue++;
            }
            return Math.Round(mult,3);
        }
    }
}
