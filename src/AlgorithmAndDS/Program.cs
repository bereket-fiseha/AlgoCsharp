using AlgorithmAndDS.Array;
using AlgorithmAndDS.LeetCode.Array;
using AlgorithmAndDS.StepsImp;
using System;
using System.Linq;

namespace AlgorithmAndDS
{
    class Program
    {
        static void Main(string[] args)
        {
            var algo = new Steps();
          int val=  RomanToInt.Covert("LVIII");
            int val2 = RomanToInt.Covert("MCMXCIV");
            Console.WriteLine($"1st{val} 2ns{val2}");
        }
    }
}
