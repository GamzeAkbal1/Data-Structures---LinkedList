using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LinkedListInOrder
{
    public class SinglyLinkedList<T> where T : IComparable
    {
        Node<T> head;
        int count;
        public Node<T> getHead()
        {
            return head;
        }
        public int Count
        {
            get
            {
                Node<T> iterator = new Node<T>();
                iterator = head;
                this.count = 0;
                while (iterator != null)
                {
                    this.count++;
                    iterator = iterator.next;


                }
                return this.count;
            }
            set
            {
                this.count = value;
            }

        }
        public void print()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write("{0} ", current.value);
                current = current.next;
            }
            Console.WriteLine();
        }
        public void addHead(T value)
        {
            Node<T> newNode = new Node<T>(value, head);
            head = newNode;
        }
        public void addTail(T value)
        {
            Node<T> current = head;
            Node<T> newNode = new Node<T>(value, null);
            if (head == null)
            {
                head = newNode;
                return;
            }
            while (current.next != null)
                current = current.next;
            current.next = newNode;
        }



        public T removeHead()
        {
            Node<T> toDelete = head;
            toDelete.next = null;
            head = head.next;
            return toDelete.value;
        }
        public void addOrder(T val)
        {
            Node<T> newNode = new Node<T>(val, null);

            if (head == null)
            {
                head = newNode;
            }
            else if (head.next == null)
            {
                if (head.value.CompareTo(val) == 1 || head.value.CompareTo(val) == 0)
                    addHead(val);
                else
                    addTail(val);
            }
            else
            {
                Node<T> iterator = head;
                while (iterator != null)
                {
                    if (iterator.next != null)
                    {
                        if (iterator.value.CompareTo(val) == -1 && iterator.next.value.CompareTo(val) == 1 || iterator.value.CompareTo(val) == 0)
                        {

                            newNode.next = iterator.next;
                            iterator.next = newNode;
                            break;
                        }
                    }
                    else
                    {
                        if (iterator.value.CompareTo(val) == -1 || iterator.value.CompareTo(val) == 0)
                        {
                            addTail(val);
                            break;
                        }
                        else if (iterator.value.CompareTo(val) == 1 || iterator.value.CompareTo(val) == 0)
                        {
                            addHead(val);
                            break;
                        }
                    }
                    iterator = iterator.next;
                }
            }
        }
        public void clearList()
        {
            head = null;
        }

        public void remove(T value)
        {
            Node<T> iterator = new Node<T>();
            iterator = head;
            if (value.CompareTo(head.value) == 0)
                head = head.next;
            else
            {
                while (iterator.next != null)
                {
                    if (iterator.next.value.CompareTo(value) == 0)
                    {
                        if (iterator.next.next == null)
                        {
                            iterator.next = null;
                        }
                        else
                        {
                            iterator.next = iterator.next.next;
                        }
                    }
                    if (iterator.next != null)
                        iterator = iterator.next;
                }
            }
        }
    }
}

