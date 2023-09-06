using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public  class JumpGameTests
    {


        [Theory]
        [InlineData(new int[] { 2, 3, 1, 1, 4 }, true)]
        [InlineData(new int[] { 3, 2, 1, 0, 4 }, false)]
        [InlineData(new int[] { 3, 2, 0, 0, 2, 0, 1 }, false)]
        [InlineData(new int[] { 3, 3, 1, 0, 2, 0, 1 }, true)]

        public void CheckIfEndIsReachableFromStart_WhenCalled_ReturnsWhetherEndIsReachableFromStart(int[] nums1, bool expected)
        {

            //arrange and Act
            var actual = JumpGame.CheckIfEndIsReachableFromStart(nums1);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
