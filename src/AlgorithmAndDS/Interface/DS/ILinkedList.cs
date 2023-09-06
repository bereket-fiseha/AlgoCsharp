using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Interface.DS
{
    public interface ILinkedList<T>
    {
        void InsertEnd(T item);
        void Insert(T item);
        bool HasItem(T item);
        int Count();
        T Remove(int index);
        bool IsEmpty();
     

    }
}
