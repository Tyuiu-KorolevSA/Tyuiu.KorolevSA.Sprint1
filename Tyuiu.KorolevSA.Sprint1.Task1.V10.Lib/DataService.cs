using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KorolevSA.Sprint1.Task1.V10.Lib
{
    public class DataService : ISprint1Task1V10
    {
        public double Calculate(double x, double y)
        {
            return (x + y) / (1 + x);
        }
    }
}
