#!/bin/bash
echo "Enter new folder name:"
read folder;
echo "Enter Challenge Name:"
read challenge;

echo "Folder: $folder";
echo "challenge: $challenge";

if [ ! -d "$folder" ]; then
  mkdir $folder;
fi
cd $folder;

dotnet new console -o $challenge
cd $challenge;

touch $challenge.cs;
echo "public class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");
  }
}

public class Class1
{
}
" > $challenge.cs;

rm Program.cs;

dotnet add package Microsoft.NET.Test.Sdk --no-restore;
dotnet add package NUnit --no-restore;
dotnet add package NUnit3TestAdapter --no-restore;
dotnet add package coverlet.collector --no-restore;

mkdir Tests;
cd Tests;

dotnet new nunit | cat;

echo "*******"
echo "Add <GenerateProgramFile>false</GenerateProgramFile> to the test .csproj"