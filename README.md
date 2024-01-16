# C# WebApi Testing Workshop

## Setup

Add an appsettings.json with the following contents, ensuring you update the credentials:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnectionString": "Host=manny.db.elephantsql.com; Database=DATABASE; Username=USERNAME; Password=PASSWORD; "
  }
}

```

Then you should examine the DatabaseContext.cs class, ensuring that the UseNpgsql line is uncommented like below:

```cs
 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    //optionsBuilder.UseInMemoryDatabase(databaseName: "Database");
    optionsBuilder.UseNpgsql(_connectionString);
}
```

Simple project to demo how you might use a framework such as [NUnit](https://nunit.org/) to test a WebApi Minimal Api.

