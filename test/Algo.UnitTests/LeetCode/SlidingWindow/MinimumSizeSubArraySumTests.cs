using AlgorithmAndDS.LeetCode.SlidingWindow;
using AlgorithmAndDS.LeetCode.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.LeetCode.SlidingWindow
{
    public class MinimumSizeSubArraySumTests
    {

        [Theory]
        [InlineData(new int[] { 2, 3, 1, 2, 4, 3 }, 7,2)]
        [InlineData(new int[] { 1, 4, 4}, 4,1)]
        [InlineData(new int[] {1, 1, 1, 1, 1, 1, 1, 1}, 11,0)]

        public void Find_WhenCalled_ReturnsMinimumSubArray(int[] nums, int target,int expected)
        {

            //arrange and Act
            var actual = MinimumSizeSubarraySum.Find(nums,target);

            //assert
            Assert.Equal(expected, actual);

        }

    }
}
