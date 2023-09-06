using AlgorithmAndDS.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array.LeetCode
{
    public class MergeSortedArrayTests
    {

        [Theory]
        [InlineData(new int[] {2,3,5,6,9 },new int[] { 1,2,4,7,8,13,14},new int[] {1,2,2,3,4,5,6,7,8,9,13,14 })]

        [InlineData(new int[] { 2, 3, 5, 6 }, new int[] {   4, 7, 8, 13,19,20 }, new int[] {  2,3,4, 5, 6, 7, 8, 13,19,20 })]
        [InlineData(new int[] { 2, 3, 5, 6,9,30,40,50 }, new int[] {0, 4, 7, 8, 13, 19, 20 }, new int[] { 0, 2,3, 4, 5, 6, 7, 8, 9,13,19, 20,30,40,50 })]

        public void MergeSortedArray_WhenCalled_MergesAndReturnsMergedArray(int[] nums1, int[] nums2, int[] expected) { 
        
           //arrange and Act
          var actual=  Merge.MergeSortedArray(nums1, nums2);
      
            //assert
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(new int[] { 2, 3, 5, 6, 9 },0, new int[] { 2,2,3,5,6 })]

        [InlineData(new int[] { 2, 3, 5, 6 },1, new int[] { 2,3,3,5})]
        [InlineData(new int[] { 9, 8, 5, 6,7,5,4,3}, 3, new int[]{9,8,5,6,6,7,5,4 })]

        public void ShiftArrayToRightFromIndex_WhenCalled_ShiftsArrayToRight(int[] nums1, int index, int[] expected)
        {

            //arrange and Act
            Merge.ShiftArrayToRightFromGivenIndex(nums1, index);

            //assert
            Assert.Equal(expected, nums1);

        }



        [Theory]
        [InlineData(new int[] { 2, 3, 5, 6, 9,0,0,0,0,0 }, new int[] { 1, 2, 4, 7, 8 },5, new int[] { 1, 2, 2, 3, 4, 5, 6, 7, 8, 9 })]

        [InlineData(new int[] { 2, 3, 5, 6,0,0,0,0,0,0 }, new int[] { 4, 7, 8, 13, 19, 20 },4, new int[] { 2, 3, 4, 5, 6, 7, 8, 13, 19, 20 })]
        [InlineData(new int[] { 2, 3, 5, 6, 9, 30, 40, 50,0,0,0,0,0,0,0 }, new int[] { 0, 4, 7, 8, 13, 19, 20 },8 ,new int[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 13, 19, 20, 30, 40, 50 })]

        public void MergeSortedArrayInPlace_WhenCalled_MergesInPlace(int[] nums1, int[] nums2,int m, int[] expected)
        {

            //arrange and Act
            Merge.MergeSortEff(nums1, nums2,m);

            //assert
            Assert.Equal(expected, nums1);

        }




    }
}
