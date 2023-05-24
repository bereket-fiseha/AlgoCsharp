using AlgorithmAndDS.Array.Partioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.Partitioning
{
   public  class PartitioningAlgoTests
    {
        [Theory]
        [InlineData(new int[] { 0,0,0,0,0,0 },new int[] { 0,0,0,0,0,0})]
        [InlineData(new int[] { 3, 0, 2, -9, 0, 8 }, new int[] { 0,0, 3, 2, -9, 8 })]
        [InlineData(new int[] { 3, -4,0 },new int[] {0, 3, -4 })]
        [InlineData(new int[] { 3, 4}, new int[] {  3, 4 })]
        public void moveAllZerosToFront_IfGivenArrayContainsElements_MovesZerosToFrontOfArray(int[] arr,  int[] expected)
        {
            //arrange
            PartitioningAlgo algo = new PartitioningAlgo();
            //act
            var actual = algo.moveAllZerosToFront(arr);
            //assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(new int[] {  }, new int[] {  })]
        public void moveAllZerosToFront_IfGivenArrayIsNullOrEmpty_ReturnArray(int[] arr, int[] expected)
        {
            //arrange
            PartitioningAlgo algo = new PartitioningAlgo();
            //act
            var actual = algo.moveAllZerosToFront(arr);
            //assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0 })]
        [InlineData(new int[] { 3, 0, 2, -9, 0, 8 }, new int[] {  3, 2, -9, 8 ,0,0})]
        [InlineData(new int[] { 3, -4, 0 }, new int[] { 3, -4,0 })]
        [InlineData(new int[] { 3, 4 }, new int[] { 3, 4 })]
        public void moveAllZerosToEnd_IfGivenArrayContainsElements_MovesZerosToEndOfArray(int[] arr, int[] expected)
        {
            //arrange
            PartitioningAlgo algo = new PartitioningAlgo();
            //act
            var actual = algo.moveAllZerosToEnd(arr);
            //assert
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(new int[] { 3, 0,10, 2,4,5,6, -9, 0, 8 }, 5,new int[] { 3,0,0,2,4,-9,5,6,8,10})]
        [InlineData(new int[] { 6,6,7,2,3,4,8,9}, 6, new int[] { 4,2,3,6,6,8,9,7 })]
        [InlineData(new int[] { 3, -4, 0 }, -2,new int[] { -4,0,3 })]
        [InlineData(new int[] { 3, 4 ,6},7, new int[] { 3, 4,6 })]
        public void moveElementToProperSegment_IfGivenArrayContainsElements_PlacesElementToItsCorrectSegment(int[] arr,int pivot, int[] expected)
        {
            //arrange
            PartitioningAlgo algo = new PartitioningAlgo();
            //act
            var actual = algo.moveElementToProperSegment(arr,pivot);
            //assert
            Assert.Equal(expected, actual);

        }



    }
}
