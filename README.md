# ASP.NET Core MVC CRUD 

A simple ASP.NET Core MVC project demonstrating basic **CRUD (Create, Read, Update, Delete)** operations using **Entity Framework Core**.

The purpose of this project is to understand the **MVC architecture**, model binding, and the request flow in ASP.NET Core.

## Features

- Create a new student
- View all students
- View student details
- Update student information
- Delete a student

## Technologies Used

- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQL Server
- Razor Views

## Running Entity Framework Migrations with 
`dotnet ef`

### ! Delete the `Overview.cs` file first

### 1. Install EF Core CLI Tool

Install the Entity Framework CLI globally:

```bash
dotnet tool install --global dotnet-ef
```

### 2. Install Required NuGet Packages

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
### 3. Create the First Migration

```bash
dotnet tool install --global dotnet-ef
```
### 4. Apply Migration to the Database

```bash
dotnet ef database update
```
### Run the Application

```bash
dotnet run
```