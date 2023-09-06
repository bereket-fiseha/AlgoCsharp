using AlgorithmAndDS.Array.Partioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String
{
    public class MaxChar
    {
        private string _str;

      public  MaxChar(string strn) { 
        
        _str = strn;
        }
        //return max char present in the string
        public char? MaxCharFirImp() {
            if (string.IsNullOrEmpty(_str))
                return null;
            if(_str.Length==1)
                 return _str[0];
           
            var dict=new Dictionary<char, int>();
            var max = 1;
            char ch = _str[0];
            foreach (char c in _str) {
                if (dict.Keys.Contains(c))
                {
                    dict[c] += 1;
                    if (dict[c] > max)
                    {
                        max = dict[c];
                        ch = c;
                    }

                }
                else
                {
                    dict[c] = 1;
                
                }

            }
            return ch;

        }
      }
}
