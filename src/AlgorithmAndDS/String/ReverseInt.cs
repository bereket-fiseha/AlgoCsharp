using AlgorithmAndDS.Array.Partioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String
{
    public class ReverseInt
    {
        private int _num;

      public  ReverseInt(int num) { 
        
        _num = num;
        }

        private string ReverseString(string strn)
        {var strChars=strn.ToCharArray();
          var  i = 0;
            var j = strChars.Length - 1;
           
            while (i < j)
            { var temp = strChars[i];
                strChars[i] = strChars[j];
                strChars[j] = temp;
                i++;
                j--;
            
            }  

            return new StringBuilder().Append(strChars).ToString();
        }

        private string RemoveLeadingZeros(string strn) {
            var strChars = strn.ToCharArray();  
            var i = 0;
            StringBuilder sb = new StringBuilder();
            var j = 0;
            while (i < strChars.Length) {

                if ((int)strChars[i] == 0)
                {
                    j++;
                    continue;

                }
                else {
                    break;
                }
            
            }
            while (j < strChars.Length) {
                sb.Append(strChars[j]);
                j++;
            }
        
        return sb.ToString();
        }

        class H {public string stu { get; set; } }
        public int ReverseIntFirImp() {
    

            var strn = _num.ToString();
            int result;
           
            var reversedString = ReverseString(strn.TrimStart('-'));
             int.TryParse(reversedString,out result);
            return result *(Math.Sign(_num));
        }
        
    }
}
