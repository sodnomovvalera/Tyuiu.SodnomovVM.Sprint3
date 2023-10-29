using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SodnomovVM.Sprint3.Task7.V18.Lib;

namespace Tyuiu.SodnomovVM.Sprint3.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Содномов Валерий Михайлович | СмартБ-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService(); 

            Console.WriteLine("Введите начало промежутка");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конец  промежутка");
            int y = Convert.ToInt32(Console.ReadLine());

            int len = ds.GetMassFunction(x, y).Length;
            double[] value;
            value = new double[len];

            value = ds.GetMassFunction(x, y);


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(X)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i<=len-1; i++)
            {
                Console.WriteLine("|{0,5:d}        |   {1,5:f2}   |", x, value[i]);
                x++;
            }
            Console.WriteLine("+----------+----------+");
           
            Console.ReadKey();
        }
        
    }
}
