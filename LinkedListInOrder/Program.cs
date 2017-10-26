using System;

namespace LinkedListInOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Adding In Order");
            SinglyLinkedList<int> myLinkedList = new SinglyLinkedList<int>();
            myLinkedList.addOrder(5);
            myLinkedList.addOrder(1);
            myLinkedList.addOrder(5);
            myLinkedList.addOrder(15);
            myLinkedList.addOrder(17);
            myLinkedList.addOrder(51);
            myLinkedList.addOrder(0);
            myLinkedList.addOrder(1);
            myLinkedList.addOrder(200);
            myLinkedList.print();
            myLinkedList.remove(1);
            myLinkedList.print();
            myLinkedList.remove(5);
            myLinkedList.print();
            myLinkedList.remove(0);
            myLinkedList.print();
            myLinkedList.remove(17);
            myLinkedList.print();
            System.Console.WriteLine("Count " + myLinkedList.Count);
            myLinkedList.remove(15);
            myLinkedList.print();
            myLinkedList.remove(5);
            myLinkedList.print();
            myLinkedList.remove(200);
            myLinkedList.print();
            System.Console.WriteLine("Count " + myLinkedList.Count);

            myLinkedList.remove(1);
            myLinkedList.print();
            myLinkedList.remove(51);
            myLinkedList.print();

            System.Console.WriteLine("Count " + myLinkedList.Count);




        }
    }
}
