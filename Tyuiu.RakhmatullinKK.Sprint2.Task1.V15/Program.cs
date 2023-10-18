using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RakhmatullinKK.Sprint2.Task1.V15.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint2.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Рахматуллин К.К. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Рахматуллин Карим Камильевич | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, " +
                              "*последовательность можно чередовать но использовать один раз в выражении)*" +
                              "*и логических операций (|, &, ||, &&, !, ^, последовательность операций не*" +
                              "*должна нарушаться), а также арифметических выражений, которая вернет     *" +
                              "*логическую последовательность(массив): (True, False, False, False, False,*" +
                              "*True), при a = 415, b = 616, c = 134, d = 127*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите четвертое число:");
            int d = Convert.ToInt32(Console.ReadLine());

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}