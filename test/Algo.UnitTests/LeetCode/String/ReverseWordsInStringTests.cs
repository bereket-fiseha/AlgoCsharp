using AlgorithmAndDS.LeetCode.Array;
using AlgorithmAndDS.LeetCode.String;
using AlgorithmAndDS.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.LeetCode.String
{
    public class ReverseWordsInStringTests
    {



        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("  hello world  ", "world hello")]
        [InlineData("a good   example", "example good a")]

        //[InlineData("theblue", "eulbeht")]
        //[InlineData("helloworld", "dlrowolleh")]
        //[InlineData("aexample", "elpmaxea")]





        public void Reverse_WhenCalled_ReturnsReversedString(string str, string expected)
        {

            //arrange and Act
            var actual = ReverseWordsInString.ReverseStringUsingStack(str);

            //assert
            Assert.Equal(expected, actual);

        }

    }
}
