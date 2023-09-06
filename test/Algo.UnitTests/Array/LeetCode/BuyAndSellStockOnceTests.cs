using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public  class BuyAndSellStockOnceTests
    {


        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, new int []{1,4, 5 })]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, new int[] {0,0,0 })]
        [InlineData(new int[] { 3, 4, 2, 5, 6, 7, 1, 8 }, new int[] {6,7,7 })]
        [InlineData(new int[] { 3, 4, 2, 5, 6, 7, 8, 1 }, new int[] { 2, 6, 6 })]
        [InlineData(new int[] {}, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1}, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1,2 }, new int[] { 0, 1, 1 })]
        public void MaxProfit_WhenCalled_ReturnsTheMaximumProfit(int[] nums1, int[] expected)
        {

            //arrange and Act
            var actual = BuyAndSellStockOnce.MaxProfit(nums1);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
