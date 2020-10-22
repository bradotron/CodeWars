using System;
using System.Collections.Generic;

namespace Kata
{
  public class Kata
  {
    public static string Rgb(int r, int g, int b)
    {
      r = r < 0 ? 0 : r;
      r = r > 255 ? 255 : r;

      g = g < 0 ? 0 : g;
      g = g > 255 ? 255 : g;

      b = b < 0 ? 0 : b;
      b = b > 255 ? 255 : b;

      int[] values = new int[] { r, g, b };

      string output = "";

      foreach (int value in values)
      {
        string hex = IntToHex(value); 
        output += hex.Length == 1 ? hex.Insert(0, "0") : hex;        
      }

      return output;
    }

    public static string IntToHex(int input)
    {
      string output = "";

      int CurrentValue = input;
      int DivisionResult = input / 16;
      int Remainder = input % 16;
      CurrentValue = DivisionResult;

      output = output.Insert(0, DecimalToHexadecimal[Remainder]);

      while (DivisionResult > 0)
      {
        DivisionResult = CurrentValue / 16;
        Remainder = CurrentValue % 16;
        output = output.Insert(0, DecimalToHexadecimal[Remainder]);
        CurrentValue = DivisionResult;
      }

      return output;
    }

    private static Dictionary<int, string> DecimalToHexadecimal = new Dictionary<int, string>()
    {
      { 0, "0"},
      { 1, "1"},
      { 2, "2"},
      { 3, "3"},
      { 4, "4"},
      { 5, "5"},
      { 6, "6"},
      { 7, "7"},
      { 8, "8"},
      { 9, "9"},
      { 10, "A"},
      { 11, "B"},
      { 12, "C"},
      { 13, "D"},
      { 14, "E"},
      { 15, "F"},
    };
  }
}