public class Class1
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");
  }
  public static int Solution(int value)
  {
    if (value < 3)
    {
      return 0;
    }

    int result = 0;

    for (int i = 3; i < value; i++)
    {
      if (i % 3 == 0 || i % 5 == 0)
      {
        result += i;
      }
    }

    return result;
  }
}
