using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SodnomovVM.Sprint3.Task6.V5.Lib
{
    public class DataService : ISprint3Task6V5
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i<=startValue; i++)
            {
                for (int x = 1; x<=i; x++)
                {
                   if (i%x == 0)
                        {
                        sum += x;

                        }

                }

            }
            return sum
                
        }
    }
}
