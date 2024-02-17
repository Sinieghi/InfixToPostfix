class Program
{
    static void Main(string[] args)
    {
        char[] infix = ['a', '+', 'b', '*', 'c', '-', 'd', '/', 'e', '\0'];
        Postfix postfix = new();
        postfix.Convert(infix);
        // postfix.Display();
        System.Console.WriteLine(postfix.postfix);
    }
}