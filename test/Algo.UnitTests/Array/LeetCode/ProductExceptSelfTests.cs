using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class ProductExceptSelfTests
    {

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [InlineData(new int[] { -1, 1, 0, -3, 3 } ,new int[] { 0, 0, 9, 0, 0 })]
   

        public void GetProduct_WhenCalled_ReturnsProduct(int[] nums1, int[] expected)
        {

            //arrange and Act
            var actual = ProductExceptSelf.GetProduct(nums1);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
