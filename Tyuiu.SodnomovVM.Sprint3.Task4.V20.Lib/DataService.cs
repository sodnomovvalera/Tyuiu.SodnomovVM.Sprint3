using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SodnomovVM.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20

    { 
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for ( int x = startValue; x<=stopValue; x++)
            {
                if ((Math.Cos(x) - x) == 0)
                {
                    continue;
                }
                else
                {
                    res = res + x/(Math.Cos(x) - x) + 2.5;
                }
                 

            }
            return Math.Round(res, 3);
        }
    }
}
