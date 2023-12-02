using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint2.Review.V6.Lib;

namespace Tyuiu.TitkovAA.Sprint2.Review.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("*                                                                         *");
            //Console.WriteLine("***************************************************************************");
            //75симв->

            Console.Title = "Спринт #2 | Выполнил: Титков А. А. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: решение задания                                                   *");
            Console.WriteLine("* Задание #Review                                                         *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X,Y в заштрихованной области.                                           *");
            Console.WriteLine("***************************************************************************");

            DataService dt = new DataService();
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (dt.CheckDotInShadedArea(x, y))
            {
                Console.WriteLine("точка в заштрихованой области");
            }
            else Console.WriteLine("точка не в заштрихованной области");



        }
    }
}
