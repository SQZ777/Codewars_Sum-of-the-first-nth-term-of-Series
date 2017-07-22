using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NthSeries
{
    [TestClass]
    public class NthSeriesTest
    {
        [TestMethod]
        public void Input_0_Should_Be_0_00()
        {
            seriesResult("0.00", 0);
        }

        [TestMethod]
        public void Input_1_Should_Be_1()
        {
            seriesResult("1", 1);
        }

        private static void seriesResult(string expected, int input)
        {
            var nthSeries = new NthSeries();
            Assert.AreEqual(expected, nthSeries.seriesSum(input));
        }
    }

    public class NthSeries
    {
        public string seriesSum(int input)
        {
            if (input.Equals(0))
                return "0.00";

            return input.ToString();
        }
    }
}
