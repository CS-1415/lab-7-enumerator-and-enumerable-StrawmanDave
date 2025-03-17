namespace Lab07.Tests;
using System.Diagnostics;
public class LinkedListStartingWithOneAtFrontTests()
{
    DoublyLinkedList<int> Numbers;
    [SetUp]
    public void Setup()
    {
        Numbers = new DoublyLinkedList<int>();
        Numbers.AddFirst(1);
    }
    public void Test1()
    {
        Numbers.AddLast(2);
        Debug.Assert(Numbers.Length == 2); // we added an element to the initalized list
        Numbers.printList(); // should print 1 2
        Console.WriteLine();
    }

    public void Test2()
    {
        Numbers.AddFirst(2);
        Debug.Assert(Numbers.Length == 2); // we added an element to the initalized list
        Numbers.printList();// should print 2 1
        Console.WriteLine();
    }

    public void Test3()
    {
        Numbers.RemoveLast();
        Debug.Assert(Numbers.Length == 0); // should be 0 if called once by itself
        Numbers.printList(); // should print 0 we removed the one item that exists
        Console.WriteLine();
    }

    public void test4()
    {
        Numbers.RemoveFirst();
        Debug.Assert(Numbers.Length == 0); // should be 0 if called once because we took the one element away
        Numbers.printList();// should print 0 we removed the one item that exists.
        Console.WriteLine();
    }
}