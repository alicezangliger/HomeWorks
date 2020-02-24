using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CW2
{
    public class MyList<T> 
    {
       // private Node<int> _head;
        public Node<T> Head { get; private set; }

        public void AddHead(T a)
        {
            Node<T> tempNode = new Node<T>();
            tempNode.Data = a;

            if (Head == null)
            {
                Head = tempNode;
            }
            else
            {
                tempNode.Next = Head;
                Head = tempNode;
            }            
         
        }

        public void AddTail(T b)
        {
            Node<T> tempNode = new Node<T>();
            tempNode.Data = b;
            Node<T> currentTail = Head;
                       
            while (currentTail.Next != null)
            {
                currentTail = currentTail.Next;
            }
            currentTail.Next = tempNode;
           
            
            
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            Node<T> currentTail = Head;

            while (currentTail.Next != null)
            {
                builder.Append(currentTail.Data.ToString());
                builder.Append(" ");
                currentTail = currentTail.Next;
            }
            builder.Append(currentTail.Data.ToString());
            return builder.ToString();

        }

        public IEnumerator<T> GetEnumerator()
        {
            return  new ListEnumerator<T>(this);
        }
      
    }
}
