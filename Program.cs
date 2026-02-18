namespace Stack_Push_Pop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack_Push_Pop.Stack stack = new Stack_Push_Pop.Stack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            Console.WriteLine("Top item: " + stack.Peek());
            Console.WriteLine("Popped item: " + stack.Pop());
            Console.WriteLine("Popped item: " + stack.Pop());
            Console.WriteLine("Popped item: " + stack.Pop());
            
            stack.Pop();
            stack.Pop();
            stack.Pop();
        }
    }
}
