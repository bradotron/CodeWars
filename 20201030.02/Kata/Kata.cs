using System;

namespace Kata
{
  public class Matrix
  {
    public static int Determinant(int[][] matrix)
    {
      if (matrix.Length == 1)
      {
        return matrix[0][0];
      }
      else if (matrix.Length == 2)
      {
        return (matrix[0][0] * matrix[1][1]) - (matrix[0][1] * matrix[1][0]);
      }
      else
      {
        int answer = 0;
        int toggle = 1;

        for (int i = 0; i < matrix.Length; i++)
        {
          answer += toggle * (matrix[0][i] * (Determinant(Minor(matrix, 0, i))));
          toggle = toggle * -1;
        }

        return answer;
      }
    }

    public static int[][] Minor(int[][] original, int row, int col)
    {
      int[][] output = new int[original.Length - 1][];
      
      for (int i = 0; i < original.Length - 1; i++)
      {
        output[i] = new int[original.Length - 1];
      }

      bool minusOneRow = false;
      for (int i = 0; i < original.Length; i++)
      {
        if (i != row)
        {
          int currentRowIndex = i - (minusOneRow ? 1 : 0);

          bool minusOneColumn = false;
          for (int j = 0; j < original.Length; j++)
          {
            if (j != col)
            {
              int currentColumn = j - (minusOneColumn ? 1 : 0);
              output[currentRowIndex][currentColumn] = original[i][j];
            }
            else
            {
              minusOneColumn = true;
            }
          }
        }
        else
        {
          minusOneRow = true;
        }
      }

      return output;
    }
  }
}
