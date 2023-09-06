using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String
{
    public class Capitalization
    {

        public string CapitalizeEachWord(string strn) {
            if (string.IsNullOrEmpty(strn)||string.IsNullOrWhiteSpace(strn))
                    return strn;

            strn = strn.Trim();
         var st=   strn.ToUpper();
            if (strn.ToCharArray().Where(x => char.IsDigit(x)).Any()){

                throw new ArgumentException();
            }

            var strArray=strn.Split(" ");
            int i = 0;
            foreach(var str in strArray) {
                var strCharArray = str.ToCharArray();
                var leadingChar = strCharArray[0];

            var capitalizedChar = leadingChar.ToString().ToUpper().ToCharArray()[0];
                strCharArray[0] = capitalizedChar;

                strArray[i] =string.Join("", strCharArray);

                i++;



            }



            return string.Join(" ",strArray);
        }

    }
}
