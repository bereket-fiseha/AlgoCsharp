using AlgorithmAndDS.Array.SlidingWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace Algo.UnitTests.Array.SlidingWindow
{
   public class SlidingWindowAlgoTests
    {

        
        #region //Given an array of positive numbers and a positive number ‘k’, find the maximum sum of any contiguous subarray of size ‘k’.
        [Theory]
        [InlineData(new int[] { 2,1,5,1,3,2}, 3,9)]
        [InlineData(new int[] { 2,3,4,1,5}, 2, 7)]
        [InlineData(new int[] { 3,5,6 }, 0, 0)]
        [InlineData(new int[] { 3, 4, 6 }, 3, 13)]
        public void MaxSubArraySumGivenK_WhenCalled_ReturnsMaxSubArraySum(int[] arr, int k, int expected)
        {
            //arrange
            SlidingWindowAlgo algo = new SlidingWindowAlgo();
            //act
            var actual = algo.maxSubArrayGivenK(arr, k);
            //assert
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(new int[] { 2, 1, 5, 1, 3, 2 }, -2)]
       
        public void MaxSubArraySumGivenK_ifKisbelowzero_ThrowsArgumentException(int[] arr, int k)
        {
            //arrange
            SlidingWindowAlgo algo = new SlidingWindowAlgo();
            //act
            //assert
            Assert.Throws<ArgumentException>(() => algo.maxSubArrayGivenK(arr, k));

        }
        [Theory]
        [InlineData(null, 2,9)]

        public void MaxSubArraySumGivenK_ifArrayIsNull_ThrowsArgumentNullException(int[] arr, int k,int expected)
        {
            //arrange
            SlidingWindowAlgo algo = new SlidingWindowAlgo();
            //act
            //assert
            Assert.Throws<ArgumentNullException>(() => algo.maxSubArrayGivenK(arr, k));

        }
        [Theory]
        [InlineData(new int[] { }, 2)]
        [InlineData(new int[] { 8}, 2)]
        public void MaxSubArraySumGivenK_ifArrayisemptyorKisgreaterthenArrayLength_ReturnsNegativeOne(int[] arr, int k)
        {
            //arrange
            SlidingWindowAlgo algo = new SlidingWindowAlgo();
            //act
            var actual = algo.maxSubArrayGivenK(arr, k);
            //assert
            Assert.Equal(-1, actual);

        }
        #endregion


    }
}
