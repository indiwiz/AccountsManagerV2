# Adding identity for authentication

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
