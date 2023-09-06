using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class RomanToIntTests
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("XII", 12)]

        public void Convert_WhenCalled_ReturnsIntNumber(string roman, int expected)
        {

            //arrange and Act
            var actual = RomanToInt.Covert(roman);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
