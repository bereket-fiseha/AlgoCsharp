using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public  class RemoveMoreThanTwiceDuplicatesTests
    {
          [Theory]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 3, 4, 5 }, new int[] {0,0,1,1,2,2,3,3,4,5,4,5 },10),]
            [InlineData(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, new int[] { 0, 0, 1, 1, 2, 3, 3, 3,3 }, 7),]

        public void RemoveElement_WhenCalled_ShouldRemoveMoreThenTwoDuplicates(int[] nums, int[] expectedArray,int expectedLength)
        {
            //arrange and act
           int k= RemoveMoreThenTwiceDuplicate.RemoveDuplicate(nums);

            //assert


            Assert.Equal(expectedArray,nums );
            Assert.Equal(expectedLength, k);

        }

    }
}
