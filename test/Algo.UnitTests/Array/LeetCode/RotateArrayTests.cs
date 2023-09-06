using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class RotateArrayTests
    {

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3, new int[] { 7, 8, 9, 1, 2, 3, 4, 5, 6 })]
        [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
        public void RotateEff_WhenCalled_RotatesArray(int[] inpArr, int k, int[] expected)
        {

            //arrange and act
           RotateArray.RotateEff(inpArr, k);


            //assert
            Assert.Equal(expected, inpArr);

        }
    }
}
