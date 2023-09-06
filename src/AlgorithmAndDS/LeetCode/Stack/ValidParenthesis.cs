using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Stack
{
    public class ValidParenthesis
    {

        #region instruct
        //        Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        //  An input string is valid if:

        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.
        //Every close bracket has a corresponding open bracket of the same type.


        //Example 1:

        //Input: s = "()"
        //Output: true
        //Example 2:

        //Input: s = "()[]{}"
        //Output: true
        //Example 3:

        //Input: s = "(]"
        //Output: false

        //Input: s = ""{[]}""
        //Output: true


        //Constraints:

        //1 <= s.length <= 104
        //s consists of parentheses only '()[]{}'.

        #endregion
        public static bool CheckIfValid(string strn) {
            Stack<char> stack = new Stack<char>();
            char[] opening = new char[] {'(','{','[' };

            char[] closing = new char[] { ')', '}', ']' };


            for (int i = 0; i < strn.Length; i++) {
                int k = 0;
                bool isOpening = false;
                while (k < opening.Length) {
                    if (strn[i] == opening[k]) {
                        stack.Push(strn[i]);
                        isOpening = true;
                    }
                    k++;
                }
                k = 0;
                while (!isOpening && k < closing.Length)
                {
                    if (strn[i] == closing[k] )
                    {if (stack.Count != 0&&stack.Peek() == opening[k])
                            stack.Pop();
                        else
                            return false;
                    }
                 
                    k++;
                }
            
            }
            return stack.Count == 0;
        }
    }
}
