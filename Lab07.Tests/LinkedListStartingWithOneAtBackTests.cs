namespace Lab07.Tests;

using System.Diagnostics;
public class LinkedListStartingWithOneAtBackTests()
{
    //initated list with one at back
    DoublyLinkedList<int> Numbers;
    [SetUp]
    public void Setup()
    {
        Numbers = new DoublyLinkedList<int>();
        Numbers.AddLast(1);
    }
    public void Test1()
    {
        Numbers.AddLast(2);
        Debug.Assert(Numbers.Length == 2); // we now added a second element
        Numbers.printList(); // should print 1 2
        Console.WriteLine();
    }

    public void Test2()
    {
        Numbers.AddFirst(2);
        Debug.Assert(Numbers.Length == 2); // we now added a second element
        Numbers.printList();// should print 2 1
        Console.WriteLine();
    }

    public void Test3()
    {
        Numbers.RemoveLast();
        Debug.Assert(Numbers.Length == 0); // we now removed the one item in the list
        Numbers.printList(); // should print 0
        Console.WriteLine();
    }

    public void Test4()
    {
        Numbers.RemoveFirst();
        Debug.Assert(Numbers.Length == 0); // we now removed the one item in the list from it being intialized.
        Numbers.printList();// should print 0
        Console.WriteLine();
    }
}