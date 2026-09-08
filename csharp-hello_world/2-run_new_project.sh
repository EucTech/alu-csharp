#!/usr/bin/env bash
dotnet new console -o 2-new_project
cd 2-new_project || exit 1
sed -i 's/Hello, World!/Hello World!/g' Program.cs
dotnet build
dotnet run
