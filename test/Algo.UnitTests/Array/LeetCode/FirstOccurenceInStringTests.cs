using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public  class FirstOccurenceInStringTests
    {


        [Theory]
        [InlineData( "flower","fl",0)]
        [InlineData("leetcode", "leeto", -1)]
        [InlineData("mississippi", "issip", 4)]
        [InlineData("sadbutsad", "sad", 0)]



        public void GetIndex_WhenCalled_ReturnsTheFirstOccurenceIndex(string haystack, string needle,int expected)
        {

            //arrange and Act
            var actual = FirstOccurenceInString.getIndex(haystack,needle);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
