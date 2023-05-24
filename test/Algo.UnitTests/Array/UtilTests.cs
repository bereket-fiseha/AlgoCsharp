using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmAndDS.Array;
using AlgorithmAndDS.Array.Traversal;
using Xunit;

namespace Algo.UnitTests.Array
{
    public class UtilTests
    {

        [Theory]
        [InlineData(new int[]{},new int[]{},3,4)]
        [InlineData(null,null,3,4)]
public void Swap_IfGivenArrayIsNullOrEmpty_ReturnsTheGivenArray(int[] arr,int[] expected,int index1,int index2){
//arrange
Util ops= new Util();
//act
ops.swap(arr,index1,index2);
//assert
Assert.Equal(expected,arr);

}


        [Theory]
        [InlineData(new int[]{3,6,8,9},1,2,new int[]{3,8,6,9})]
   
public void Swap_IfGivenArrayContainsElements_ReturnsTheSwapedArray(int[] arr,int index1,int index2,int[] expected){
//arrange
Util ops= new Util();
//act
ops.swap(arr,index1,index2);
//assert
Assert.Equal(expected,arr);

}


        [Theory]
        [InlineData(new int[] {3,4,2,9,11,8 }, 2, 4, new int[] { 3,4,9,11,2,8 })]
        [InlineData(new int[] { 3, 4, 2, 9, 11, 8 }, 4, 0, new int[] { 11,3, 4,2, 9, 8 })]
        [InlineData(new int[] { 3, 4,}, 0, 1, new int[] { 4,3})]
        public void SwapUpToIndex_IfGivenArrayContainsElements_ReturnsTheSwapedArray(int[] arr, int index1, int index2, int[] expected)
        {
            //arrange
            Util arrUtility = new Util();
            //act
            arrUtility.swapUptoIndex(arr, index1, index2);
            //assert
            Assert.Equal(expected, arr);

        }

        [Theory]
               [InlineData(new int[] { 3, 4, }, 0, 2)]
        public void SwapUpToIndex_IfDesiredIndexOrCurrentIndexAreOutOfRange_ThrowsIndexOutOfBoundException(int[] arr, int index1, int index2)
        {
            //arrange
            Util ops = new Util();
            //assert
            Assert.Throws<IndexOutOfRangeException>(() => ops.swapUptoIndex(arr, index1, index2));

        }

        [Theory]
        [InlineData(new int[] { }, new int[] { },3,4)]
        [InlineData(null, null,3,4)]
        public void swapUptoIndex_IfGivenArrayIsNullOrEmpty_ReturnsTheGivenArray(int[] arr, int[] expected,int index1,int index2)
        {
            //arrange
            Util arrUtility = new Util();
            //act
            arrUtility.swapUptoIndex(arr, index1, index2);
            //assert
              Assert.Equal(expected, arr);

        }



        


    }
}
