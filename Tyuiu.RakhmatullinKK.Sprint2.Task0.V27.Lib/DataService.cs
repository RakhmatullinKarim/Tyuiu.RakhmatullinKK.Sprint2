using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RakhmatullinKK.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] CalculateLogicalSequence(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = (x + y) == 1580;
            res[1] = (x - y) != 1030;
            res[2] = (x * y) < 358875;
            res[3] = (x / y) > 4;
            res[4] = (x % y) <= 5;
            res[5] = (x + y) >= 1580;

            return res;
        }
    }
}