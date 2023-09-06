using AlgorithmAndDS.Array.Partioning;

using AlgorithmAndDS.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Int
{
    public class ReverseIntTests
    {

        [Theory]
        [InlineData(15, 51)]
        [InlineData(981, 189)]
        [InlineData(111, 111)]
        [InlineData(-33, -33)]
        [InlineData(-15, -51)]
        [InlineData(900, 9)]
        [InlineData(-98280500,-508289 )]
        public void ReverseInt_WhenCalled_ReturnReversedInt(int num, int expected)
        {
            //arrange
            var algo = new ReverseInt(num);
            //act
            var actual = algo.ReverseIntFirImp();
            //assert
            Assert.Equal(expected, actual);

        }






    }
}
