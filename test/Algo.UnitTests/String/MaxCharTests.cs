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
    public class MaxCharTests
    {

        [Theory]
        [InlineData("", null)]
        [InlineData("a", 'a')]
        [InlineData("bcdefgi", 'b')]

        [InlineData("bcdeefgi", 'e')]

        [InlineData("bbcdeefgiii", 'i')]

        [InlineData("bbcdecefgciiic", 'c')]
        [InlineData("bbcedecefgciieic", 'e')]
        [InlineData("bbbcccc", 'c')]

        [InlineData("234562", '2')]



        public void MaxChar_WhenCalled_ReturnTheFrequentlyOccuringChar(string strn, char? expected)
        {
            //arrange
            var algo = new MaxChar(strn);
            //act
            var actual = algo.MaxCharFirImp();
            //assert
            Assert.Equal(expected, actual);

        }
       


    }
}
