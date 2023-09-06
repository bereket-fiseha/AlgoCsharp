using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Array
{

    #region    instruction
    //    Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

    //The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

    //You must write an algorithm that runs in O(n) time and without using the division operation.

    //Example 1:

    //Input: nums = [1, 2, 3, 4]
    //Output: [24,12,8,6]
    //Example 2:

    //Input: nums = [-1, 1, 0, -3, 3]
    //Output: [0,0,9,0,0]


    //Constraints:

    //2 <= nums.length <= 105
    //-30 <= nums[i] <= 30
    //The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.



    // Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)
    //solution


    //solution if division is allowed for

 
    #endregion
    public class ProductExceptSelf
    {
        public static int[] GetProduct(int[] nums)
        {
            int[] result = new int[nums.Length];
            int suffixProduct = 1;
            //prefix product

            for (int i = 0; i < nums.Length; i++) {
                if (i == 0)
                {
                    result[0] = 1;
                    continue;
                }
                result[i] = result[i - 1] * nums[i-1];
            }

            //product(prefix*suffix)

            for (int i = nums.Length-1; i >=0; i--)
            {
                if (i == nums.Length-1)
                {
                    continue;
                }
                suffixProduct *= nums[i + 1];
                result[i] *=suffixProduct;
            }


            return result;
        }

    }

}