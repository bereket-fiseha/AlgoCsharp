using AlgorithmAndDS.Array.Partioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String
{ 
    //palindrome string is a string which is identical to its reversed string

    public class PalindromeString
    {
        private string _str;

      public  PalindromeString(string strn) { 
        
        _str = strn;
        }

        public bool PalindromeFirImp() {
            if (string.IsNullOrEmpty(_str))
                     return false;
         var strChars=_str.ToCharArray();
         var   i= 0;
         var    j= strChars.Length-1;
            while (i < j)
            {
                if (strChars[i] != strChars[j]) {
                    return false;
                
                }
                i++;    
                j--;    
            }
            return true;
        }
        public bool PalindromeSecImp()
        {
            if (string.IsNullOrEmpty(_str))
                return false;
            var temp = _str.Reverse().ToArray();
            var reversedStr=new StringBuilder().Append(temp).ToString();


            return reversedStr == _str;
        }
       
    }
}
