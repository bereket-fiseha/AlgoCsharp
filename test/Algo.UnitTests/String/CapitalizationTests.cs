using AlgorithmAndDS.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.String
{
    public class Capitalize
    {


        [Theory]
        [InlineData("", "")]
        [InlineData("a", "A")]
        [InlineData("I ", "I")]

        [InlineData("I am", "I Am")]

        [InlineData("I am dev", "I Am Dev")]


        public void CapitalizeEachWord_WhenCalled_ReturnsCapitalizedString(string strn, string expected)
        {
            //arrange
            var algo = new Capitalization();
            //act
            var actual = algo.CapitalizeEachWord(strn);
            //assert
            Assert.Equal(expected, actual);

        }


        [InlineData("I am")]

        public void CapitalizeEachWord_IfArgumentGivenIsNotWord_ThrowsArgumentException( string strn)
        {
            //arrange
            var algo = new Capitalization();
             //assert
            Assert.Throws<ArgumentException>(() => algo.CapitalizeEachWord(strn));

        }

    }
}
