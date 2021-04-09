using System;
using System.Linq;

namespace Kata
{
  public class Sudoku
  {
    private int[][] data;

    public Sudoku(int[][] data)
    {
      this.data = data;
    }

    public bool IsValid()
    {
      // check dimensions
      int N = data.Length;
      bool IsSquare = Math.Sqrt((double)N) % 1 == 0;
      if (!IsSquare || data.Any(array => array.Length != N))
      {
        return false;
      }

      if (data.Any(array => array.Any(value => value < 1 || value > N)))
      {
        return false;
      }

      int LittleN = (int)Math.Sqrt(N);

      int[] truth = new int[N];
      for (int i = 0; i < N; i++)
      {
        truth[i] = i + 1;
      }
      Console.WriteLine();

      // check the rows/columns
      for (int i = 0; i < N; i++)
      {
        // check row i
        int[] sortedRow = data[i].OrderBy(value => value).ToArray();
        if (!truth.SequenceEqual(sortedRow))
        {
          return false;
        }
        // check column i
        int[] sortedColumn = data.Select(array => array[i]).ToArray().OrderBy(value => value).ToArray();
        if (!truth.SequenceEqual(sortedColumn))
        {
          return false;
        }

        // check the small squares
        int[] LittleSquareArray = new int[N];
        int BaseRow = (int)(i / LittleN) * LittleN;
        int BaseColumn = i % LittleN * LittleN;
        for (int j = 0; j < N; j++)
        {
          LittleSquareArray[j] = data[BaseRow + (int)(j / LittleN)][BaseColumn + j % LittleN];
        }

        if (!truth.SequenceEqual(LittleSquareArray.OrderBy(value => value).ToArray()))
        {
          return false;
        }
      }

      return true;
    }
  }
}
