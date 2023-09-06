using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.StepsImp
{
    public class Steps
    {

        public Steps() { }

        public void StepsImp1(int steps)
        {

            for (int i = 1; i <= steps; i++)
            {
                var strBuilder = new StringBuilder();
                for (int j = 0; j < i; j++)
                {
                    strBuilder.Append("#");
                }
                var hashSteps = strBuilder.ToString();
                strBuilder.Clear();
                for (int j = 0; j < steps - i; j++)
                {
                    strBuilder.Append(" ");
                }
                var spaceSteps = strBuilder.ToString();

                Console.WriteLine($"'{hashSteps}{spaceSteps}'");
            }
        }

        //'  #  ' 3-1 space  1 stars
        //' ### ' 3-2 space 2*2-1 stars
        //'#####' 3-3 space 3*2-1 stars
        //        4*2-1
        public void StepsImp2(int steps)
        {
                    var  strBuilder=new StringBuilder();
            for (int i = 1; i <= steps; i++)
            {
                strBuilder.Clear();
                strBuilder.Append('\'');
                for (int j = 0; j < steps-i; j++) { 
                strBuilder.Append(' ');
                
                }

                for (int j = 0; j < i*2 - 1; j++)
                {
                    strBuilder.Append('#');

                }


                for (int j = 0; j < steps - i; j++)
                {
                    strBuilder.Append(' ');

                }


                strBuilder.Append('\'');

                Console.WriteLine(strBuilder.ToString());
                
            }
        }



    }
}