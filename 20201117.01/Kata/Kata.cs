using System;
using System.Collections.Generic;

namespace Kata
{
  public class Kata
  {
    public static List<int> TreeByLevels(Node node)
    {
      List<int> LevelOrder = new List<int>();
      int height = HeightFromNode(node);

      for (int i = 1; i <= height; i++)
      {
        LevelOrder.AddRange(GetListAtLevel(node, i));
      }

      return LevelOrder;
    }

    public static int HeightFromNode(Node node)
    {
      if (node == null)
      {
        return 0;
      }
      else
      {
        int LeftHeight = HeightFromNode(node.Left);
        int RightHeight = HeightFromNode(node.Right);

        return LeftHeight > RightHeight ? LeftHeight + 1 : RightHeight + 1;
      }
    }

    public static List<int> GetListAtLevel(Node root, int level)
    {
      if (root == null)
      {
        return new List<int>();
      }

      if (level == 1)
      {
        return new List<int>() { root.Value };
      }
      else
      {
        List<int> output = new List<int>();
        output.AddRange(GetListAtLevel(root.Left, level - 1));
        output.AddRange(GetListAtLevel(root.Right, level - 1));
        return output;
      }

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
