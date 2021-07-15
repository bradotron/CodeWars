using System;

namespace ValidWalk
{
  public class Kata
  {
    public static bool IsValidWalk(string[] walk)
    {
      if (walk.Length != 10)
      {
        return false;
      }

      Position position = new Position(0, 0);
      
      for (int i = 0; i < walk.Length; i++)
      {
        position.Move(walk[i]);
        Console.WriteLine("[{0}] to ({1},{2})", walk[i], position.x, position.y);
      }

      return position.x == 0 && position.y == 0;
    }

    public class Position
    {
      public int x
      {
        get; private set;
      }
      public int y
      {
        get; private set;
      }

      public Position(int x, int y)
      {
        this.x = x;
        this.y = y;
      }

      public void Move(string direction)
      {
        switch (direction)
        {
          case "n":
            y++;
            break;
          case "e":
            x++;
            break;
          case "s":
            y--;
            break;
          case "w":
            x--;
            break;
          default:
            throw new Exception("Invalid move character: " + direction.ToString());
        }
      }
    }
  }
}
