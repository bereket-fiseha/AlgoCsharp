using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public  class LengthLastWordTests
    {


        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
           public void getLength_WhenCalled_ReturnsLengthOfLastWord(string s, int expected)
        {

            //arrange and Act
            var actual = LengthOfLastWord.getLength(s);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
