#!/usr/bin/env bash
dotnet new console -o 2-new_project
cd 2-new_project || exit 1
dotnet build
dotnet run
