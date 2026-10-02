using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KorolevSA.Sprint1.Task2.V29.Lib
{
    public class DataService : ISprint1Task2V29
    {
        public int Calculate(int value)
        {
            return value / 60;
        }
    }
}