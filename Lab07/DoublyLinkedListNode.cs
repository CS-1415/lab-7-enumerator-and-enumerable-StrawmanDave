namespace Lab07;

public class DNode<T>
{
    public T Value {get; set;}
    public DNode<T>? Previous {get; set;}
    public DNode<T>? Next {get; set;}

    public DNode()
    {

    }

    public DNode(T value)
    {
        Value = value;
    }

    public bool Equals(DNode<T> node)
    {
        
        if(Value.GetHashCode() == node.GetHashCode())
        {
            return true;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}