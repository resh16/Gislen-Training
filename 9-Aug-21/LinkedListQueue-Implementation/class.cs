using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public class LinkedListQueue
    {
        Node front;
        Node rear;

        public LinkedListQueue()
        {
            this.front = this.rear = null;
        }

        public void Enqueue(int item)
        {
            Node newNode = new Node(item);

            if(this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("Inserted into Queue " + item);
        }

        public void Dequeue()
        {
            if(this.front == null)
            {
                Console.WriteLine("The Queue is Empty");
                return;
            }

            Node temp = this.front;
            this.front = this.front.next;

            if(this.front == null)
            {
                this.rear = null;
            }
            Console.WriteLine("Item deleted is " + temp.data);
        }

        public void PrintQueue()
        {
            if(this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node temp = this.front;

            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
