using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class LongestCommonPrefixTests
    {
        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        [InlineData(new string[] { "dog"}, "dog")]
        [InlineData(new string[] {  }, "")]
        [InlineData(new string[] {"flow","flows" }, "flow")]
        [InlineData(new string[] { "flows", "flows" }, "flows")]

        public void getCommonPrefix_WhenCalled_ReturnsTheCommonPrefix(string[] strs, string expected)
        {

            //arrange and Act
            var actual = LongestCommonPrefix.getCommonPrefix(strs);

            //assert
            Assert.Equal(expected, actual);

        }


    }
}
