using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.String
{

    #region instruction
//    Given an input string s, reverse the order of the words.

//A word is defined as a sequence of non-space characters.The words in s will be separated by at least one space.

//Return a string of the words in reverse order concatenated by a single space.

//Note that s may contain leading or trailing spaces or multiple spaces between two words.The returned string should only have a single space separating the words. Do not include any extra spaces.




//Example 1:

//Input: s = "the sky is blue"
//Output: "blue is sky the"
//Example 2:

//Input: s = "  hello world  "
//Output: "world hello"
//Explanation: Your reversed string should not contain leading or trailing spaces.
//Example 3:

//Input: s = "a good   example"
//Output: "example good a"
//Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.



//Constraints:

//1 <= s.length <= 104
//s contains English letters (upper-case and lower-case), digits, and spaces ' '.
//There is at least one word in s.


//Follow-up: If the string data type is mutable in your language, can you solve it in-place with O(1) extra space?

    #endregion
    public class ReverseWordsInString
    {

        public static string ReverseWordInPlace(string st) {

          var  str = st.ToCharArray();
            for (int i = 0; i < str.Length/2; i++)
            {
                char temp = str[i];
                str[i] = str[str.Length - i - 1];
                str[str.Length - i - 1] = temp;
            
            
            }
            return new StringBuilder().Append(str).ToString();
        }


        public static string ReverseStringInPlace(string str)
        {
            StringBuilder sbString = new();
            StringBuilder sbWord = new();
            int wordLength = 0;
            char[] chars = str.ToCharArray();
            for (int i = chars.Length-1; i >0; i--) {
                if (chars[i] == ' ' && wordLength != 0)
                {
                  
                    
                    sbString.Append(ReverseWordInPlace(sbWord.ToString()));
                    if(i!=chars.Length-1)
                           sbString.Append(" ");
                        
                    sbWord.Clear();
                    wordLength = 0;
                   
                }
                else if(chars[i]!=' ') {

                    sbWord.Append(chars[i]);
                    wordLength++;
                    if (i == chars.Length-1) {
                        sbString.Append(ReverseWordInPlace(sbWord.ToString()));

                    }

                }
            
            
            }


return sbString.ToString(); 
        }






        public static string ReverseStringUsingStack(string str)
        {
            StringBuilder sbString = new();
            StringBuilder sbWord = new();
            Stack<string> stackOfStrings = new();
            int wordLength = 0;
           // char[] chars = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && wordLength != 0)
                {

                        stackOfStrings.Push(sbWord.ToString());
                        //stackOfStrings.Push(" ");
                        sbWord.Clear();
                        wordLength = 0;
                  

                }
                else if (str[i]!=' ')
                {

                    sbWord.Append(str[i]);

                    wordLength++;
                    //last char
                    if (i == str.Length-1) {
                        stackOfStrings.Push(sbWord.ToString());
                        }
                }


            }


            while(stackOfStrings.Count>0) {

                sbString.Append(stackOfStrings.Pop());
            if(stackOfStrings.Count != 0) {
                    sbString.Append(" ");
                }
            
            }

            return sbString.ToString();
        }







        public static string Reverse(string str) {

            str = str.Trim();
            var wordArray=str.Split(' ');
            
            StringBuilder sb = new();
            for (int i = wordArray.Length-1; i >= 0; i--) {
                if (wordArray[i]!="")
                {
                    sb.Append(wordArray[i]);

                }
                else {
                    continue;
                }
                if(i!=0)
                     sb.Append(" ");
            }
        return sb.ToString();
        }
    }
}
