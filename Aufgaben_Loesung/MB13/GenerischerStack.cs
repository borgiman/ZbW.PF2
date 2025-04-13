namespace MB13;

public class GenerischerStack<T>
{
    protected T[] data;
    protected int top;

    // creates stack of the specified size
    public GenerischerStack(int size)
    {
        data = new T[size];
        top = -1;
    }

    // pushes the value x on the stack
    public void Push(T x)
    {
        if (top == data.Length - 1)
        {
            throw new Exception("-- stack overflow");
        }
        data[++top] = x;
    }

    // pops the topmost value from the stack
    public T Pop()
    {
        if (top < 0)
        {
            throw new Exception("-- stack underflow");
        }
        return data[top--];
    }

    // returns the stack size
    public int Size
    {
        get { return top + 1; }
    }
}
