using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Array
{
    public class FirstOccurenceInString
    {

        private static bool checkIfEqual(string haystack, string needle, int startIndex)
        {
            if (haystack.Length - startIndex < needle.Length)
                return false;
            int i = startIndex;

            for (int j = 0; j < needle.Length; j++)
            {

                if (haystack[i] != needle[j])
                    return false;
                i++;

            }
            return true;
        }



        private static bool checkIfEqual(string hstackSubstring, string  needle) =>
              hstackSubstring == needle;



            public static int getIndex(string haystack, string needle)
            {
                for (int i = 0; i < haystack.Length; i++)
                {

                    if (haystack[i] == needle[0])
                    {

                        bool occurenceExists = checkIfEqual(haystack, needle,i);
                        if (occurenceExists)
                            return i;
                    }

                }
                return -1;
            }
        }

    }

