using System.ComponentModel.Design.Serialization;
using System.Xml.Linq;

namespace Kata
{
  public class Kata
  {
    // https://www.codewars.com/kata/55dcdd2c5a73bdddcb000044/train/csharp
    public static long Calculate(IEnumerable<int[]> rectangles)
    {
      // your code here...

      // for each rectangle
      //   insert x0 and x1 into bst, then insert the y values into each x0 and x1 in a hashmap...maybe?

      // sorted binary tree of the x values
      // hashmap for x value that stores any y0 y1 pairs for rectangles at that x value

      // traverse the tree and at each vertex, add up 

      return -1;
    }

    // [x0, y0, x1, y1]
    public static long Area(int[] rectangle)
    {
      long width = rectangle[2] - rectangle[0];
      long height = rectangle[3] - rectangle[1];

      return width * height;
    }

    public class IntBinarySearchTree
    {
      private IntNode root = null;
      public IntNode Root { get { return root; } }

      public IntBinarySearchTree(IntNode root)
      {
        this.root = root;
      }

      public void Insert(int key)
      {
        IntNode node = new IntNode(key);

        if (root == null)
        {
          root = node;
          return;
        }

        IntNode prev = null;
        IntNode temp = root;

        while (temp != null)
        {
          if (temp.Value > key)
          {
            prev = temp;
            temp = temp.Left;
          }
          else if (temp.Value < key)
          {
            prev = temp;
            temp = temp.Right;
          }
        }

        if (prev.Value > key)
        {
          prev.Left = node;
        }
        else
        {
          prev.Right = node;
        }
      }

      public IEnumerable<int> InOrderTraverse()
      {
        IntNode temp = root;
        Stack<IntNode> stack = new Stack<IntNode>();

        while (temp != null || stack.Count != 0)
        {
          if (temp != null)
          {
            stack.Push(temp);
            temp = temp.Left;
          }
          else
          {
            temp = stack.Pop();
            yield return temp.Value;
            temp = temp.Right;
          }
        }
      }

      public IntNode Search(int value)
      {
        return Search(value, Root);
      }

      private IntNode Search(int value, IntNode current)
      {
        if (current == null) { return null; }
        if (value == current.Value) { return current; }
        if (value < current.Value) { return Search(value, current.Left); }
        if (value > current.Value) { return Search(value, current.Right); }

        return null;
      }
    }

    public class IntNode
    {
      public IntNode? Left;
      public IntNode? Right;
      public int Value;

      public IntNode(int v)
      {
        Value = v;
      }

      public IntNode(IntNode l, IntNode r, int v)
      {
        Left = l;
        Right = r;
        Value = v;
      }
    }
  }
}