using System.Collections;
using System.Collections.Generic;

namespace Kata
{
  public class Kata
  {
    public static List<int> TreeByLevels(Node node)
    {
      List<int> result = new List<int>();

      Queue<Node> nodeQueue = new Queue<Node>();
      nodeQueue.Enqueue(node);

      while (nodeQueue.TryDequeue(out Node next))
      {
        if (next.Left != null) { nodeQueue.Enqueue(next.Left); }
        if (next.Right != null) { nodeQueue.Enqueue(next.Right); }

        result.Add(next.Value);
      }

      return result;
    }
  }

  public class Node
  {
    public Node Left;
    public Node Right;
    public int Value;

    public Node(Node l, Node r, int v)
    {
      Left = l;
      Right = r;
      Value = v;
    }
  }
}