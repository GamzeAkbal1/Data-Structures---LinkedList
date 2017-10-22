using System;
namespace LinkedListInOrder
{
    public class Node<T> where T : IComparable
    {
        public T value;
        public Node<T> next;
        public Node()
        {

        }
        public Node(T value, Node<T> next)
        {

            this.value = value;
            this.next = next;
        }


    }

}