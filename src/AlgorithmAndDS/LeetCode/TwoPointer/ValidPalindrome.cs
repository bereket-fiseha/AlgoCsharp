using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.TwoPointer
{
    public class ValidPalindrome
    {
        #region
//        A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

//        Given a string s, return true if it is a palindrome, or false otherwise.



//        Example 1:

//Input: s = "A man, a plan, a canal: Panama"
//Output: true
//Explanation: "amanaplanacanalpanama" is a palindrome.
//Example 2:

//Input: s = "race a car"
//Output: false
//Explanation: "raceacar" is not a palindrome.
//Example 3:

//Input: s = " "
//Output: true
//Explanation: s is an empty string "" after removing non-alphanumeric characters.
//Since an empty string reads the same forward and backward, it is a palindrome.



//Constraints:

//1 <= s.length <= 2 * 105
//s consists only of printable ASCII characters.

    #endregion
      

        public static bool IsValid(string s) {
            s=s.ToLower();
            Regex reg = new Regex("[^a-z0-9]");
            //replace nonalphanumeric with whitespace
            s = reg.Replace(s," ");

            //trim string
  
            int i = 0;
            int j = s.Length - 1;
            while (i < j) {

                if (s[i] == ' ')
                    i++;
                else if (s[j] == ' ')
                    j--;
                else
                {
                    if (s[i] != s[j])
                        return false;
                    i++;
                    j--;
                }
            }


            return true;
        }

    }
}
