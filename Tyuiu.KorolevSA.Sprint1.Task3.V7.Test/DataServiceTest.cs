using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Tyuiu.KorolevSA.Sprint1.Task3.V7.Lib;

namespace Tyuiu.KorolevSA.Sprint1.Task3.V7.Test


{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            double x = 100;
            var result = dataService.Calculate(x);

        }
    }
}
