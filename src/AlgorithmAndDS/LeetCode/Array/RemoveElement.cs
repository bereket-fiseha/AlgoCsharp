﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace AlgorithmAndDS.LeetCode.Array
{

    #region instruction
    //    Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.
    //    The order of the elements may be changed.Then return the number of elements in nums which are not equal to val.

    //Consider the number of elements in nums which are not equal to val be k, to get accepted,
    //you need to do the following things:

    //Change the array nums such that the first k elements of nums contain the elements which are not equal to val.
    //The remaining elements of nums are not important as well as the size of nums.
    //Return k.

    //The judge will test your solution with the following code:
    //    int[] nums = [...]; // Input array
    //int val = ...; // Value to remove
    //int[] expectedNums = [...]; // The expected answer with correct length.
    //                            // It is sorted with no values equaling val.

    //int k = removeElement(nums, val); // Calls your implementation

    //assert k == expectedNums.length;
    //sort(nums, 0, k); // Sort the first k elements of nums
    //for (int i = 0; i<actualLength; i++) {
    //    assert nums[i] == expectedNums[i];
    //}

    //Example one 
    //    Input: nums = [3,2,2,3], val = 3
    //Output: 2, nums = [2,2,_,_]
    //Explanation: Your function should return k = 2, with the first two elements of nums being 2.
    //It does not matter what you leave beyond the returned k(hence they are underscores).

    //    //Example Two
    //    Input: nums = [0,1,2,2,3,0,4,2], val = 2
    //Output: 5, nums = [0,1,4,0,3,_,_,_]
    //Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
    //Note that the five elements can be returned in any order.
    //It does not matter what you leave beyond the returned k (hence they are underscores).
    #endregion

    //solution(o(n))
    //iterate through the array from the end of the array
    // k =counter of valid elements
    // decrement k if invalid element is found(invalid = element to  be removed)
    // swap the element(invalid element) with the element at k(use --k to access the item)
    public class RemoveElement

    {

        public static void swap(int[] nums, int index1, int index2)
        {

            var temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;

        }
        public static int Remove(int val, int[] nums)
        {

            int k = nums.Length;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == val)
                {

                    nums[i] = nums[--k];
                }

            }
            return k;
        }
    }
}
