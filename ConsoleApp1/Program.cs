using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            do
            {
                a+=1;
       
                b+=1;

            } while ((a > 1)&&(a<5));
            Console.WriteLine(a) ;
            Console.WriteLine(b);
            Console.WriteLine(a+b);
            Console.ReadKey();
        }
    }
}
