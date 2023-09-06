using AlgorithmAndDS.LeetCode.Stack;
using AlgorithmAndDS.LeetCode.TwoPointer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class ValidPalindromeTests
    {


        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("chstats---hc", true)]
        [InlineData("ch s t atsh c", true)]
        [InlineData("8c7h,s t a?tsh-7 c8", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]


        public void IsValid_WhenCalled_ChecksIfValid(string s, bool expected)
        {

            //arrange and Act
            var actual = ValidPalindrome.IsValid(s);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
