using AlgorithmAndDS.Interface.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.DS
{  public  class Node<T> {
        private T val;
        private Node<T> next;
        public Node<T> Next { get { return next; } set { next = value; } }
    
     public   Node(T _val) {
            val = _val;
        
        }
    }


   public   class LinkedList<T> : ILinkedList<T>
    {
        private Node<T> head;

        public LinkedList(Node<T> _head) {
        head = _head;
        }
       

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool HasItem(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
        {
            if (head == null)
                this.head = new Node<T>(item);
          //  else


        }

        public void InsertEnd(T item)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public T Remove(int index)
        {
            throw new NotImplementedException();
        }
    }
}
