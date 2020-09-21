#!/bin/bash
echo "Enter new folder name:"
read folder;
echo "Enter class name:"
read class;

echo "Folder: $folder";
echo "Class: $class";

# make directory
mkdir $folder;
# change into project directory
cd $folder;
dotnet new sln | cat;

# make class directory
mkdir $class;
# move into class
cd $class;
dotnet new classlib | cat;
mv Class1.cs $class.cs

cd ..
dotnet sln add $class/$class.csproj | cat;

mkdir $class.Tests;
cd $class.Tests;
dotnet new nunit | cat;
dotnet add reference ../$class/$class.csproj | cat;

cd ..
dotnet sln add ./$class.Tests/$class.Tests.csproj;

