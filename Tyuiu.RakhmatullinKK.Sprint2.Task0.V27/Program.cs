using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RakhmatullinKK.Sprint2.Task0.V27.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint2.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                
                    DataService ds = new DataService();
                    int x = 1305;
                    int y = 275;
                    bool[] res = new bool[6];
                    res = ds.CalculateLogicalSequence(x, y);

                    Console.Title = "Спринт #2 | Выполнил: Рахматуллин К.К. | АСОиУБ-23-2";
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* Спринт #2                                                               *");
                    Console.WriteLine("* Тема: Операции сравнения                                                *");
                    Console.WriteLine("* Задание #0                                                              *");
                    Console.WriteLine("* Вариант #21                                                             *");
                    Console.WriteLine("* Выполнил: Рахматуллин Карим Камильевич | АСОиУБ-23-2                        *");
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* УСЛОВИЕ:                                                                *");
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* Написать программу из операций сравнения и арифметических действий,     *");
                    Console.WriteLine("* которая вернёт логическую последовательность (массив)                   *");
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine($"* X = {x}                                                                *");
                    Console.WriteLine($"* Y = {y}                                                                 *");
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                    Console.WriteLine("***************************************************************************");

                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine(res[i]);
                    }
                    Console.ReadKey();
                
            }
