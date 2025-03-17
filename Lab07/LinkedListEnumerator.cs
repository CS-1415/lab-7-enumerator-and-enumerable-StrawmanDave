namespace Lab07;

using System.Collections;
using System.Collections.Generic;

public class LinkedListEnumerator<T>: IDisposable, IEnumerator, IEnumerator<T>
{
    DNode<T> currentNode;
    DNode<T> firstNode;
    T IEnumerator<T>.Current => setCurrentT();
    object IEnumerator.Current => setCurrentT();

    public LinkedListEnumerator(DNode<T> dNode)
    {
        firstNode = dNode;
    }
    private T setCurrentT()
    {
        if(currentNode == null)
        {
            return default;
        }else
        {
           return  currentNode.Value;
        }
    }
    void IDisposable.Dispose()
    {
    }
    bool IEnumerator.MoveNext()
    {
        if(currentNode == null)
        {
            currentNode = firstNode;
            if(firstNode == null)
            {
                return false;
            }else
            {
                return true;
            }
        }else
        {
            if(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                return true;
            }else
            {
                return false;
            }
        }
    }
    void IEnumerator.Reset()
    {
    }
}