using AlgorithmAndDS.Array.Partioning;
using AlgorithmAndDS.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.String
{
    public class PalindromeStringTests
    {

     
        [Theory]
        [InlineData("s", true)]
        [InlineData("aaa", true)]
        [InlineData("aaab", false)]
        [InlineData("baacaab", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData(".b!a$aca$a!b.", true)]
        public void PalindromeString_WhenCalled_ReturnsTrueIfStringIsPalindrome(string strn, bool expected)
        {
            //arrange
            var algo = new PalindromeString(strn);
            //act
            var actual = algo.PalindromeFirImp();
            //assert
            Assert.Equal(expected, actual);

        }







    }
}
