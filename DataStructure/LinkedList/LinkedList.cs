using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class Node 
    {
        public object data { get; set; }
        public Node next { get; set; }
    }
    public class LinkedList
    {
        private Node head;
        private Node current;
        private int count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void addAtLast(object n)
        {
            Node node = new Node() { data=n };
            current.next = node;
            current = node;
            count++;
        }

        public void addAtStart(object n)
        {
            Node node = new Node() { data=n };
            node.next = head.next;
            head.next = node;
            count++;
        }

        public void removeFromStart()
        {
            if(count>0)
            {
                head.next = head.next.next;
                count--;
            }
            else
            {
                Console.WriteLine("No node to delete.");
            }
        }
        public void PrintAllNodes()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
                Console.Write(curr.data);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
    }
}
