namespace Lab07.Tests;

using System.Diagnostics;

public class LinkedListStaringWithTwoTests()
{
    //initated list with one at back and one at the front
    DoublyLinkedList<int> Numbers;
    DoublyLinkedList<int> newNumbers = new DoublyLinkedList<int>();
    [SetUp]
    public void Setup()
    {
        Numbers= new DoublyLinkedList<int>();
        Numbers.AddLast(1);
        Numbers.AddFirst(2);
        newNumbers.AddLast(2);
        newNumbers.AddFirst(1);
        newNumbers.AddLast(3);
    }
    public void Test1()
    {
        Debug.Assert(Numbers.Length == 2); // Has correct length it was barrely created so it should be 2
        Numbers.RemoveFirst(); 
        Numbers.printList();// should print 1
        Console.WriteLine();
        Numbers.RemoveLast();
        Numbers.printList(); // should print 0
        Console.WriteLine();
        Debug.Assert(Numbers.Length == 0); //Should have 0 in it because we removed all the items

        Debug.Assert(newNumbers.Length == 3); // Has correct length it was barely created so it should be 2
        newNumbers.printList(); // should print 1 2 3
        Console.WriteLine();
        newNumbers.ReverseList(); 
        newNumbers.printList(); // should print out 3 2 1
        Console.WriteLine(); 
    }
}