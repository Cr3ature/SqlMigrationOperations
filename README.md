# SQL Migration Operations
[![Build Status](https://dev.azure.com/DavidVanderheyden/SpecificatR/_apis/build/status/Build.Pipeline?branchName=master)](https://dev.azure.com/DavidVanderheyden/SpecificatR/_build/latest?definitionId=7&branchName=master)

This is an extension library for the migrations used in EF Core. It's a work in progress library, as new and additional extensions will be added at any given time. So feel free to give feedback, request additional support, ...

Supports .NET Core, .NET Standard, .NET Framework

## Get it on Nuget

The package:
``` csharp
PM> Install-Package SqlMigrationOperations
```

## Usage
### Install the SqlMigrationOperations package
The package:
``` csharp
PM> Install-Package SqlMigrationOperations
```
### Registering dependencies 
Call below code inside the ````Configure```` method in Startup.cs or from inside an IServiceCollection extension 
````csharp
 services
    .AddEntityFrameworkSqlServer()
    .AddDbContext<{MyDbContext}>(options =>
    {
        options.UseSqlServer(connectionString);
        options.ReplaceService<IMigrationsSqlGenerator, SqlMigrationOperationsGenerator>();
    })
    .BuildServiceProvider();
````

Need support for a different provider (PostgreSQL, ...) ? Feel free to [open a new issue](https://github.com/Cr3ature/SqlMigrationOperations/issues/new)

### Todo

- Adding other provider (PostgreSQL)
- Extending Operations
