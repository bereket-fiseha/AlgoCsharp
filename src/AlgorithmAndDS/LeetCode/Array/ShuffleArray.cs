using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LeetCode.Array
{
    public class ShuffleArray
    {

        public static int[] Shuffle(int[] arr, int n)
        {
            if (arr.Length == 0)
            {
                return arr;
            }

            int currX = arr[0];
            for (int i = 0; i < arr.Length / 2; i++)
            {
                var xi = currX;
                var yi = arr[n + i];
                currX = arr[i + 1];
                arr[2 * i] = xi;
                arr[2 * i + 1] = yi;

            }
            return arr;
        }
    }
}
