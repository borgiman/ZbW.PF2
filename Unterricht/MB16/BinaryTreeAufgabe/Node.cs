namespace MB16.BinaryTreeAufgabe;

public class Node<TNode> where TNode : IComparable<TNode>
{
    public TNode Item { get; set; }
    public Node<TNode> Left { get; set; }
    public Node<TNode> Right { get; set; }

    public int CompareTo(TNode other)
    {
        return Item.CompareTo(other);
    }
}
