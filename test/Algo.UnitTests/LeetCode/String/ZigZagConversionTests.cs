using AlgorithmAndDS.LeetCode.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.LeetCode.String
{
    public class ZigZagConversionTests
    {
        [Theory]
        [InlineData("PAYPALISHIRING", "PAHNAPLSIIGYIR", 3)]
        [InlineData("PAYPALISHIRING", "PINALSIGYAHRPI", 4)]
        [InlineData("P", "P", 2)]
        [InlineData("P", "P", 3)]
        [InlineData("PA", "PA", 2)]
        [InlineData("PAY", "PYA", 2)]
        [InlineData("PAY", "PAY", 3)]

        public void Convert_WhenCalled_ReturnsZigZagConversion(string input, string expected, int row)
        {

            //arrange and Act
            var actual = ZigzagConversion.Convert(input, row);

            //assert
            Assert.Equal(expected, actual);

        }



    }
}
