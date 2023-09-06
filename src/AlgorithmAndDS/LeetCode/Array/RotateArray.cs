using AlgorithmAndDS.StepsImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Array
{

    #region instruction
    //    Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.



    //Example 1:

    //Input: nums = [1,2,3,4,5,6,7,8,9], k = 3

    //Output: [7,8,9,1,2,3,4,5,6]
    //    Explanation:
    //rotate 1 steps to the right: [7,1,2,3,4,5,6]
    //    rotate 2 steps to the right: [6,7,1,2,3,4,5]
    //    rotate 3 steps to the right: [5,6,7,1,2,3,4]
    //    Example 2:

    //Input: nums = [-1,-100,3,99], k = 2
    //Output: [3,99,-1,-100]
    //    Explanation: 
    //rotate 1 steps to the right: [99,-1,-100,3]
    //    rotate 2 steps to the right: [3,99,-1,-100]


    //    Constraints:

    //1 <= nums.length <= 105
    //-231 <= nums[i] <= 231 - 1
    //0 <= k <= 105


    //Follow up:

    //Try to come up with as many solutions as you can.There are at least three different ways to solve this problem.
    //Could you do it in-place with O(1) extra space?


    #endregion

    public class RotateArray
    {

        public void RotateOnce(int[] nums)
        {

            var lastElement = nums[nums.Length - 1];
            for (int i = nums.Length - 1; i > 0; i--)
            {
                nums[i] = nums[i - 1];
            }
            nums[0] = lastElement;
        }


        public void Rotate(int[] nums, int k)
        {

            while (k > 0)
            {
                RotateOnce(nums);
                k--;
            }

        }
        //using modulus
        public static void  RotateEff(int[] nums, int k)
        {

            var newArr = new int[nums.Length];
            var len=nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                newArr[(i + k) % len] = nums[i];

            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = newArr[i];

            }
        }
    }
}
