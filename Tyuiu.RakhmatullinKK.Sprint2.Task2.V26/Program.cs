using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RakhmatullinKK.Sprint2.Task2.V26.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint2.Task2.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Рахматуллин К.К. | АСОиУБ-23-2";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                     *");
            Console.WriteLine("* Тема: Логические операции                                                     *");
            Console.WriteLine("* Задание #2                                                                    *");
            Console.WriteLine("* Вариант #26                                                                   *");
            Console.WriteLine("* Выполнил: Рахматуллин Карим Камильевич| АСОиУБ-23-2                        *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры           *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X, Y в заштрихованной области  *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Введите значение переменной X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значение переменной Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();
        }
    }
}
