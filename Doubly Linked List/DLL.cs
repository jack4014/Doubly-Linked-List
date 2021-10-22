using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class DLL
    {

        private DLLNode head; //Establish the head of the list
        public DLLNode Head
        {
            get { return head; }
        }

        public class DLLNode
        {
            public int data;
            public DLLNode prev;
            public DLLNode next;

            public DLLNode(int d)
            {
                data = d;
            }
        }
    
        public void printMiddle() //Method for printing the middle element
        {
            DLLNode slow_ptr = head;
            DLLNode fast_ptr = head;

            if (head != null)
            {
                while (fast_ptr != null &&
                       fast_ptr.next != null)
                {
                    fast_ptr = fast_ptr.next.next;
                    slow_ptr = slow_ptr.next;
                }
                Console.WriteLine("\nThe middle element is [" +
                                  slow_ptr.data + "] ");

            }
        }
        public void push(int new_data) //Method to add a node at the front of the list
        {
            DLLNode new_node = new DLLNode(new_data);
            new_node.next = head;
            new_node.prev = null;


            if (head != null)
                head.prev = new_node;

            head = new_node;
        }

        public void insertAfter(DLLNode prev_node, int new_data) //Function to insert a new node after the previous node
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be NULL ");
                return;
            }

            DLLNode new_node = new DLLNode(new_data);

            new_node.next = prev_node.next;

            prev_node.next = new_node;

            new_node.next.prev = prev_node;

            if (new_node.next != null)
                new_node.next.prev = new_node;
        }

        public void append(int new_data) //Method to add a node to the end of the list
        {

            DLLNode new_node = new DLLNode(new_data); 

            DLLNode last = head;

            new_node.next = null;

            if (head == null)
            {
                new_node.prev = null;
                head = new_node;
                return;
            }

            while (last.next != null)
                last = last.next;

            last.next = new_node;

            new_node.prev = last;

        }
        public void printList(DLLNode node) //Methood to print the doubly lined list
        {
            DLLNode last = null;
            Console.WriteLine("Traversal in forward Direction");
            while (node != null)
            {
                Console.Write(node.data + " ");
                last = node;
                node = node.next;
            }
            Console.WriteLine();
            Console.WriteLine("Traversal in reverse direction");
            while (last != null)
            {
                Console.Write(last.data + " ");
                last = last.prev;
            }
        }
        public static Boolean isPrime(int num) //Method for calculating a prime
        {
            Boolean record = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if ((num % i) == 0)
                {
                    record = false;
                    break;
                }
            }
            if (num == 0 || num == 1)
            {
                record = false;
            }
            return (record);
        }
        public void printPrime() //Method for printing primes
        {
            DLLNode node = head;
            Console.WriteLine("Primes in forward direction");
            while (node != null)
            {
                if (isPrime(node.data))
                {
                    Console.Write(node.data + " ");
                }
                node = node.next;
            }
            Console.WriteLine();
        }

    }
}
