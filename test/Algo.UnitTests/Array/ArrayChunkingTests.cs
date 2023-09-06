using AlgorithmAndDS.Array;
using AlgorithmAndDS.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.Array
{
    public class ArrayChunkingTests

    {



        //[Theory]
        //[InlineData(new int[] { }, 2, new int[] { })]
        //[InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, new int[3][3] { new int[3] {3,3,7 }, new int[3] {6,7,9 } })]
        //[InlineData("bcdefgi", 'b')]

        //[InlineData("bcdeefgi", 'e')]

        //[InlineData("bbcdeefgiii", 'i')]

        //[InlineData("bbcdecefgciiic", 'c')]
        //[InlineData("bbcedecefgciieic", 'e')]
        //[InlineData("bbbcccc", 'c')]

        //[InlineData("234562", '2')]



        public void ArrayChunking_WhenCalled_ReturnTheChunkedArray(int[] givenArray, int chunkSize, int[][] expected)
        {
            int[] arr1 = new int[2] { 3, 5 };

            int[][] arr2 = new int[][] { arr1 };

            //arrange
            var algo = new ArrayChunking(givenArray,chunkSize);
            //act
            var actual = algo.chunkArray();
            //assert
            Assert.Equal(expected, actual);

        }


    }

}
