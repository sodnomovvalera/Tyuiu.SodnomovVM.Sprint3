using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SodnomovVM.Sprint3.Task3.V8.Lib
{
    public class DataService : ISprint3Task3V8
    {
        public int ConvertStringToInt(string value)
        {
            string result = string.Empty;
            
            foreach (char c in value)
            {
                if ((c=='1')|| (c == '3') || (c == '2') || (c == '4') || (c == '5') || (c == '6') || (c == '7') || (c == '8') || (c == '9'))
                {
                    result = result + Convert.ToChar(c);
                }
            }
            return Convert.ToInt32(result);
        }
    }
}
