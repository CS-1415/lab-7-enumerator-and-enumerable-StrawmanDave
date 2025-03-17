namespace Lab07.Tests;

using System.Diagnostics;

    public class linkedListStartingEmptyTests
    {
        DoublyLinkedList<int> Numbers;
        [SetUp]
        public void Setup()
        {
            Numbers = new DoublyLinkedList<int>();
        }
        [Test]
        public void Test1()
        {
            Debug.Assert(Numbers.Length == 0); // Has correct length it was barrely created so it should be 0

        }

        public void Test2()
        {
            Numbers.AddLast(1);
            Debug.Assert(Numbers.Length == 1); // length is now 1;
            Numbers.printList(); // should print 1;
            Console.WriteLine();
        }
        public void Test3()
        {
            Numbers.AddFirst(2);
            Debug.Assert(Numbers.Length == 1); // length is now 1 
            Numbers.printList();// should print 2
            Console.WriteLine(); 
        }
    }