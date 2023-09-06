using AlgorithmAndDS.StepsImp;
using AlgorithmAndDS.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algo.UnitTests.StepsTests
{
    public class StepsTests
    {

        public void Steps_WhenCalled_ReturnsCorrectSteps(int steps)
        {
            //arrange
            var algo = new Steps();
           algo.StepsImp1(steps);
            //assert
          //  Assert.C(expected, actual);

        }
    }
}
