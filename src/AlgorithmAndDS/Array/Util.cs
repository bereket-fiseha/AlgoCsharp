using AlgorithmAndDS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Array
{
    public class Util : IBasicUtil
    {

        public void swap(int[] arr, int firstIndex, int lastIndex)
        {
            if (!(arr == null || arr.Length == 0))
            {

                if (firstIndex != lastIndex && arr[firstIndex] != arr[lastIndex])
                {
                    var temp = arr[firstIndex];
                    arr[firstIndex] = arr[lastIndex];
                    arr[lastIndex] = temp;
                }
            }
        }

        public void swapUptoIndex(int[] arr, int currentIndex, int desiredIndex)
        {
            if (arr != null && arr.Length > 0)
            {
                if (currentIndex > arr.Length || desiredIndex > arr.Length)
                    throw new IndexOutOfRangeException();

                if (desiredIndex < currentIndex)
                {
                    while (desiredIndex != currentIndex)
                    {
                        swap(arr, currentIndex, currentIndex - 1);
                        currentIndex--;

                    }

                }


                else if (desiredIndex > currentIndex)
                {

                    while (desiredIndex != currentIndex)
                    {
                        swap(arr, currentIndex, currentIndex + 1);
                        currentIndex++;

                    }

                }
            }
        }
    }
}