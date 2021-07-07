using System;
using System.Collections.Generic;

namespace Kata
{
  public static class Reflection
  {
    public static void GetTypes(List<Tuple<object, Type>> objectTypes)
    {
      for (int i = 0; i < objectTypes.Count; i++)
      {
        if (objectTypes[i].Item1 != null)
        {
          Tuple<object, Type> replacement = new Tuple<object, Type>(objectTypes[i].Item1, objectTypes[i].Item1.GetType());
          objectTypes[i] = replacement;
        }
      }
    }
  }
}
