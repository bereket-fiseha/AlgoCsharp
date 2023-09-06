using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Array
{
    public  class LongestCommonPrefix
    {

        public static string getCommonPrefix(string[] strs) {

            if (strs.Length < 1) {

                return "";
            }
       
                string  commonPrefix = strs[0];
                for (int i = 1; i < strs.Length; i++)
                {
                    commonPrefix = CommonPrefix(commonPrefix, strs[i]);
                if (commonPrefix == "")
                    break;
                }
                return commonPrefix;
            }

        public static  string   CommonPrefix(string commonPrefix, string str2)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < commonPrefix.Length; i++)
                {
                    if (i >= str2.Length|| commonPrefix[i] != str2[i]){
                    break;
                }
                
else
                {

                    sb.Append(commonPrefix[i]);

                }


            }
return sb.ToString();
    }
    }

}

    

