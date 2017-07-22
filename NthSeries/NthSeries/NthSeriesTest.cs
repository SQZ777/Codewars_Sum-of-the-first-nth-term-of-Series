using System;
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

            float result = 1.00f;
            for (int i = 4; i < input * 3; i += 3)
            {
                result += 1 / float.Parse(i.ToString());
            }
            return result.ToString();
        }

    }
}
