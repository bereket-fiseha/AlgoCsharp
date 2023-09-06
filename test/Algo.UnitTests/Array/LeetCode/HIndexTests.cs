using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public  class HIndexTests 
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 1, 4 }, 2)]
        [InlineData(new int[] { 3, 2, 5, 0, 4 }, 3)]
        [InlineData(new int[] { 5, 5, 5, 0, 2, 0, 1 }, 3)]
        [InlineData(new int[] { 6, 7, 8, 9, 2, 0, 1 }, 4)]
        [InlineData(new int[] {  0, 1 }, 1)]
        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { 0,0,0 }, 0)]
        [InlineData(new int[] { 7, 7, 7,7,7,7,8,8,9,9 }, 7)]
        [InlineData(new int[] {  7, 7, 7, 7, 7, 6, 6, 5, 5 }, 6)]
        [InlineData(new int[] { 7, 7, 7, 7, 7,7 ,7, 6, 5, 5 }, 7)]
        public void FindHIndex_WhenCalled_ReturnsTheHIndex(int[] nums1, int expected)
        {

            //arrange and Act
            var actual = HIndex.FindHIndex(nums1);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
