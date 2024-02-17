
class Postfix
{
    public Stack stack = null;
    public char[] postfix = null;
    static bool IsOperand(char x)
    {
        if (x == '+' || x == '-' || x == '*' || x == '/') return false;
        return true;
    }
    static int Pre(char x)
    {
        if (x == '+' || x == '-')
            return 1;
        else if (x == '*' || x == '/')
            return 2;

        return 0;
    }

    public void Convert(char[] infix)
    {
        Stack stack = new() { Size = infix.Length, chars = new char[infix.Length] };
        postfix = new char[stack.Size];
        int i = 0, j = 0;
        while (infix[i] != '\0')
        {
            if (IsOperand(infix[i]))
                postfix[j++] = infix[i++];
            else
            {
                if (Pre(infix[i]) > Pre(stack.StackTop()))
                    stack.Push(infix[i++]);
                else postfix[j++] = stack.Pop();
            }
        }
        while (!stack.IsEmpty())
            postfix[j++] = stack.Pop();
        postfix[j] = '\0';
    }

    public void Display()
    {
        int i = 0;
        while (postfix[i] != '\0')
        {
            System.Console.WriteLine(postfix[i++]);
        }

    }

}