namespace Lab07.Tests;
using System.Diagnostics;
using Lab07;
using NUnit.Framework.Internal;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]

    public void TestPrintList()
    {
        //Test if printing out the list works correctly
        DoublyLinkedList<int> Numbers = new DoublyLinkedList<int>();
        Numbers.AddLast(1);
        Numbers.AddLast(2);
        Numbers.AddLast(3);
        Numbers.AddLast(4);
        Console.WriteLine("List in order");
        Numbers.printList(); // should print 1 2 3 4
        Console.WriteLine();
        foreach(int num in Numbers) //should also print 1 2 3 4
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }

    public void TestRemoveLast()
    {
        //test if removelast works
        DoublyLinkedList<int> Numbers = new DoublyLinkedList<int>();
        Numbers.AddLast(1);
        Numbers.AddLast(2);
        Numbers.AddLast(3);
        Numbers.AddLast(4);
        Numbers.RemoveLast();
        Console.WriteLine("Removed the end node");
        Numbers.printList();// should print 1 2 3
        Console.WriteLine();
        foreach(int num in Numbers) //print 1, 2, 3,
        {
            Console.Write($"{num}, ");
        }
        Console.WriteLine();
    }

    public void TestReverseList()
    {
        //test if reversList works
        DoublyLinkedList<int> Numbers = new DoublyLinkedList<int>();
        Numbers.AddLast(1);
        Numbers.AddLast(2);
        Numbers.AddLast(3);
        Numbers.AddLast(4);
        Numbers.ReverseList();
        Console.WriteLine("List reversed");
        Numbers.printList(); // should print 4 3 2 1
        Console.WriteLine();
        foreach(int num in Numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();

        DoublyLinkedList<string> Words = new DoublyLinkedList<string>();
        Words.AddLast("The");
        Words.AddLast("Quick");
        Words.AddLast("Brown");
        Words.AddLast("Fox");

        //second test with words for reverse list
        Words.printList(); // should print The Quick Brown Fox
        Console.WriteLine();
        Words.ReverseList();
        Words.printList();// should print Fox Brown Quick The
        Console.WriteLine();
        foreach(string word in Words) // should print Fox Brown Quick The
        {
            Console.Write($"{word} ");
        }
    }

    public void TestAddFirst()
    {
        //test if addFirst works correctly
        DoublyLinkedList<int> newNumber = new DoublyLinkedList<int>();
        newNumber.AddFirst(1);
        newNumber.AddFirst(2);
        newNumber.AddFirst(3);
        newNumber.AddFirst(4);
        newNumber.printList(); // should print 4 3 2 1
        Console.WriteLine();
        foreach(int num in newNumber) // should also print 4 3 2 1
        {
            Console.Write($"{num} ");
        }
    }

    public void TestRemovefirst()
    {
        //test if removeFirst wors correctly
        DoublyLinkedList<int> newNumber = new DoublyLinkedList<int>();
        newNumber.AddFirst(1);
        newNumber.AddFirst(2);
        newNumber.AddFirst(3);
        newNumber.AddFirst(4);
        newNumber.RemoveFirst();
        Console.WriteLine("Removed the first node");
        newNumber.printList(); //should print 3 2 1
        Console.WriteLine();
        foreach(int num in newNumber) // should also print 3 2 1
        {
            Console.Write($"{num} ");
        }
    }

    public void TestReverse()
    {
        //test if Reverse method really returns the list reversed.
        DoublyLinkedList<int> newNumber = new DoublyLinkedList<int>();
        newNumber.AddFirst(1);
        newNumber.AddFirst(2);
        newNumber.AddFirst(3);
        newNumber.AddFirst(4);
        newNumber.printList(); // should print 4 3 2 1
        Console.WriteLine();
        foreach(int num in newNumber) // should print 4 3 2 1
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        DoublyLinkedList<int> SameNumbers = newNumber.Reverse();
        SameNumbers.printList();// should print 1 2 3 4
        Console.WriteLine();
        foreach(int num in SameNumbers) //should print 1 2 3 4
        {
            Console.Write($"{num} ");
        }
    }

    public void TestDNodeEquals()
    {
        //test if DNodes equals works
        DNode<int> Node1 = new DNode<int>(3);
        DNode<int> Node2 = new DNode<int>(3);
        DNode<int> number2 = new DNode<int>(2);
        DNode<string> Node3 = new DNode<string>("Three");
        Console.WriteLine(Node1.Equals(Node2)); // should be true
        Console.WriteLine(Node1.Equals(Node3)); // should be false not even the same type
        DNode<string> Node4 = new DNode<string>("Three");
        Console.WriteLine(Node3.Equals(Node4)); // should be true;
        Console.WriteLine(Node1.Equals(number2)); // should be false different numbers 
        DNode<string> word2 = new DNode<string>("Two");
        Console.WriteLine(Node3.Equals(word2)); // should be false both strings but not the same string
    }

    public void TestContainsValue()
    {
        //test if remove by value works
        DoublyLinkedList<int> Numbers = new DoublyLinkedList<int>();
        Numbers.AddLast(1);
        Numbers.AddLast(2);
        Numbers.AddLast(3);
        Numbers.AddLast(4);
        Console.WriteLine(Numbers.ContainsValue(6)); // should be false because it does not contain that value
        Console.WriteLine(Numbers.ContainsValue(3)); // should be true it does contain a 3
    }

    public void TestRemoveByValue()
    {
        //test if remove by value works
        DoublyLinkedList<int> Numbers = new DoublyLinkedList<int>();
        Numbers.AddLast(1);
        Numbers.AddLast(2);
        Numbers.AddLast(3);
        Numbers.AddLast(4);
        Numbers.printList();
        Console.WriteLine();
        Numbers.RemoveByValue(3);
        Console.WriteLine("List without 3 in it");
        Numbers.printList(); // should print 1 2 4
        Console.WriteLine();
        foreach(int num in Numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();

        //second test for RemoveByValue
        DoublyLinkedList<string> Words = new DoublyLinkedList<string>();
        Words.AddLast("The");
        Words.AddLast("quick");
        Words.AddLast("brown");
        Words.AddLast("fox");
        Words.printList();
        Console.WriteLine();
        Words.RemoveByValue("quick");
        Console.WriteLine("List without quick in it");
        Words.printList(); // should print The brown fox
        Console.WriteLine();
        foreach(string word in Words) // should pritn the brown fox
        {
            Console.Write($"{word} ");
        }
    }

    public void TestInsertAfter()
    {
        //test if InsertAfter method works
        DoublyLinkedList<int> Numbers = new DoublyLinkedList<int>();
        Numbers.AddLast(1);
        Numbers.AddLast(2);
        Numbers.AddLast(3);
        Numbers.AddLast(4);
        Numbers.AddLast(7);
        Numbers.printList(); //1 2 3 4 7
        Console.WriteLine();

        Numbers.InsertAfter(new DNode<int>(4), 5);
        Numbers.InsertAfter(new DNode<int>(5), 6);
        Numbers.printList(); //1 2 3 4 5 6 7
        Console.WriteLine();
        foreach(int number in Numbers) // 1 2 3 4 5 6 7
        {
            Console.Write($"{number}, ");
        }
        Console.WriteLine();

        //Second test if InsertAfter method works
        DoublyLinkedList<string> words = new DoublyLinkedList<string>();
        words.AddLast("The");
        words.AddLast("quick");
        words.AddLast("brown");
        words.AddLast("fox");
        words.AddLast("jumps");
        words.printList(); // The quick brown fox jumps
        Console.WriteLine();
        words.InsertAfter(new DNode<string>("quick"), "agile");
        words.printList();// The quick agile brown fox jumps
        Console.WriteLine();
        foreach(string word in words)
        {
            Console.Write($"{word}, "); // The quick brown fox jumps
        }
        Console.WriteLine();
    }

    public void TestIfForeachPrints()
    {
        //Test if foreach works
        DoublyLinkedList<int> Numbers = new DoublyLinkedList<int>();
        Numbers.AddFirst(1);
        Numbers.AddLast(2);
        Numbers.AddLast(3);
        Numbers.AddLast(4);

        foreach(int num in Numbers)
        {
            Console.Write($"{num}, ");
        }
        Console.WriteLine();

        DoublyLinkedList<string> Words = new DoublyLinkedList<string>();
        Words.AddLast("The");
        Words.AddLast("quick");
        Words.AddLast("brown");
        Words.AddLast("fox");
        foreach(string value in Words)
        {
            Console.Write($"{value} ");
        }
    }


}