using System;

namespace CustomLinkedList
{
    public class LinkedList<T>
    {
        //properties

        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }
        public int Count { get; private set; }

        //constructor

        public LinkedList()
        {
            this.First = null;
            this.Last = null;
        }

        public void AddFirst(Node<T> newNode)
        {
            if (this.First==null)
            {
                //this means the linkedlist is empty
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                newNode.Next = this.First;
                this.First = newNode;
            }
            Count++;
        }

        public void AddLast(Node<T> newNode)
        {
            if (this.First == null)
            {
                //this means the linkedlist is empty
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                Last = newNode;
            }
            Count++;

        }

        public void RemoveFirst()
        {
            if (First==null || this.Count==0)
            {
                return;
            }

            First = First.Next;
            this.Count--;
        }
    }
}

