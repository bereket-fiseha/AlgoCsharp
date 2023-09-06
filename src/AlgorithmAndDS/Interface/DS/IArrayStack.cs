using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Interface.DS
{
    public interface IArrayStack<T> 
    {
        bool HasItem(T item);
        int Count();
      T Pop();
       void Push(T item);
        bool IsEmpty();
        int TotalCapacity();
    }
}
