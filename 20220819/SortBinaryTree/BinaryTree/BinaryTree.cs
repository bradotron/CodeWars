namespace BinaryTree
{
  public class BinaryTree<T>
  {
    private Node<T> root;
    public Node<T> Root
    {
      get
      {
        return root;
      }
    }

    public BinaryTree(Node<T> root)
    {
      this.root = root;
    }
  }

  public class Node<T>
  {
    public Node<T> Left;
    public Node<T> Right;
    public T Value;

    public Node(Node<T> l, Node<T> r, T v)
    {
      Left = l;
      Right = r;
      Value = v;
    }
  }
}