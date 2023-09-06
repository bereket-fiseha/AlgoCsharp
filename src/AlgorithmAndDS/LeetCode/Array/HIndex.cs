
using System;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Array
{

//    Given an array of integers citations where citations[i] is the number of citations a researcher received
//    for their ith paper, return the researcher's h-index.

//According to the definition of h-index on Wikipedia:
//The h-index is defined as the maximum value of h such that the given researcher has published at least h papers that have each been cited at least h times.



//Example 1:

//Input: citations = [3,0,6,1,5]
//    Output: 3
//Explanation: [3,0,6,1,5] means the researcher has 5 papers in total and each of them had received 3, 0, 6, 1, 5 citations respectively.
//Since the researcher has 3 papers with at least 3 citations each and the remaining two with no more than 3 citations each, their h-index is 3.
//Example 2:

//Input: citations = [1, 3, 1]
//Output: 1



//Constraints:

//n == citations.length
//1 <= n <= 5000
//0 <= citations[i] <= 1000

    //sort array
    //iterate through array from the largest(reverse traversal)
    //set each nums[i] as candidate
    //if (candidate<=i)
       //   return candidate

   //else
       //  hindex=i
   //return hindex

  //lesson
  //
    public class HIndex
    {
        public static int FindHIndex(int[] nums)
        {
            //sort array
            System.Array.Sort(nums);
           int lastIndex=nums.Length-1;
            int candidate = 0;
            int hIndex = 0;
            int j = 1;
            for (int i = lastIndex; i > 0; i--) {
                candidate = nums[i];
                if (candidate <= j)
                {
                    return Math.Max(candidate,hIndex);
                }
                else {
                    hIndex = j;
                    
                }
                j++;
            }
        
        return hIndex;
        }

    }
}
