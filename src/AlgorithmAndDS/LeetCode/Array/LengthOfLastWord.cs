using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Array
{
    #region instruction

    //    Given a string s consisting of words and spaces, return the length of the last word in the string.

    //A word is a maximal
    //substring
    // consisting of non-space characters only.



    //Example 1:

    //Input: s = "Hello World"
    //Output: 5
    //Explanation: The last word is "World" with length 5.
    //Example 2:

    //Input: s = "   fly me   to   the moon  "
    //Output: 4
    //Explanation: The last word is "moon" with length 4.
    //Example 3:

    //Input: s = "luffy is still joyboy"
    //Output: 6
    //Explanation: The last word is "joyboy" with length 6.


    //Constraints:

    //1 <= s.length <= 104
    //s consists of only English letters and spaces ' '.
    //There will be at least one word in s.

    #endregion

    public class LengthOfLastWord
    {

        public static int getLengthCSharp(string s)
        {
            s = s.TrimEnd();
            string[] subStrings = s.Split(" ");
            var lastWord = subStrings[subStrings.Length - 1];
            return lastWord.Length;
        }

        public static int getLength(string s)
        {
            string[] words = new string[s.Length];

            StringBuilder strnBuilder = new StringBuilder();
             int wordsLength = 0;
       for(int i=0;i<s.Length;i++)
            {
                char ch= s[i];
                if (ch == ' ')
                {
                    if (strnBuilder.Length!=0)
                    {
                        words[wordsLength++] = strnBuilder.ToString();
                        strnBuilder.Clear();
                    }
                }
                else
                {
                    strnBuilder.Append(ch);
                    if (i == s.Length - 1)
                    {
                        words[wordsLength++] = strnBuilder.ToString();


                    }
                }

            }
            return words[wordsLength-1].Length;
        }
    }
}