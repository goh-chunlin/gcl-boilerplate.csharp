# Hello World

## Objective
This is to show how to create a console application in .NET Core 3.1 using C# 8.0.

## Issues
1. There is a line `<GenerateTargetFrameworkAttribute>false</GenerateTargetFrameworkAttribute>` needed in the .csproj file otherwise VS Code will show an error saying "Duplicate Targetframework attribute".
   Solution: https://github.com/dotnet/sdk/issues/9781#issuecomment-425972023