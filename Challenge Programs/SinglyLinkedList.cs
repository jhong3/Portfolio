using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_HW03a
{
    class Program
    {
        static void Main()
        {
            SinglyLinkedList myList = new SinglyLinkedList();

            // Shows the original methods that were modified to work with strings
            //myList.AddFirst("hi");
            //myList.AddFirst("hi");
            //myList.AddFirst("hi");
            //myList.AddLast("my");
            //myList.AddLast("my");
            //myList.AddLast("bob");
            //myList.Insert("extra");
            //myList.delete("extra");
            //myList.RemoveDuplicates(); // duplicate removal method
            //myList.PrintList();

            // Checks for palindrome
            myList.AddFirst("X");
            myList.AddFirst("food");
            myList.AddFirst("ate");
            myList.AddFirst("Cat");
            myList.AddLast("food");
            myList.AddLast("ate");
            myList.AddLast("Cat");
            myList.PrintList();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The singly linked list is a palindrome: {0}", myList.IsPalindrome());                    
        }
    }

    class Node
    {
        //string values
        public string value { get; set; }
        public Node next;
        
        //ctor
        public Node(string words)
        {
            this.value = words;
            this.next = null;
        }        

    }

    class SinglyLinkedList
    {
        //data
        public Node first;

        //methods
        public bool IsEmpty()
        {
            return first == null;
        }
        

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
                
        public void RemoveDuplicates() // The time complexity is O(n^2)
        {
            Node current = first;
            Node nextPointer;

            if (IsEmpty())
                throw new Exception("There is nothing to delete, the list is empty!");

            while (current.next != null)
            {
                if (current.value == current.next.value) // compares current string value with the next string value
                {
                    nextPointer = current.next.next;
                    current.next = null;
                    current.next = nextPointer;
                }
                else
                {
                    current = current.next; // continues traversing through the nodes if nothing is deleted
                }
            }

        }

        public void delete(string words)
        {
            if (IsEmpty())
                throw new Exception("you can't delete from an empty list");
            else if (words == first.value)
                RemoveFirst();
            else
            {
                Node curr = first;

                while (curr.next != null && curr.next.value != words)
                    curr = curr.next;
                if (curr.next == null) //we didn't find the value val in the list
                    throw new Exception("we didn't find  the element in the list");
                else
                    curr.next = curr.next.next;
            }

        }

        public void Insert(string words)//it assumes the list is sorted!!!!
        {
            // CompareTo method is used to compare the values of strings.
            if (IsEmpty() || words.CompareTo(first.value) <= 0)
                AddFirst(words);
            else
            {
                Node newNode = new Node(words); //create a new node
                Node curr = first;

                // curr.next.value and words are string values, requiring CompareTo
                // method and checking to see if the result returns less than 0.
                while (curr.next != null && curr.next.value.CompareTo(words) < 0)
                {
                    curr = curr.next;
                }
                newNode.next = curr.next;
                curr.next = newNode;
            }

        }

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("you can't remove first from an emtpy list");
            else
                first = first.next;

        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("you can't remove last from an emtpy list");
            else if (first.next == null)//we have only one element in the list
            {
                first = null; //empty the list
            }
            else
            {
                Node current = first;
                while (current.next.next != null)
                    current = current.next;
                current.next = null;//remove the last node by making the next to last node point to null 
            }
        }

        public void AddLast(string words) // Run time is O(n^2)
        {
            if (IsEmpty())
                AddFirst(words);
            else
            {
                Node newNode = new Node(words);

                Node current = first;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
            }
        }       


        public void AddFirst(string words) // Run time is O(1)
        {
            Node newNode = new Node(words);
            newNode.next = first;
            first = newNode;
        }

        public void PrintList() // Run time in best case is O(n), worst case is O(n^2)
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
        public SinglyLinkedList()
        {
            first = null;
        }
    }

}
