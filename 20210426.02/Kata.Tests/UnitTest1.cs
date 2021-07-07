public class SomeClass
{ /* This class should not conflict with your runtime classes */ }

namespace Kata.Tests
{
using NUnit.Framework;
using System;
using System.Collections.Generic;

  [TestFixture]
  public partial class SolutionTest
  { 
        [Test]
        public void BasicTest()
        {
            Random rand = new Random();
            Type myType = typeof(object);
            Dictionary<string, Type> properties;

            // Define first class
            properties = new Dictionary<string, Type> { { "SomeInt", typeof(int) }, { "SomeString", typeof(string) }, { "SomeObject", typeof(object) } };
            Kata.DefineClass("SomeClass", properties, ref myType);
            // Instantiate first class
            var myInstance = Activator.CreateInstance(myType);
            myInstance.SomeObject = myInstance;
            myInstance.SomeString = "Hey there";
            myInstance.SomeInt = 3;
            Console.WriteLine($"{myInstance.SomeObject}: {myInstance.SomeString}, {myInstance.SomeInt}");

            // Define second class
            properties = new Dictionary<string, Type> { { "AnotherObject", typeof(object) }, { "SomeDouble", typeof(double) }, { "AnotherString", typeof(string) } };
            Kata.DefineClass("AnotherClass_N" + rand.Next(100), properties, ref myType);
            // Instantiate second class
            myInstance = CreateInstance(myType);
            myInstance.AnotherObject = "User: ";
            myInstance.AnotherString = "My lucky number is ";
            myInstance.SomeDouble = 92835768;
            Console.WriteLine($"{myInstance.AnotherObject}: {myInstance.AnotherString} {myInstance.SomeDouble} ");

            // Try to redefine first class
            if (Kata.DefineClass("SomeClass", properties, ref myType) == true)
                Assert.Fail("This class is already defined");
        }
  }
}