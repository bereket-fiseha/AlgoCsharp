using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AlgorithmAndDS.LeetCode.Array
{
    //    You are given an array prices where prices[i] is the price of a given stock on the ith day.

    //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day
    //in the future to sell that stock.

    //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.




    //Example 1:

    //Input: prices = [7, 1, 5, 3, 6, 4]
    //Output: 5
    //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    //Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
    //Example 2:

    //Input: prices = [7,6,4,3,1]
    //    Output: 0
    //Explanation: In this case, no transactions are done and the max profit = 0.


    //Constraints:

    //1 <= prices.length <= 105
    //0 <= prices[i] <= 104


    //solution
    //buyIndex=0;
    //sellIndex=0;
    //maxProfit=0;
    //iterate through array
    // set buy candidate with buyIndex=0(the first ele)
    // if the next element(i) is lower then buyIndex thus set buyIndex = i
    // if the next element(i) is greater then buyIndex thus set sellIndex = i
    // and calculate maxProfit=nums[sellIndex] 
    // if the next element(i) is lower then buyIndex thus set new buyIndex = i
    // if the next element(i) is greater then buyIndex thus set sellIndex = i
    // and calculate maxProfit=nums[sellIndex] ,and compare with prev maxProfit and set maxProfit 
    // continue
    
    //lesson
    //by using two pointer solution , seting a candidate for buying and selling 
    //loop through array and calculate maxprofit
    
    
    public class BuyAndSellStockOnce
    {

        public static int[] MaxProfit(int[] nums) {
            int maxProfit = 0;
            int buyCandidateIndex = 0;
            int buyAt = 0;
            int sellAt = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] <= nums[buyCandidateIndex])
                    buyCandidateIndex = i;

                else {
                    var profit = nums[i] - nums[buyCandidateIndex];
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                        sellAt = i;
                        buyAt = buyCandidateIndex;
                    }
                }

            
            }


            return new int[] {buyAt,sellAt, maxProfit };
        }
    }
}
