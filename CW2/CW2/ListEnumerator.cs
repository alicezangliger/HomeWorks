using System;
using System.Collections;
using System.Collections.Generic;

namespace CW2
{
    public class ListEnumerator<T> : IEnumerator<T>
    {
        private MyList<T> list;
        private Node<T> currentNode;


        public ListEnumerator(MyList<T> list)
        {
            this.list = list;
            currentNode = null;
        }

        public bool MoveNext()
        {
            if (currentNode == null)
            {
                currentNode = list.Head;
            }
            else
            {
                currentNode = currentNode.Next;
            }

            return currentNode != null;

        }

        public void Reset()
        {
            currentNode = list.Head;
        }

        public void Dispose()
        {
            
        }

        public object Current
        {
            get
            {
                return currentNode.Data;
            }
        }

        T IEnumerator<T>.Current => currentNode.Data;
    }

        
}
