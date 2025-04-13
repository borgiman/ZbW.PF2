using MB13;

public class Program
{
    static void Main(string[] args)
    {
        /*
        // -----------------
        // Generischer Stack
        // -----------------
        GenerischerStack<string> stringStack = new GenerischerStack<string>(10);
        GenerischerStack<int> intStack = new GenerischerStack<int>(10);

        foreach (string s in args)
        {
            stringStack.Push(s);
            intStack.Push(s.Length);
        }

        while (stringStack.Size > 0)
        {
            Console.WriteLine(stringStack.Pop() + ": " + intStack.Pop());
        }
        */

        /*
        // ---------
        // Vererbung
        // ---------
        BessererGenerischerStack<string> bessererStack = new BessererGenerischerStack<string>(10);
        foreach (string s in args)
        {
            bessererStack.Push(s);
        }

        for (int i = 0; i < bessererStack.Size; i++)
        {
            Console.WriteLine(bessererStack[i]);
        }

        Console.WriteLine();

        while (true)
        {
            Console.Write("> ");

            string word = Console.ReadLine();
            if (word.Length == 0)
            {
                break;
            }

            if (bessererStack.Contains(word))
            {
                Console.WriteLine(" found");
            }
            else
            {
                Console.WriteLine(" not found");
            }
        }
        */

        /*
        // ---------
        // Fibonacci
        // ---------
        int count = int.Parse(Console.ReadLine());
        var stack = new GenerischerStack<long>(2);
        stack.Push(0);
        stack.Push(1);
        for (int i = 2; i <= count; i++)
        {
            long second = stack.Pop();
            long first = stack.Pop();
            stack.Push(second);
            stack.Push(first + second);
        }
        Console.WriteLine(stack.Pop());
        */
    }
}