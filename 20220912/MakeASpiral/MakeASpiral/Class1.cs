public class Spiralizor
{
  public static int[,] Spiralize(int size)
  {
    int[,] spiral = new int[size, size];
    int snakeStartIndex = -1;
    int snakeStopIndex = size - 1;
    bool isGapRow = false;

    for (int rowIndex = 0; rowIndex < (size / 2 + size % 2); rowIndex++)
    {
      int[] nextRow = isGapRow ? getGapRow(snakeStopIndex, size) : getSnakeRow(snakeStopIndex, size);
      setRow(rowIndex, nextRow, spiral);

      if (rowIndex != size / 2)
      {
        int[] reversedRow = nextRow.Reverse().ToArray();
        reversedRow[snakeStopIndex] = 1;
        setRow(size - 1 - rowIndex, reversedRow, spiral);
      }

      isGapRow = !isGapRow;
      if (!isGapRow)
      {
        snakeStopIndex -= 2;
      }
    }

    for (int rowIndex = 0; rowIndex < spiral.GetLength(0); rowIndex++)
    {
      List<int> row = new List<int>();
      for (int colIndex = 0; colIndex < size; colIndex++)
      {
        row.Add(spiral[rowIndex, colIndex]);
      }
      Console.WriteLine(String.Join(" ", row));
    }

    return spiral;
  }

  public static void setRow(int rowIndex, int[] values, int[,] insertInto)
  {
    if (values.Length == insertInto.GetLength(0))
    {
      for (int colIndex = 0; colIndex < values.Length; colIndex++)
      {
        insertInto[rowIndex, colIndex] = values[colIndex];
      }
    }

  }

  public static int[] getGapRow(int lastTurnIndex, int size)
  {
    int[] result = new int[size];
    for (int colIndex = lastTurnIndex; colIndex < size; colIndex += 2)
    {
      result[colIndex] = 1;
    }
    return result;
  }

  public static int[] getSnakeRow(int lastTurnIndex, int size)
  {
    int[] result = new int[size];
    for (int colIndex = 0; colIndex < lastTurnIndex; colIndex++)
    {
      result[colIndex] = 1;
    }
    for (int colIndex = lastTurnIndex; colIndex < size; colIndex += 2)
    {
      result[colIndex] = 1;
    }
    return result;
  }
}