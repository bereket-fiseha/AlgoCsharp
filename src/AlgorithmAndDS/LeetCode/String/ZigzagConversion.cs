using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.String
{
    public class ZigzagConversion
    {
        #region inst

        //        The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

        //P   A   H   N
        //A P L S I I G
        //Y   I   R
        //And then read line by line: "PAHNAPLSIIGYIR"

        //Write the code that will take a string and make this conversion given a number of rows:

        //string convert(string s, int numRows);


        //        Example 1:

        //Input: s = "PAYPALISHIRING", numRows = 3
        //Output: "PAHNAPLSIIGYIR"
        //Example 2:

        //Input: s = "PAYPALISHIRING", numRows = 4
        //Output: "PINALSIGYAHRPI"
        //Explanation:
        //P I    N
        //A   L S  I G
        //Y A   H R
        //P I
        //Example 3:

        //Input: s = "A", numRows = 1
        //Output: "A"

        #endregion


        public static string Convert(string s, int numRows)
        {

            if (numRows <= 1)
                return s;

            int j = 0;
            int i = 0;
            //  var zigMatrix = new char[numRows][];
            var zigMatrix = new char[numRows, s.Length];
            for (int k = 0; k < s.Length; k++)
            {
                //fill col
                if (j % (numRows - 1) == 0)
                {


                    if (i == numRows - 1)
                    {

                        zigMatrix[i--, j++] = s[k];
                        continue;
                    }
                    zigMatrix[i++, j] = s[k];
                }


                //fill diagonal
                else
                {
                    zigMatrix[i--, j++] = s[k];


                }



            }

            StringBuilder sb = new StringBuilder();
            int maxCol = j;
            Regex reg = new Regex("^[a-zA-Z]+$");
           
            i = 0;

            while (i < numRows)
            {
                j = 0;
                while (j <= maxCol)
                {
                    if (zigMatrix[i,j]!=default(char))
                    {
                        sb.Append(zigMatrix[i, j]);
                    }
                    j++;
                }
                i++;


            }
            return sb.ToString();

        }

    }
}