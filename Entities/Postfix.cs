
class Postfix
{
    public char[] postfix = null;
    static bool IsOperand(char x)
    {
        if (x == '+' || x == '-' || x == '*' || x == '/' || x == '(' || x == ')' || x == '^') return false;
        return true;
    }
    static int OutStack(char x)
    {
        if (x == '+' || x == '-')
            return 1;
        else if (x == '*' || x == '/')
            return 3;
        else if (x == '^')
            return 6;
        else if (x == '(')
            return 7;
        else if (x == ')')
            return 0;

        return 0;
    }

    static int InStack(char x)
    {
        if (x == '+' || x == '-')
            return 2;
        else if (x == '*' || x == '/')
            return 4;
        else if (x == '^')
            return 5;
        else if (x == '(')
            return 0;

        return 0;
    }

    public void Convert(char[] infix)
    {
        Stack<char> stack = new() { Size = infix.Length, chars = new char[infix.Length] };
        postfix = new char[stack.Size];
        int i = 0, j = 0;
        while (infix[i] != '\0')
        {
            if (IsOperand(infix[i]))
                postfix[j++] = infix[i++];
            else
            {
                System.Console.WriteLine(infix[i]);
                if (OutStack(infix[i]) > InStack(stack.StackTop()))
                    stack.Push(infix[i++]);
                else
                {
                    if (infix[i] == ')') { postfix[j++] = stack.Pop(); stack.Pop(); }
                    else
                        postfix[j++] = stack.Pop();
                    i++;
                }
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

    public void Evaluate(char[] postfix)
    {
        Stack<int> stack = new() { Size = postfix.Length, chars = new int[postfix.Length] };
        int i, x1, x2, r;

        for (i = 0; postfix[i] != '\0'; i++)
        {
            if (IsOperand(postfix[i])) stack.Push(postfix[i] - '0');
            else
            {
                x2 = stack.Pop(); x1 = stack.Pop();
                switch (postfix[i])
                {
                    case '+': r = x1 + x2; stack.Push(r); break;
                    case '-': r = x1 - x2; stack.Push(r); break;
                    case '*': r = x1 * x2; stack.Push(r); break;
                    case '/': r = x1 / x2; stack.Push(r); break;
                }
            }
        }
        System.Console.WriteLine(stack.Pop());
        //return stack.Pop();
    }

}