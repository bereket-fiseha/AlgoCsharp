using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class BaseBallGameTests
    {
        [Theory]
        [InlineData(new string[] { "1", "C" }, 0)]
        [InlineData(new string[] { "5", "2", "C", "D", "+" }, 30)]
        [InlineData(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" }, 27)]

        public void calcPoint_WhenCalled_ReturnsTHeCalculatedPoint(string[] ops, int expected)
        {

            //arrange and Act
            var actual = BaseBallGame.calcPoint(ops);

            //assert
            Assert.Equal(expected, actual);

        }

    }
}
