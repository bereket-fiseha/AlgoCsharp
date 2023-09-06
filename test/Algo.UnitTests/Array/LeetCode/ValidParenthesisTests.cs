using AlgorithmAndDS.LeetCode.Stack;
using AlgorithmAndDS.LeetCode.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class ValidParenthesisTests
    {

        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("({[]})", true)]


        public void IsValid_WhenCalled_ChecksIfValid (string s,bool expected){

            //arrange and Act
            var actual = ValidParenthesis.CheckIfValid(s);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
