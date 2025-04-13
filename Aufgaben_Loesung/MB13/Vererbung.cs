namespace MB13;

public class BessererGenerischerStack<T> : GenerischerStack<T>
{
    // creates stack of the specified size
    public BessererGenerischerStack(int size) : base(size)
    {
    }

    // returns true if x is on the stack
    public bool Contains(T x)
    {
        for (int i = 0; i <= top; i++)
            if (x.Equals(data[i])) return true;
        return false;
    }

    // returns the i-th element of the stack
    public T this[int i]
    {
        get
        {
            if (i < 0 || i > top) throw new Exception("-- index out of bounds");
            return data[i];
        }
    }
}