using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class IntegerToRomanTests
    {


        [Theory]
        [InlineData(58, "LVIII")]
        [InlineData(3, "III")]
        [InlineData(3768, "MMMDCCLXVIII")]
        [InlineData(1994, "MCMXCIV")]
      
        public void Convert_WhenCalled_ReturnsTheConverted(int num, string expected)
        {

            //arrange and Act
            var actual = IntegerToRoman.Convert(num);

            //assert
            Assert.Equal(expected, actual);

        }

    }
}
