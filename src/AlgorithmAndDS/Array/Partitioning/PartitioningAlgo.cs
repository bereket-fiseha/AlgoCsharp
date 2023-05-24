using AlgorithmAndDS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Array.Partioning
{
   public  class PartitioningAlgo
    {
private readonly IBasicUtil _util;

public PartitioningAlgo(){

    _util=new Util();
}


public int[] moveAllZerosToFront(int[] arr){

            if (arr == null || arr.Length == 0)
                return arr;
            //partition index
            int pIndex = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == 0)
                {
                    _util.swapUptoIndex(arr, i, pIndex);
                    pIndex++;
                }
      
            
            }
            return arr;
}



        public int[] moveAllZerosToEnd(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return arr;


            int pIndex = arr.Length - 1;
            for (int i = 0;  i<pIndex; i++) {
                if (arr[i] == 0) {
                    _util.swapUptoIndex(arr,i,pIndex);
                    pIndex--;
                
                }
            
            
            }
            return arr;
        }

        public int[] moveElementToProperSegment(int[] arr,int pivot)
        {
            if (arr == null || arr.Length == 0)
                return arr;

            int lowwerIndex = 0;
            int higherIndex = arr.Length-1;
            int t = 0;

            while (t <= higherIndex) {
                if (arr[t] < pivot)
                {
                    _util.swap(arr, t, lowwerIndex);
                    lowwerIndex++;
                    t++;

                }
                else if (arr[t] > pivot) {
                    _util.swap(arr, t, higherIndex);
                    higherIndex--;
                    
                
                }

                else
                    t++;

            }


            return arr;
        
        }

    }
}