using System;

namespace DoublyLinkedList
{
    public class DNode
    {
        public int data;
        public DNode prev;
        public DNode next;

        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }

    public class DoubleLinkedList
    {
        public DNode head;
    }
    public class HelperDLL
    {
        public void InsertLast(DoubleLinkedList doubleLinkedList, int data)
        {
            DNode newNode = new DNode(data);
            if (doubleLinkedList.head == null)
            {
                newNode.prev = null;
                doubleLinkedList.head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(doubleLinkedList);

            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        public DNode GetLastNode(DoubleLinkedList doubleLinkedList)
        {
            DNode temp = doubleLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void DeleteNodebyKey(DoubleLinkedList doubleLinkedList,int key)
        {
            DNode temp = doubleLinkedList.head;
            if(temp != null && temp.data == key)
            {
                doubleLinkedList.head = temp.next;
                doubleLinkedList.head.prev = null;
                return;
            }
            while(temp != null && temp.data != key)
            {
                temp = temp.next;

            }
            if(temp == null)
            {
                return;
            }
            if(temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if(temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }

        public void ReversalLinkedList(DoubleLinkedList doubleLinkedList)
        {
            DNode temp = null;
            DNode current = doubleLinkedList.head;

            while(current != null)
            {
                temp = current.prev;
                current.prev = current.next;
                current.next = temp;
                current = current.prev;
            }
            if(temp != null)
            {
                doubleLinkedList.head = temp.prev;
            }
        }
        public void PrintList(DoubleLinkedList doubleLinkedList)
        {
            DNode n = doubleLinkedList.head;
            while(n!= null)
            {
                Console.Write(n.data + " ");
                
                n = n.next;
            }
        }
    }


}
