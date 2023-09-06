using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class ShuffleArrayTests
    {

        [Theory]
        [InlineData(new int[] { 1,1,2,2}, 2, new int[] {1,2,1,2 })]
        [InlineData(new int[] {14,5,6,9,8,7 }, 3, new int[] {14,9,5,8,6,7})]
        public void Shuffle_WhenCalled_ShufflesArrayBasedOnGivenNinput(int[] inpArr,int n, int[] expected) {

            //arrange and act
            var result = ShuffleArray.Shuffle(inpArr,n);
            

            //assert
            Assert.Equal(expected, result);

        }
    }
}
