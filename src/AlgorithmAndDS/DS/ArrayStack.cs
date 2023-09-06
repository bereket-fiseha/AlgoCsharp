using AlgorithmAndDS.Interface.DS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.DS
{
    public class ArrayStack<T> : IArrayStack<T> 
    {
        T[] array;
        private int length;
        private int capacity;

       public  ArrayStack(int capacity){
            this.capacity = capacity;
            this.length = 0;
            this.array=new T[capacity];
}

        public void IncrementSize() {
             capacity *= 2;
            T[] newArray = new T[capacity];
            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
            
        }

        public int TotalCapacity()
        {

            return capacity;

        }
        public int Count()
        {
            return length; 
        }

        public bool HasItem(T item)
        {
           foreach(T ele in array) { 
            if(ele.Equals(item))
                     return true;
            }
           return false;
        }


        public T Pop()
        {
            if (length > 0)
                return array[--length];
            else { throw new Exception("The stack has no items in it!"); }
        }

        public void Push(T item)
        {
            
            if (length == capacity) { 
            IncrementSize();
            }

            array[length++] = item;
         }


        public bool IsEmpty()
        {
            return length == 0;
        }
    }
}
