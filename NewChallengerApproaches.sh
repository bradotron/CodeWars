#!/bin/bash
echo 'Start New Challenge'
while getopts f:c: flag
do
  case "${flag}" in
    f) folder=${OPTARG};;
    c) class=${OPTARG};;
  esac
done

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

