using System;

namespace ImplementationLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomedLinkList newList = new CustomedLinkList(new int[] {1, 6, 7, 8});
            newList.Foreach(Console.WriteLine);
            Console.WriteLine("Added 100 at first Index");
            newList.AddFirst(100);
            newList.Foreach(Console.WriteLine);
            Console.WriteLine("Added 77 at last Index");
            newList.AddLast(77);
            newList.Foreach(Console.WriteLine);
            Console.Write("Removed Element is :");
            Console.WriteLine(newList.RemoveFirst());
            newList.Foreach(Console.WriteLine);
            Console.Write("Removed Element is :");
            Console.WriteLine(newList.RemoveLast());

            Console.WriteLine("---------------------------------------");
            newList.Foreach(Console.WriteLine);

        }
    }
}
