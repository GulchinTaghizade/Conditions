using System;
using CustomLinkedList;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> ll = new LinkedList<string>();

            Node<string> a = new Node<string>("First");
            ll.AddFirst(a);
            Node<string> b = new Node<string>("Second");
            ll.AddFirst(b);
            Node<string> c = new Node<string>("Third");
            ll.AddFirst(c);

            ll.RemoveFirst();
            Console.WriteLine(ll);

        }
    }
}

