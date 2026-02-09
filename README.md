# ProjectDatabase (TechDecisionHelper)

A Blazor Web project (ASP.NET Core) that uses Entity Framework Core with SQLite for data storage.

## Features

- Blazor (ASP.NET Core) web app
- Entity Framework Core with SQLite (`Microsoft.EntityFrameworkCore.Sqlite`)

## Prerequisites

- .NET 10 SDK installed: https://dotnet.microsoft.com
	- (Optional) `dotnet-ef` tool to run migrations locally: `dotnet tool install --global dotnet-ef`

## Build and run

From the repository root run:

```
dotnet build
dotnet run --project TechDecisionHelper/ProjectDatabase.csproj
```

The app will start and listen on the configured URLs. Open the URL shown in the console to access the app.

## Database / EF Core

This project uses SQLite via EF Core. To create or apply migrations locally use the EF CLI:

```
dotnet ef migrations add InitialCreate --project TechDecisionHelper/ProjectDatabase.csproj
dotnet ef database update --project TechDecisionHelper/ProjectDatabase.csproj
```

Adjust the project paths above if you run commands from a different working directory.

## Git / Uploading to remote

If files are not yet committed or pushed to your remote, run:

```
git add -A
git commit -m "Add project files"
git push -u origin master
```

If some files are ignored by `.gitignore` and you need to force-add them:

```
git add -f <path-to-file>
git commit -m "Force add ignored file"
git push
```

## Notes

- This README is intentionally short — expand sections (architecture, configuration, deployment) as the project grows.
