using System;
namespace CustomLinkedList
{
    public class Node<T>
    {
        //data
        public T Data { get; set; }

        //link
        public Node<T> Next { get; internal set; }
        public Node<T> Prev { get; internal set; }


        //constructor
        public Node(T data)
        {
            this.Data = data;
        }

    }
}

