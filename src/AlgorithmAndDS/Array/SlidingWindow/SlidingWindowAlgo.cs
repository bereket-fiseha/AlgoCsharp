using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Array.SlidingWindow
{
  public  class SlidingWindowAlgo
    {



        //1. Given an array of positive numbers and a positive number ‘k’,
        //    find the maximum sum of any contiguous subarray of size ‘k’.



        public int dummy_maxSubArrayGivenK(int[] givenArr, int k)
        {

            return -1;
        }
        public int maxSubArrayGivenK(int[] givenArr, int k) {
            int maxSum = 0;
            int sum = 0;
            for (int i = 0; i < givenArr.Length-k; i++) {
if(i>k){
sum+=-givenArr[i-1]+givenArr[i+k];
maxSum=maxSum>sum?maxSum:sum;
}
else{sum+=givenArr[i];
   maxSum=sum;}


            }


        return maxSum;
 }
    }
}
