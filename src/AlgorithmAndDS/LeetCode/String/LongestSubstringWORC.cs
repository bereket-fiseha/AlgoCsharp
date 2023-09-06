using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.String
{
    public  class LongestSubstringWithoutRepeatingCharacters
    {

        #region instruction

        //        Given a string s, find the length of the longest
        //substring
        // without repeating characters.



        //Example 1:

        //Input: s = "abcabcbb"
        //Output: 3
        //Explanation: The answer is "abc", with the length of 3.
        //Example 2:

        //Input: s = "bbbbb"
        //Output: 1
        //Explanation: The answer is "b", with the length of 1.
        //Example 3:

        //Input: s = "pwwkew"
        //Output: 3
        //Explanation: The answer is "wke", with the length of 3.
        //Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.


        //Constraints:

        //0 <= s.length <= 5 * 104
        //s consists of English letters, digits, symbols and spaces.
        #endregion

        public static int SubString(string s) { 
        Dictionary<char,int> dict=new Dictionary<char, int>();
        
            int maxCount = 0;
            int count = 0;
            int[] charCount = new int[26];
            char[] chars = new char[] {
            'a','b','c','d','e','f','g','h','i','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
            
            };
            for (int i = 0; i < s.Length; i++) {

                if (dict.ContainsKey(s[i]))
                {
                    if (count > maxCount)
                        maxCount = count;
                    dict.Clear();
                    dict.Add(s[i], 1);
                    count = 1;
                }
                else
                {
                    dict.Add(s[i], 1);
                    count++;
                }

            }
            return maxCount;
        }

    }
}
