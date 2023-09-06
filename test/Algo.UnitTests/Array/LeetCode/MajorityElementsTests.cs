using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class MajorityElementTests
    {

        [Theory]
        [InlineData(new int[] { 2, 3, 5, 6, 9, 0, 0, 0, 0, 0 },0)]
        [InlineData(new int[] { 2, 3, 5, 6, 19, 10, 13, 4, 6, 29 }, 29)]
        [InlineData(new int[] { 2, 3, 5, 6, 9, 9, 9, 9, 9, 2 },9)]
        [InlineData(new int[] { 2, 3, 5, 6, 9, 30, 40, 50,50,50 },50)]

        public void FindMajorityElement_WhenCalled_ReturnsMajorityElement(int[] nums1, int expected)
        {

            //arrange and Act
           var actual= MajorityElement.FindMajEff(nums1);

            //assert
            Assert.Equal(expected, actual);

        }



    }
}
