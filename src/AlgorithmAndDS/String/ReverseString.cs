using AlgorithmAndDS.Array.Partioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String
{
    public class ReverseString
    {
        private string _str;

      public  ReverseString(string strn) { 
        
        _str = strn;
        }

        public string ReverseFirImp() {
            if (string.IsNullOrEmpty(_str))
                return _str;
            var strn = "";
            StringBuilder sb = new StringBuilder();
            char[] strChars=_str.ToCharArray();
            for (int i = 0; i < strChars.Length / 2; i++)
            {
                 var temp = strChars[i];
                strChars[i] = strChars[strChars.Length-i-1];
                strChars[strChars.Length - i - 1] = temp;

            }
            sb.Append(strChars);
            return sb.ToString();
        
        }
        public string ReverseSecImp()
        {
            if (string.IsNullOrEmpty(_str))
                return _str;
            var i = 0;
            var j = _str.Length - 1;
            
            StringBuilder sb = new StringBuilder();
            char[] strChars = _str.ToCharArray();
            while (i < j) { 
                var temp = strChars[i];
                strChars[i] = strChars[j];
                strChars[j] = temp;
                i++;
                j--;
            }
            sb.Append(strChars);
            return sb.ToString();

        }
        public string ReverseThirdImp()
        {
            var strn= _str.Reverse().ToArray();

            return new StringBuilder().Append(strn).ToString(); 
        }
    }
}
