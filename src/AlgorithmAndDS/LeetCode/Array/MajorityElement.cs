using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmAndDS.LeetCode.Array
{

    #region instruction

    //    Given an array nums of size n, return the majority element.

    //The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.



    //Example 1:

    //Input: nums = [3, 2, 3]
    //Output: 3
    //Example 2:

    //Input: nums = [2, 2, 1, 1, 1, 2, 2]
    //Output: 2


    //Constraints:

    //n == nums.length
    //1 <= n <= 5 * 104
    //-109 <= nums[i] <= 109

    //soln 1
    //-4 -3 -2 -1 0 1 2 3 4
    // 0 0 0 1  2 1 3 8 4 3
    //namespace n/2 n/2
    //counting check

    //Follow-up: Could you solve the problem in linear time and in O(1) space?

    //solution
    // traverse through array  ,count=0 ,ele=0;
    // set the first element as candidate to be the majority element and set count=1
    //if the next elements are the same as the first element set count++
    //else count--
    //if count=0 ,set the ith element as a candidate to be majority element  and set count=1
    //if the next elements are the same as the new candidate set count++
    //else count--
    //if count=0 ,set the current element as candidate and set count=1

    //Lesson  
    // to find an item that has major occurence
    // we can set a candidate and increase count or decrease count as we transverse the array
    #endregion

    public class MajorityElement
    {


        public static int FindMajEff(int[] nums)
        {
            int count = 0;
            int ele = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    ele = nums[i];
                    count = 1;
                }
                if (nums[i] == ele)
                {
                    count++;
                }
                else
                {
                    count--;
                }

            }
            return ele;

        }

        public static int FindMajorityElement(int[] nums)
        {

            int[] indexes = new int[218];

            for (int i = 0; i < nums.Length; i++)
            {

                indexes[nums[i] + 109] += 1;
            }
            int max = 0;
            int j = 0;
            int k = 0;
            while (j < indexes.Length)
            {

                if (indexes[j] > max)
                {
                    max = indexes[j];
                    k = j;
                }
                j++;
            }
            return k - 109;
        }
    }
}
