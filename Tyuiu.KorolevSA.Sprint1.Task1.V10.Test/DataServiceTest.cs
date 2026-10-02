using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Tyuiu.KorolevSA.Sprint1.Task1.V10.Lib;


namespace Tyuiu.KorolevSA.Sprint1.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            double x = 1;
            double y = 2;
            var result = dataService.Calculate(x, y);
            Assert.AreEqual(1.5, result);
        }
    }
}
