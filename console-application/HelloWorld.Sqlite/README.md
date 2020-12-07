# SQLite and Repository Design Pattern

## Objective
This is to show how to create a console application to talk to SQLite database using Entity Framework Core. 
A sample SQLite database file, sample.db, is provided in the AppData folder.

## Technical Specification
Language: C# 9.0\
Framework: .NET 5, Entity Framework Core 5.0.0\
NuGet Packages:
 - [Entity Framework Core (5.0.0)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/);
 - [Entity Framework Core Design (5.0.0)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/);
 - [Entity Framework Core SQLite (5.0.0)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/);

## How to Run?
1. Execute the command below.\
   `dotnet run`

## References
1. [Repository Pattern: A data persistence abstraction](https://deviq.com/repository-pattern/);
1. [Using dependency injection in a .Net Core console application](https://andrewlock.net/using-dependency-injection-in-a-net-core-console-application/);
1. [Accessing dbContext in a C# console application](https://stackoverflow.com/a/49973934/1177328).