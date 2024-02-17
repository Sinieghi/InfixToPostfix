class Program
{
    static void Main(string[] args)
    {
        // char[] infix = ['a', '+', 'b', '*', 'c', '-', 'd', '/', 'e', '\0'];
        // char[] infix = ['(', '(', 'a', '+', 'b', ')', '*', 'c', ')', '-', 'd', '^', 'e', '^', 'f', '\0'];
        char[] infix = ['3', '5', '*', '6', '2', '2', '/', '+', '4', '-', '\0'];
        Postfix postfix = new();
        postfix.Convert(infix);
        System.Console.WriteLine(postfix.postfix);
        // char[] po = ['2', '3', '4', '*', '+', '8', '2', '/', '-', '\0'];
        postfix.Evaluate(postfix.postfix);
        // postfix.Display();
        System.Console.WriteLine(postfix.postfix);
    }
}