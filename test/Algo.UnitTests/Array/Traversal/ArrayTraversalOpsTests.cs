using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmAndDS.Array.Traversal;
using Xunit;

namespace Algo.UnitTests.Array.Traversal
{
    public class ArrayTraversalOpsTests
    {

        [Theory]
        [InlineData(new int[]{},new int[]{})]
        [InlineData(null,null)]
public void ReverseArray_IfGivenArrayIsNullOrEmpty_ReturnsTheGivenArray(int[] arr,int[] expected){
//arrange
ArrayTraversalOps ops= new ArrayTraversalOps();
//act
int[] actual=ops.ReverseArray(arr);
//assert
Assert.Equal(actual,expected);

}
        [Theory]
        [InlineData(new int[]{2},new int[]{2})]
        [InlineData(new int[]{2,6,1},new int[]{1,6,2})]
        [InlineData(new int[]{2,4,7},new int[]{7,4,2})]
        
public void ReverseArray_IfArrayContainsElements_ReturnsTheReversedArray(int[] arr,int[] expected){
//arrange
ArrayTraversalOps ops= new ArrayTraversalOps();
//act
int[] actual=ops.ReverseArray(arr);
//assert
Assert.Equal(actual,expected);

}

[Theory]
 [InlineData(new int[]{2,4,7,9,19},23,new int[]{1,4})]
 
 [InlineData(new int[]{-2,-4,7,9,20},18,new int[]{0,4})]
public void TwoSum_IfArrayContainsTwoNumbersForGivenSum_ReturnsIndexesOfElements(int[] givenArray,int expectedSum,int[] expectedIndexes){
//arrange
ArrayTraversalOps ops=new ArrayTraversalOps();

//act
var actual =ops.TwoSum(givenArray,expectedSum);

//assert
Assert.Equal(actual,expectedIndexes);

}
   [Theory]
 [InlineData(new int[]{2,4,7,9,19},25,new int[]{-1,-1})]
public void TwoSum_IfArrayDoesnotContainTwoNumbersForGivenSum_ReturnsNegativeOne(int[] givenArray,int expectedSum,int[] expectedIndexes){

//arrange
ArrayTraversalOps ops=new ArrayTraversalOps();

//act
var actual =ops.TwoSum(givenArray,expectedSum);

//assert
Assert.Equal(expectedIndexes,actual);
    
}
   [Theory]
 [InlineData(new int[]{},25,new int[]{})]
 
 [InlineData(null,25,null)]
public void TwoSum_IfArrayIsNullOrEmpty_ReturnsNullOrEmpty(int[] givenArray,int expectedSum,int[] expectedIndexes){

//arrange
ArrayTraversalOps ops=new ArrayTraversalOps();

//act
var actual =ops.TwoSum(givenArray,expectedSum);

//assert
Assert.Equal(actual,expectedIndexes);
    
}

    }
}
