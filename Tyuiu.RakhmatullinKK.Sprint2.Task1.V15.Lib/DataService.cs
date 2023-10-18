using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RakhmatullinKK.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            // a = 415, b = 616, c = 134, d = 127
            res[0] = (a < b) | (c > d);//true 
            res[1] = (a == b) & (c > d);//false
            res[2] = (a >= b) || (c == d);//false
            res[3] = (a != b) && (c == d);//false
            res[4] = !res[0];//false
            res[5] = (a == b) ^ (d < c);//true
            return res;
        }
    }
}