using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Array
{

    #region instruct
//    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

//Symbol Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000
//For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

//Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII. Instead, the number four is written as IV.Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:

//I can be placed before V (5) and X(10) to make 4 and 9. 
//X can be placed before L(50) and C(100) to make 40 and 90. 
//C can be placed before D(500) and M(1000) to make 400 and 900.
//Given an integer, convert it to a roman numeral.



//Example 1:

//Input: num = 3
//Output: "III"
//Explanation: 3 is represented as 3 ones.
//Example 2:

//Input: num = 58
//Output: "LVIII"
//Explanation: L = 50, V = 5, III = 3.
//Example 3:

//Input: num = 1994
//Output: "MCMXCIV"
//Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

    #endregion
    public  class IntegerToRoman
    {


        public static string Convert(int num) {

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict[1] = "I";
            dict[4] = "IV";
            dict[5] = "V";
            dict[9] = "IX";
            dict[10] = "X";
            dict[40] = "XL";

            dict[50] = "L";
            dict[90] = "XC";
            dict[100] = "C";
            dict[400] = "CD";
            dict[500] = "D";
            dict[900] = "CM";
            dict[1000] = "M";

            int[] valArr = new int[] { 1,4, 5, 9,10, 50,40,90, 100, 400,500, 900,1000 };
            int i = valArr.Length - 1; 
     

                StringBuilder sb = new();
            int modNum = num;
            if (num >= valArr[i]) {

                modNum = num % valArr[i];
            sb.Append(char.Parse(dict[valArr[i]]), (int)(num / valArr[i]));
            }


            //until the number is 0 , subtract and append the char/string  for the specific val
                while (modNum>0) {
                
                if (modNum >= valArr[i]) {
                    modNum = modNum - valArr[i];
                    sb.Append(dict[valArr[i]]);
                }
                else { i--; }
            
            
            }

            return sb.ToString();
        
        }



        public static string ConvertOpt(int num) {


            var map = new Dictionary<int, string>();
            map.Add(1000, "M");
            map.Add(900, "CM");
            map.Add(500, "D");
            map.Add(400, "CD");
            map.Add(100, "C");
            map.Add(90, "XC");
            map.Add(50, "L");
            map.Add(40, "XL");
            map.Add(10, "X");
            map.Add(9, "IX");
            map.Add(5, "V");
            map.Add(4, "IV");
            map.Add(1, "I");

            var sb = new StringBuilder();

            foreach (var pair in map)
            {
                int digit = num / pair.Key;

                while (digit-- > 0)
                {
                    sb.Append(map[pair.Key]);
                }

                num = num % pair.Key;
            }

            return sb.ToString();

        }
    }
}
