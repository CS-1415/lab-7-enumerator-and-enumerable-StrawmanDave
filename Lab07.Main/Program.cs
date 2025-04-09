using Lab07;

//This is just for fun
//UI code allowing the user to add at the front and at the end and print out the DoublyLinkedList
/*
Console.Clear();
Console.WriteLine("Welcome to the DoublyLinkedList!");
string menu = @"
You can add to the front of the list by pressing j
You can add to the back by pressing k
You can view the list you have created by pressing v
Just press escape when you are done with the list
";
Console.WriteLine(menu);
DoublyLinkedList<string> stringList = new DoublyLinkedList<string>();
var keyPress = ConsoleKey.A;
string addToList;

while(keyPress != ConsoleKey.Escape)
{
    keyPress = Console.ReadKey(true).Key;
    switch(keyPress)
    {
        case ConsoleKey.J:
        Console.WriteLine("What would you like to add to the front of the list?");
        addToList = Console.ReadLine();
        stringList.AddFirst(addToList);
        break;
        case ConsoleKey.K:
        Console.WriteLine("What would you like to add to the end of the list?");
        addToList = Console.ReadLine();
        stringList.AddLast(addToList);
        break;
        case ConsoleKey.V:
        Console.WriteLine("Current list press any key when done viewing");
        foreach(string item in stringList)
        {
            Console.Write($"{item}, ");
        }
        Console.ReadKey(true);
        break;
    }
    Console.Clear();
    Console.WriteLine("Welcome to the DoublyLinkedList!");
    Console.WriteLine(menu);
}
*/

DoublyLinkedList<int> Numbers = new DoublyLinkedList<int>();
        Numbers.AddLast(1);
        Numbers.AddLast(2);
        Numbers.AddLast(3);
        Numbers.AddLast(4);
        Numbers.printList();
        Console.WriteLine();
        Numbers.RemoveByValue(3);
        Console.WriteLine("List without 3 in it");
        Numbers.printList(); // should print 1 2 3 5
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
        foreach(string word in Words) // should print The brown fox
        {
            Console.Write($"{word} ");
        }