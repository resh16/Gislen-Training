using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLLCaller();
            Console.ReadLine();
        }
        static void DLLCaller()
        {
            HelperDLL objHelper = new HelperDLL();
            DoubleLinkedList myLinkedList = new DoubleLinkedList();

            objHelper.InsertLast(myLinkedList, 20);
            objHelper.InsertLast(myLinkedList, 50);
            objHelper.InsertLast(myLinkedList, 40);
            objHelper.InsertLast(myLinkedList, 25);
            objHelper.InsertLast(myLinkedList, 63);
            objHelper.PrintList(myLinkedList);
            Console.WriteLine(" ");
            objHelper.DeleteNodebyKey(myLinkedList, 25);
            objHelper.PrintList(myLinkedList);
            Console.WriteLine(" ");
            objHelper.ReversalLinkedList(myLinkedList);
            objHelper.PrintList(myLinkedList);
            Console.WriteLine(" ");


        }
    }
}
