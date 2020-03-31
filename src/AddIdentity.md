# Implementation steps

## Adding identity for authentication

- Add new project for Data
  - cmd: `dotnet new classlib -n AccountsManager.Infrastructure.Data/`
- Add project to the solution
  - cmd: from root folder> `dotnet sln add ...Data.csproj`
- Add Entity framework core package for sql lite in both Data and Web project
  - cmd: `dotnet add package Microsoft.EntityFrameworkCore.SQLite`
- Added `AccountsManagerDbContext.cs`
- Add reference of data project into web project
  - cmd: from web project folder> `dotnet add reference ...Data.csproj`
- Added AspNetCore Identity EntityFrameworkCore
  - cmd: `dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore`

## Migrations

- Added package to Data project
  - cmd: `dotnet add package Microsoft.EntityFrameworkCore.Design`
- Created first migration
  - cmd: `dotnet ef migrations add InitialCreate`
  > This will create migrations required by Identity
- Create database
  - cmd: `dotnet ef database update`
  