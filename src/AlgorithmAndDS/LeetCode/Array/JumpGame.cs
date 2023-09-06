using AlgorithmAndDS.StepsImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Array
{

    //    You are given an integer array nums.You are initially positioned at the array's first index,
    //    and each element in the array represents your maximum jump length at that position.

    //Return true if you can reach the last index, or false otherwise.



    //Example 1:

    //Input: nums = [2,3,1,1,4]
    //    Output: true
    //Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
    //Example 2:

    //Input: nums = [3,2,1,0,4]
    //    Output: false
    //Explanation: You will always arrive at index 3 no matter what.Its maximum jump length is 0, which makes it impossible to reach the last index.


    //Constraints:

    //1 <= nums.length <= 104
    //0 <= nums[i] <= 105

    //Solution
    //step=1
    //winstart=len(arr)-2
    //transverse from the back of the array 
       // check if every element >= step
               // step=1

       // else
        //  step+=1
       //once i==0
            //return  step<=arr[0]

    //lesson
    //transversing from the back of the array,
    //sliding the window by 1 more item on every iteration and checking for every item
    //if it can be reached from each item
    //if it can't be reached(eg item value = 0 ) ,thus the item in the left should be >= step+1
    //in the end the first item(i=0) should be >= step  ,if so return true
    // if not return false

    public class JumpGame
    {

        public static bool CheckIfEndIsReachableFromStart(int[] nums) {
            if (nums.Length == 1)
                return true;
  
            int step = 1;

            int windStart = nums.Length - 2;
            for (int i = windStart; i >= 0; i--) {
                if (i == 0)
                    return nums[0] >= step;
                else if (nums[i] >= step)
                    step = 1;
                else
                    step += 1;


            }
            return false;
        
        
        }


        public static  bool ShortestTransversalToReachEndFromStart(int[] nums) { 


        int step = 1;
            int minStep = nums.Length-1;
        int windStart = nums.Length - 2;
            for (int i = windStart; i >= 0; i--) {
                if (i == 0)
                    return nums[0] >= step;
                else if (nums[i] >= step)
                {
                    step = 1;
                }
                else
                    step += 1;


            }
            return false;
        
        
        }

    }
}
