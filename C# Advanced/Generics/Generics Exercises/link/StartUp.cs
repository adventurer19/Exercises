using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // CustomedLinkList<int> newList = new CustomedLinkList(new int[] {1, 6, 7, 8});
            CustomDoublyLinkedList<int> newList = new CustomDoublyLinkedList<int>(new int[] {1, 6, 7, 8});
            newList.ForEach(Console.WriteLine);
            Console.WriteLine("Added 100 at first Index");
            newList.AddFirst(100);
            newList.ForEach(Console.WriteLine);
            Console.WriteLine("Added 77 at last Index");
            newList.AddLast(77);
            newList.ForEach(Console.WriteLine);
            Console.Write("Removed Element is :");
            Console.WriteLine(newList.RemoveFirst());
            newList.ForEach(Console.WriteLine);
            Console.Write("Removed Element is :");
            Console.WriteLine(newList.RemoveLast());

            Console.WriteLine("---------------------------------------");
            newList.ForEach(Console.WriteLine);
        }
    }
}
