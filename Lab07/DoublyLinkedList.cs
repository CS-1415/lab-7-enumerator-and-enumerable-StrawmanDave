namespace Lab07;

using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IDoubleEndedCollection<T>, IEnumerable<T>
{
    private DNode<T>? _head = default;
    private DNode<T>? _tail = default;
    T IDoubleEndedCollection<T>.First => _head.Value;
    T IDoubleEndedCollection<T>.Last => _tail.Value;
    public int Length {get; private set;} = 0;

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return new LinkedListEnumerator<T>(this._head);
    }

    public IEnumerator GetEnumerator()
    {
        return new LinkedListEnumerator<T>(this._head);
    }


    public void printList()
    {
        DNode<T> Curr = _head;
        for(int i = 0; i<Length; i ++)
        {
            Console.Write($"{Curr.Value} ");
            Curr = Curr.Next;
        }
    }

    public void AddLast(T value)
    {
        //used to add a node with the given value at the end of the list
        //create a new node with value of the parameter
        DNode<T> newNode = new DNode<T>(value);

        if(_tail == null)//checking if tail is null checks if the list is empty or has one because we set the head to the new node. 
        {
            _head = newNode;
        }else //if the list has one or more
        {//connect the final nodes
            newNode.Previous = _tail;
            _tail.Next = newNode;
        }
        _tail = newNode;
        Length ++;
    }

    public void AddFirst(T value)
    {
        //used to add a node with the given value at the beggining of the list
        //create a new node with the value of the paramerter
        DNode<T> newNode = new DNode<T>(value);
        newNode.Next = _head;

        if (_head == null)
        {
            _tail = newNode;
        }else
        {
            _head.Previous = newNode;
        }
        _head = newNode;
        Length ++;
    }

    public void RemoveFirst()
    {
        if(_head != null)
        { 
            _head = _head.Next;

            if(_head == null)
            {
                _tail = null;
            }
            Length --;
        }
    }

    public void RemoveLast() 
    {
        if(_tail == null){}; //do nothing because the list is empty 
        if(_tail.Previous == null) // if there is one element in the list set both the head and the tail to null
        {
            _head = null;
            _tail = null;
            Length --;
        }

        if(_tail.Previous != null) // if there is one or more element in the list
        {
            _tail = _tail.Previous;
            _tail.Next = null;
            Length --;
        }
    }

    public void InsertAfter(DNode<T> DN, T value)
    {
        //The idea is to give it the node that is equal to the one you want to AddAfter and a value witch will be the node added after the actual node you gave it.
        if(ContainsValue(DN.Value) == true)
        {
            DoublyLinkedList<T> temp = new DoublyLinkedList<T>();
            DNode<T> Curr = _head;
            while(Curr != null)
            {
                temp.AddLast(Curr.Value);
                if(Curr.Equals(DN))
                {
                    temp.AddLast(value);
                }
                Curr = Curr.Next;

                while(Length > 0)
                {
                    RemoveFirst();
                }

                DNode<T> currTemp = temp._head;
                while(currTemp != null)
                {
                    AddLast(currTemp.Value);
                    currTemp = currTemp.Next;
                }
            }
        }else
        {
            Console.WriteLine("The list does not contain that node");
        }
    }

    public void RemoveByValue(T value)
    {
        //Will remove any node out of the list with the given value.
        //should remove the first node found with that value.
        //should set missing pointers to what they need to be.
        //new temp list to hold all the values that are not the one given
        if(ContainsValue(value) == true)
        {
            DNode<T> Curr = _head;
            DNode<T> GivenNode = new DNode<T>(value);

            //iterarte through the current list and add each node to the temp list unless it is the GivenNode
            if(GivenNode.Equals(_head))
            {
                RemoveFirst();
            }else if(GivenNode.Equals(_tail))
            {
                RemoveLast();
            }else
            {
                while(Curr != null)
                {
                    if(Curr.Equals(GivenNode))
                    {
                        //skip that node
                        RemoveLast();
                        Curr = Curr.Next;
                    }
                    AddFirst(Curr.Value);
                    RemoveLast();
                    Curr = Curr.Next;
                }
                ReverseList();
            }
            
        }else
        {
            Console.WriteLine("That value was not found in the list");
        }
    }

    public bool ContainsValue(T value)
    {
        DNode<T> newNode = new DNode<T>(value);
        DNode<T> Curr = _head;
        while(Curr != null)
        {
            if(newNode.Equals(Curr))
            {
                return true;
            }
            Curr = Curr.Next;
        }
        return false;
    }

    public void ReverseList()
    {
            DNode<T> newCurr = _tail;
            while(newCurr != null)
            {
                AddLast(newCurr.Value);
                newCurr = newCurr.Previous;
                RemoveFirst();
            }
    }

    public DoublyLinkedList<T> Reverse()
    {
        DoublyLinkedList<T> reversed = new DoublyLinkedList<T>();
        while(_tail != null)
        {
            reversed.AddLast(_tail.Value);
            _tail = _tail.Previous;
        }
        return reversed;
    }
}