using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_HW03b
{
    class Program
    {
        static void Main()
        {
            DoublyLinkedList myList = new DoublyLinkedList();

            //Adding modified AddFirst and AddLast methods in doubly linked list
            //myList.AddFirst("5");
            //myList.AddFirst("4");
            //myList.AddFirst("3");
            //myList.AddFirst("2");
            //myList.AddFirst("1");
            //myList.AddLast("hi");
            //myList.AddLast("eat");
            //myList.AddLast("today");

            //// display original list
            //Console.WriteLine("Before reversing:");
            //myList.PrintList();
            //Console.WriteLine();

            //// display reversed list using PrintReverse method
            //Console.WriteLine();
            //Console.WriteLine("After reversing:");
            //myList.PrintReverse();
            //Console.WriteLine();

            // Palindrome method to check if list is same forward and backward
            myList.AddLast("bob");
            myList.AddFirst("cob");
            myList.AddFirst("is");
            myList.AddFirst("bob");
            myList.AddLast("bob");
            myList.AddLast("cob");
            myList.AddLast("is");
            myList.AddLast("bob");
            myList.PrintList();
            Console.WriteLine();
            Console.WriteLine("The doubly list is a palindrome: {0}", myList.IsPalindrome());



        }
    }

    class Node
    {
        // the Node prev is created since nodes in doubly linked list
        // have 2 points.
        public string value;
        public Node next;
        public Node prev;


        //ctor
        public Node(string words)
        {
            this.value = words;
            this.next = null;
            this.prev = null;
            
        }

    }

    class DoublyLinkedList
    {
        // Since this is a doubly linked list, last is added to represent the "tail."
        public Node first;
        public Node last;

        //methods
        public bool IsEmpty()
        {
            return first == null;
        }

        // since doubly linked list can traverse forward,
        // the same method from singly linked list can be
        // used to return same results.
        public bool IsPalindrome() // Best case: O(n) 
        {                          // worst case: O(n^2)
            // flag is raised to check for palindrome
            bool flag = true;
            Node current = first;

            if (IsEmpty())
                throw new Exception("There is nothing to delete, the list is empty!");


            if (current == null || current.next == null)
            {
                return flag;
            }

            // using two variables to find the midpoint where both will "start"
            // at the same node
            Node current1 = first;
            Node current2 = first;

            // current2 will be "moving" two points ahead of current1 until it reaches the end, i.e. null
            while (current2.next != null && current2.next.next != null)
            {
                current2 = current2.next.next;
                current1 = current1.next;
            }

            // newfirst node will be used to reverse the second half of the list because of odd/even cases.
            Node newfirst = current1.next;

            while (newfirst.next != null)
            {
                Node tempNext = newfirst.next;
                newfirst.next = newfirst.next.next;
                tempNext.next = current1.next;
                current1.next = tempNext;
            }

            newfirst = current1.next;
            while (newfirst != null)
            {
                // the program will change the flag to return false when the values reversed do
                // not return the same results.
                if (current.value != newfirst.value)
                {
                    flag = false;
                }
                current = current.next;
                newfirst = newfirst.next;
            }

            return flag;
        }

        public void PrintReverse() // Best case is O(n), worst case is O(n^2)
        {
            Console.WriteLine();

            if (IsEmpty())
            {
                Console.WriteLine("the list is empty!!!");
            }

            else if (last != null)
            {
                // prints the list in reverse by setting the current node
                // to equal last. As long as it does not return null, the
                // program will print from last node to the node before
                // it and iterate until it reaches the first node.
                Node current = last;
                while (current != null)
                {

                    Console.Write(current.value + " ");
                    current = current.prev;
                }

            }

        }

        public void AddLast(string words) // Run time is O(n)
        {
            if (IsEmpty())
            {
                AddFirst(words);
            }

            else
            {
                Node current = last;
                last = new Node(words);
                current.next = last;
                last.prev = current;
            }
        }       

        public void AddFirst(string words) // Time complexity O(n)
        {
            // since doubly linked nodes have two end points, we need
            // to assign the first and last node to equal each other in
            // case there is no list.
            if (first == null)
            {
                first = last = new Node(words);
            }

            // AddFirst will 
            else
            {
                Node current = first;
                first = new Node(words);
                current.prev = first;
                first.next = current;
            }

        }

        public void PrintList()
        {
            Console.WriteLine();

            if (IsEmpty())
                Console.WriteLine("the list is empty!!!");

            else
            {
                Node current = first;
                while (current != null)
                {
                    Console.Write(current.value + " ");
                    current = current.next;
                }
            }
        }
        //ctor
        public DoublyLinkedList()
        {
            // the constructor for doubly linked list will now have
            // two points that will initially return null.
            first = last = null;
        }
    }

}