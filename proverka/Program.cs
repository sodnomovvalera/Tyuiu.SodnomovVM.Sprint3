using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proverka
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            for (int i = 1; i < 4; i++)
            {
                a--;
                b+=a;
                c = a+b;
                d = (c-a) + i;


            }
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
