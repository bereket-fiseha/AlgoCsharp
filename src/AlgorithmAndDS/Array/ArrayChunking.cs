using AlgorithmAndDS.DS;
using System;

using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Array
{
    public class ArrayChunking
    {

        private int[] _array;
        private int _chunkSize;
        public ArrayChunking(int[] arr,int chunkSize) {
            _array = arr;
            _chunkSize = chunkSize;
        }


        public int[][] chunkArray() {
            var j = 0;
            int[] smallerArr = new int[_chunkSize>_array.Length?_array.Length:_chunkSize];
            int[][] bigerArr = new int[(int)(Math.Ceiling(((decimal)_array.Length /(decimal) _chunkSize)))][];
            for (int i = 0; i < _array.Length; i++)
            {
                smallerArr[i % _chunkSize] = _array[i];

                if ((i + 1) % _chunkSize == 0)
                {
                    bigerArr[j] = smallerArr;
                    j++;
                    var remainingNums = _array.Length - j * _chunkSize;
                    smallerArr = new int[remainingNums>_chunkSize?_chunkSize:remainingNums];

                }
                else
                {    if (i == _array.Length - 1) {
                        bigerArr[j] = smallerArr;
                    }




                }
            }





            return bigerArr;
        }


    }
}
