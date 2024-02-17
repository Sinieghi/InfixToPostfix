class Stack<T>
{
    public int Top { get; set; } = -1;
    public T[] chars;
    public int Size { get; set; }

    public void Push(T x)
    {
        if (Top == Size - 1) System.Console.WriteLine("Overflow");
        else
        {
            Top++;
            chars[Top] = x;
        }
    }
    public T Pop()
    {
        T x = chars[chars.Length - 1];
        if (Top == -1) System.Console.WriteLine("Underflow");
        else x = chars[Top--];
        return x;
    }
    public T StackTop()
    {
        if (!IsEmpty()) return chars[Top];
        return chars[chars.Length - 1];
    }
    public bool IsEmpty()
    {
        if (Top == -1)
            return true;
        return false;
    }
}