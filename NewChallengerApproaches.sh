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

mkdir $challenge;
cd $challenge;
dotnet new sln;

mkdir Class1;
cd Class1;
dotnet new classlib;
cd ..;

dotnet sln add Class1/Class1.csproj;

mkdir Class1.Tests;
cd Class1.Tests;

dotnet new nunit;
dotnet add reference ../Class1/Class1.csproj

cd ..;
dotnet sln add ./Class1.Tests/Class1.Tests.csproj
