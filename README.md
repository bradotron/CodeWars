# CodeWars

Pre-reqs
Nodejs
Dotnet SDK
VSCode (or some other editor)

# New Challenge Script
The script is setup as if you were creating a new library with integrated unit tests. For some debugging purposes, I've needed to create a Main() function to see the flow of execution. Creating the Main() requires a few minor tweaks.

# Adding a Main()
in Class1.cs, do this:
```
using System;

namespace Class1;
public class Class1
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");
  }
}

```

in the Class1.csproj, add `<OutputType>Exe</OutputType>`:
```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <OutputType>Exe</OutputType>
  </PropertyGroup>

</Project>

```
in a terminal, navigate into the Class1 folder, then:
```
dotnet run
```
