using AlgorithmAndDS.LeetCode.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.LeetCode.String
{
    public class TestJustificaitonTests
    {



        [Theory]
        [InlineData(new string[] { "This", "is", "an", "example", "of", "text", "justification."},16,new string[]{

         "This    is    an",
           "example  of text",
           "justification.  "
        })]
        




        public void Justify_WhenCalled_JustifiesWholeStirng(string[] listOfstrWords, int maxWidth,string[] expected)
        {

            //arrange and Act
            var actual = TextJustification.FullJustify(listOfstrWords,maxWidth);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
