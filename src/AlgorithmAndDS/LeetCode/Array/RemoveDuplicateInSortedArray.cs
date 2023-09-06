using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AlgorithmAndDS.LeetCode.Array
{
    #region instruction

    //    Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place
    //    such that each unique element appears only once.The relative order of the elements should be kept the same.
    //    Then return the number of unique elements in nums.

    //Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

    //Change the array nums such that the first k elements of nums contain the unique elements in the order they were
    //present in nums initially.The remaining elements of nums are not important as well as the size of nums.
    //Return k.


    //Custom Judge:

    //The judge will test your solution with the following code:

    //int[] nums = [...]; // Input array
    //    int[] expectedNums = [...]; // The expected answer with correct length

    //    int k = removeDuplicates(nums); // Calls your implementation

    //    assert k == expectedNums.length;
    //for (int i = 0; i<k; i++) {
    //    assert nums[i] == expectedNums[i];
    //}
    //If all assertions pass, then your solution will be accepted.



    //Example 1:

    //Input: nums = [1, 1, 2]
    //Output: 2, nums = [1, 2, _]
    //Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
    //It does not matter what you leave beyond the returned k (hence they are underscores).

    //[0,1,,2,2,3,4]

    //[0,1,2,3,4,_]
    //Example 2:
    //0 i=1 k=1
    //1  i=1 k=1
    //2  i=2 k=2

    // 4  i =6 k =3
    //Input: nums = [0, 0, 1, 1, 1, 2, 2,3, 3, 3, 4,5]
    //Output: 5, nums = [0, 1, 2, 3, 4,5, _, _, _, _, _]
    //Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
    //It does not matter what you leave beyond the returned k (hence they are underscores).


    //Constraints:

    //1 <= nums.length <= 3 * 104
    //- 100 <= nums[i] <= 100
    //nums is sorted in non - decreasing order.
    #endregion


    //*****Possible Solutions*******


    //1 (O(nlogn))
    // int maxInt= nums[nums.Length-1]+1
    //int k=nums.Length;
    // loop through array
    // replace the duplicates  with maxInt and decrement k
    //end loop
    //sort array
    //return k and nums


    //2 partitioning with forward traversal

    //loop through array
    // partion array to sorted non duplicated array and sorted duplicated array
    // k= sortednonduplicatedarrayindex =0(the length of sorted non duplicated arrays)
    // for each iteration 
    // compare ith element to previous element 
    // if equal -its duplicate
    //  i++ ,
    //end if
    //else
    //swap(i,k) if(k!=i)
    //k++
    //i++

    //Lesson
    // partitioning array to 2 blocks 
    // inserting items from one block to the "requirement fullfilling" block
    public class RemoveDuplicateInSortedArray
    {

        public static int RemoveDuplicate(int[] nums)
        {

            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i - 1] != nums[i])
                {
                    if (k != i)
                    {

                        nums[k] = nums[i];

                    }
                    k++;
                }

            }
            return k;
        }

    }
}
