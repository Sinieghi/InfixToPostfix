class Stack
{
    public int Top { get; set; } = -1;
    public char[] chars;
    public int Size { get; set; }

    public void Push(char x)
    {
        if (Top == Size - 1) System.Console.WriteLine("Overflow");
        else
        {
            Top++;
            chars[Top] = x;
        }
    }
    public char Pop()
    {
        char x = ';';
        if (Top == -1) System.Console.WriteLine("Underflow");
        else x = chars[Top--];
        return x;
    }
    public char StackTop()
    {
        if (!IsEmpty()) return chars[Top];
        return ';';
    }
    public bool IsEmpty()
    {
        if (Top == -1)
            return true;
        return false;
    }
}