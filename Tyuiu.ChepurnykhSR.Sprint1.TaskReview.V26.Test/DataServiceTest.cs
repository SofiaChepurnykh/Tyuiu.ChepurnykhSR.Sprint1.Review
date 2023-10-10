using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint1.TaskReview.V26.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint1.TaskReview.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 0.719;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
