using AlgorithmAndDS.LeetCode.Array;
using AlgorithmAndDS.LeetCode.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class LongestSubstringWORCTests
    {

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbb", 1)]
        [InlineData("pwwkew", 3)]
        
        public void GetLongestSubstring_WhenCalled_ReturnsTheLongestSubString(string s,int expected)
        {

            //arrange and Act
            var actual = LongestSubstringWithoutRepeatingCharacters.SubString(s);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
