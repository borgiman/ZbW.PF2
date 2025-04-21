using MB16.BinaryTreeAufgabe;

public static class Program
{
    private static void Main(string[] args)
    {
        var tree = new BinaryTree<int>();

        //tree.AddRange(new int[] { 5, 3, 8, 2, 4, 7, 9 });
        //tree.AddRange(new int[] { 4, 2, 1, 3, 6, 5, 7 });
        //tree.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7 });
        //tree.AddRange(new int[] { 110, 130, 135, 140, 150, 160 });
        tree.AddRange(new int[] { 4, 2, 6, 1, 3, 7, 8 });

        //Console.WriteLine(tree);
        //tree.Remove(6);
        //Console.WriteLine(tree);

        //Console.WriteLine(tree.Contains(10));
        //Console.WriteLine(tree.Contains(11));
        //Console.WriteLine(tree.Contains(2));
        //Console.WriteLine(tree.Contains(0));

        //Console.WriteLine(tree);

        tree.TraverseMode = TraverseMode.PreOrder;
        Console.WriteLine(tree);

        tree.TraverseMode = TraverseMode.PostOrder;
        Console.WriteLine(tree);

        tree.TraverseMode = TraverseMode.InOrder;
        Console.WriteLine(tree);

        tree.TraverseMode = TraverseMode.ReverseInOrder;
        Console.WriteLine(tree);

        //tree.Remove(3);
        //Console.WriteLine(tree);

        // *** Remove Szenario 1
        //tree.Clear();
        //tree.AddRange(new int[] { 4, 2, 1, 3, 8, 6, 5, 7 });
        //Console.WriteLine(tree);
        //tree.Remove(8);
        //Console.WriteLine(tree);

        // *** Remove Szenario 2
        //tree.Clear();
        //tree.AddRange(new int[] { 4, 2, 1, 3, 6, 7, 8 });
        //Console.WriteLine(tree);
        //tree.Remove(6);
        //Console.WriteLine(tree);

        // *** Remove Szenario 3
        //tree.Clear();
        //tree.AddRange(new int[] { 4, 2, 1, 3, 6, 5, 8, 7 });
        //tree.AddRange(new int[] { 4, 2, 1, 3, 6, 5, 7, 8 });
        //Console.WriteLine(tree);
        //tree.Remove(6);
        //Console.WriteLine(tree);

        Console.ReadLine();
    }
}
