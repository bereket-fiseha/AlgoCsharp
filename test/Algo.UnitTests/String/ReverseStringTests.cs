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
    public class ReverseStringTests
    {

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        public void ReverseString_IfGivenStringIsNullOrEmpty_ReturnNullOrEmpty(string strn, string expected)
        {
            //arrange
            var algo = new ReverseString(strn);
            //act
            var actual = algo.ReverseSecImp();
            //assert
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData("s", "s")]
        [InlineData("aaa", "aaa")]
        public void ReverseString_IfComposedByRepeatedOneTypeChar_ReturnGivenString(string strn, string expected)
        {
            //arrange
            var algo = new ReverseString(strn);
            //act
            var actual = algo.ReverseSecImp();
            //assert
            Assert.Equal(expected, actual);

        }



        [Theory]
        [InlineData("student", "tneduts")]
        [InlineData("start", "trats")]
        [InlineData("statt", "ttats")]
         [InlineData("46789032", "23098764")]
        public void ReverseString_IfComposedOfDifferentChars_ReturnReversedString(string strn, string expected)
        {
            //arrange
            var algo = new ReverseString(strn);
            //act
            var actual = algo.ReverseThirdImp();
            //assert
            Assert.Equal(expected, actual);

        }



    }
}
