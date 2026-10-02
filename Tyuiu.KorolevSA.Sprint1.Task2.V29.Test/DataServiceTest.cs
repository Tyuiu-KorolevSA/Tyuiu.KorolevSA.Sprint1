using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Tyuiu.KorolevSA.Sprint1.Task2.V29.Lib;

namespace DataServiceTest
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            int timeSec = 3602;
            int timeMin = dataService.Calculate(timeSec);
            Assert.AreEqual(60, timeMin);
        }
    }
}
