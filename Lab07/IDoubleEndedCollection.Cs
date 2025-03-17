namespace Lab07;

public interface IDoubleEndedCollection<T>
{
    public T First { get; }
    public T Last { get; }
    int Length { get; }

    void AddLast(T value);  
    void AddFirst(T value);
    void RemoveFirst();     
    void RemoveLast();                
    void InsertAfter(DNode<T> dNode, T value);
    void RemoveByValue(T value);
    void ReverseList();
}