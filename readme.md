# Description
Calendar demo app using domain driven design, clean architecture, event sourcing, C# and VSCode (instead of Visual Studio).

# Usage
- Install REST Client extension in VSCode
- run api:
```bash
$ dotnet run --project ./EventSourcingCalendar.Api/ 
```
- open /requests/*.http files and click on send request

# User Stories
- User can create new calendars
- User can list calendars
- User can create events in a calendar
- User can view created events
- User can edit events
- User can delete events

# Steps To Create This Project From Scratch:
Create a new solution:
```bash
$ dotnet new sln -o EventSourcingCalendar
```
Change working directory:
``` bash
$ cd EventSourcingCalendar
```

Create a new web-api:
```bash
$ dotnet new webapi -o EventSourcingCalendar.Api
```

Create contracts, infrastructure, application and domain libraries:
```bash
$ dotnet new classlib -o EventSourcingCalendar.Contracts
$ dotnet new classlib -o EventSourcingCalendar.Infrastructure
$ dotnet new classlib -o EventSourcingCalendar.Application
$ dotnet new classlib -o EventSourcingCalendar.Domain
```
Add projects to the solution:
```bash
$ dotnet sln add $(ls -r **/*.csproj)
```

Build project:
```bash
$ dotnet build
```

Add dependencies:
```bash
$ dotnet add ./EventSourcingCalendar.Api/ reference ./EventSourcingCalendar.Contracts/ ./EventSourcingCalendar.Application/

$ dotnet add ./EventSourcingCalendar.Infrastructure/ reference ./EventSourcingCalendar.Application/

$ dotnet add ./EventSourcingCalendar.Application/ reference ./EventSourcingCalendar.Domain/

$ dotnet add ./EventSourcingCalendar.Api/ reference ./EventSourcingCalendar.Infrastructure/
```

Remove files:
```bash
$ rm -rf ./EventSourcingCalendar.Api/WeatherForecast.cs 
$ rm -rf ./EventSourcingCalendar.Api/Controllers/WeatherForecastController.cs
```

Add package for dependency injection:
```bash
$ dotnet add ./EventSourcingCalendar.Application/ package Microsoft.Extensions.DependencyInjection.Abstractions
```