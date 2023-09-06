using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Array
{
    public class Merge
    {
        #region instruction

        //    You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
        //    and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

        //Merge nums1 and nums2 into a single array sorted in non-decreasing order.

        //The final sorted array should not be returned by the function,
        //but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n,
        //where the first m elements denote the elements that should be merged,
        //and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

        //    Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        //Output: [1,2,2,3,5,6]


        //Explanation: The arrays we are merging are[1, 2, 3] and[2, 5, 6].
        //The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.

        #endregion
        public static int[] MergeSortedArray(int[] nums1, int[] nums2)
        {

            var nums3 = new int[nums1.Length + nums2.Length];
            int lenNums1 = nums1.Length;
            var i = 0;
            var j = 0;
            var k = 0;
            while (i < lenNums1)
            {
                if (j >= nums2.Length || nums1[i] <= nums2[j])
                {
                    nums3[k] = nums1[i];
                    k++;
                    i++;

                }

                else
                {
                    nums3[k] = nums2[j];
                    k++;
                    j++;
                }


            }
            while (j < nums2.Length)
            {
                nums3[k] = nums2[j];
                k++;
                j++;
            }
            return nums3;
        }


        public static void ShiftArrayToRightFromGivenIndex(int[] nums, int index)
        {

            for (int i = nums.Length - 2; i >= index; i--)
            {
                nums[i + 1] = nums[i];
            }

        }
        //m is the length of nums1 without the placeholder values
        public static void MergeSortedArraysInPlace(int[] nums1, int[] nums2, int m)
        {

            var i = 0;
            var j = 0;
            while (i < m)
            {
                if (j >= nums2.Length)
                {

                    break;
                }
                if (j >= nums2.Length || nums1[i] <= nums2[j])
                {
                    //do nothing
                }
                else
                {
                    ShiftArrayToRightFromGivenIndex(nums1, i);
                    nums1[i] = nums2[j];
                    m++;
                    j++;
                }

                i++;
            }
            while (j < nums2.Length)
            {
                nums1[i] = nums2[j];
                i++;
                j++;
            }
            return;
        }


        public static void MergeSortEff(int[] nums1, int[] nums2, int m)
        {
            int n = nums2.Length;
            int p1 = m - 1;
            int p2 = n - 1;
            int i = m + n - 1;
            while (p2 >= 0)
            {
                if (p1 >= 0 && nums1[p1] >= nums2[p2])
                {
                    nums1[i--] = nums1[p1--];
                }
                else
                {
                    nums1[i--] = nums2[p2--];
                }

            }


        }
    }
}