namespace Lab07;

using System.Collections.Generic;

public interface IDoubleEndedCollection<T>
{
    T First { get; }
    T Last { get; }
    int Length { get; }

    void AddLast(T value);  
    void AddFirst(T value);
    void RemoveFirst();     
    void RemoveLast();                
    void InsertAfter(DNode<T> dNode, T value);
    void RemoveByValue(T value);
    void ReverseList();
}

public class DNode<T>
{
    public T Value {get; set;}
    public DNode<T>? Previous {get; set;}
    public DNode<T>? Next {get; set;}
}

public class DoublyLinkedListNode<T>
{
    public T Value {get; set;}
    public DoublyLinkedListNode<T> Previous {get; set;}
    public DoublyLinkedListNode<T> Next {get; set;}
}

public class DoublyLinkedList<T> : LinkedList<T>, IDoubleEndedCollection<T>, IEnumerable<T>
{
    private DoublyLinkedListNode<T>? _head = null;
    private DoublyLinkedListNode<T>? _tail = null;
    T IDoubleEndedCollection<T>.First => throw new NotImplementedException();
    T IDoubleEndedCollection<T>.Last => throw new NotImplementedException();
    public int Length {get;} = 0;
    
    public void AddLast(T value)
    {

    }

    public void AddFirst(T value)
    {
        
    }

    public void RemoveFirst()
    {

    }

    public void RemoveLast()
    {

    }

    public void InsertAfter(DNode<T> dNode, T value)
    {

    }

    public void RemoveByValue(T value)
    {

    }

    public void ReverseList()
    {

    }
}