using System;
using System.Collections.Generic;


namespace Generics
{
    class GenericList<T>
    {
        private class Node
        {
            public Node(T value)
            {
                _next = null;
                _data = value;
            }

            private Node _next;

            public Node Next
            {
                get { return _next; }
                set { _next = value; }
            }

            private T _data;

            public T Data
            {
                get { return _data; }
                set { _data = value; }
            }
        }

        private Node head;

        public GenericList()
        {
            head = null;
        }

        public void Add(T value)
        {
            Node n = new Node(value);
            n.Next = head;
            head = n;
            Console.WriteLine($"{value} was added to list");
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
