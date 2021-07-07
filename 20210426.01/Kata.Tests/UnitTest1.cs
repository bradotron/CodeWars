using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.Tests
{
  public class Tests
  {
    [Test]
    public void Test1()
    {
      List<Tuple<object, Type>> Input = new List<Tuple<object, Type>>();
      List<Tuple<object, Type>> Solution = new List<Tuple<object, Type>>();

      Kata.Reflection.GetTypes(Input);

      Assert.AreEqual(Input, Solution);
    }

    [Test]
    public void Test2()
    {
      Tuple<object, Type> NullTest = new Tuple<object, Type>(null, null);
      List<Tuple<object, Type>> Input = new List<Tuple<object, Type>>();
      Input.Add(NullTest);

      Tuple<object, Type> NullSolution = new Tuple<object, Type>(null, null);
      List<Tuple<object, Type>> Solution = new List<Tuple<object, Type>>();
      Solution.Add(NullSolution);

      Kata.Reflection.GetTypes(Input);

      Assert.AreEqual(Input, Solution);
    }

    [Test]
    public void Test3()
    {
        string testString = "test";
      Tuple<object, Type> StringTest = new Tuple<object, Type>(testString, null);
      List<Tuple<object, Type>> Input = new List<Tuple<object, Type>>();
      Input.Add(StringTest);

      Tuple<object, Type> StringSolution = new Tuple<object, Type>(testString, testString.GetType());
      List<Tuple<object, Type>> Solution = new List<Tuple<object, Type>>();
      Solution.Add(StringSolution);

      Kata.Reflection.GetTypes(Input);

      Assert.AreEqual(Input, Solution);
    }
  }
}