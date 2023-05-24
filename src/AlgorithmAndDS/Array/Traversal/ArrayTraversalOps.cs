using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Array.Traversal
{
   public  class ArrayTraversalOps
    {
private readonly Util _util;

public ArrayTraversalOps(){

    _util=new Util();
}

public int[] ReverseArray(int[] givenArray){
    if(givenArray==null)
          return null;
    int start=0;
    int end=givenArray.Length-1;
    while(start<end){
_util.swap(givenArray,start,end);
start++;
end--;
    }
return givenArray;

}
public int[] TwoSum(int[] givenArray,int expectedValue){
if(givenArray==null)
      return null;
if(givenArray.Length==0)
    return givenArray;

bool twoSumFound=false;
int start=0;
var end=givenArray.Length-1;
   while(start<end &&!twoSumFound){
var sum=givenArray[start]+givenArray[end];
if(sum==expectedValue)
     twoSumFound=true;
else if(sum<expectedValue)
     start++;

else
    end--;     



   }

if(twoSumFound)
      return new int[]{start,end};
    return new int[]{-1,-1};
}

    }
}