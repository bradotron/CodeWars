using System;
using System.Collections.Generic;

namespace Class1;
public static class RGBToHex
{
  public static string Rgb(int r, int g, int b)
  {
    r = r < 0 ? 0 : r > 255 ? 255 : r;
    g = g < 0 ? 0 : g > 255 ? 255 : g;
    b = b < 0 ? 0 : b > 255 ? 255 : b;

    return ((r < 16 ? "0" : "") + IntToHex(r)) +
           ((g < 16 ? "0" : "") + IntToHex(g)) +
           ((b < 16 ? "0" : "") + IntToHex(b));
  }

  public static string IntToHex(int i)
  {
    Dictionary<int, string> IntToHexString = new Dictionary<int, string> {
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

    int remainder = i % 16;
    if (i - remainder == 0)
    {
      return IntToHexString[remainder];
    }
    else
    {
      return IntToHex((i - remainder) / 16) + IntToHexString[remainder];
    }
  }
}
