using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable PossibleLossOfFraction
// ReSharper disable SpecifyACultureInStringConversionExplicitly

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

        [TestMethod]
        public void Input_2_Should_Be_1_25()
        {
            seriesResult("1.25",2);
        }

        [TestMethod]
        public void Input_5_Should_Be_1_57()
        {
            seriesResult("1.57",5);
        }

        [TestMethod]
        public void Input_9_Should_Be_1_77()
        {
            seriesResult("1.77",9);
        }
        private static void seriesResult(string expected, int input)
        {
            var nthSeries = new NthSeries();
            Assert.AreEqual(expected, nthSeries.seriesSum(input));
        }

    }

    public class NthSeries
    {
        public string seriesSum(int n)
        {
            double result = 0;
            for (int i = 1; i < n * 3; i += 3)
            {
                result += caculate(i);
            }
            return n!=1 ? Math.Round(result, 2).ToString("N2") : Math.Round(result, 2).ToString();
        }

        private static double caculate(int i)
        {
            return 1 / double.Parse(i.ToString());
        }
    }
}
