# Description
Calendar demo app using domain driven design, clean architecture, event sourcing, C# and vscode (instead of visual studio).

# Usage
TODO

# User Stories
- user can create new calendars
- user can list calendars
- user can create events in a calendar
- user can view created events
- user can edit events
- user can delete events

# Steps To Create This Project From Scratch:
create a new solution:
```bash
$ dotnet new sln -o EventSourcingCalendar
```
change working directory:
``` bash
$ cd EventSourcingCalendar
```

create a new web-api:
```bash
$ dotnet new webapi -o EventSourcingCalendar.Api
```

create contracts, infrastructure, application and domain libraries:
```bash
$ dotnet new classlib -o EventSourcingCalendar.Contracts
$ dotnet new classlib -o EventSourcingCalendar.Infrastructure
$ dotnet new classlib -o EventSourcingCalendar.Application
$ dotnet new classlib -o EventSourcingCalendar.Domain
```
add projects to the solution:
```bash
$ dotnet sln add $(ls -r **/*.csproj)
```

build project:
```bash
$ dotnet build
```

add dependencies:
```bash
$ dotnet add ./EventSourcingCalendar.Api/ reference ./EventSourcingCalendar.Contracts/ ./EventSourcingCalendar.Application/

$ dotnet add ./EventSourcingCalendar.Application/ reference ./EventSourcingCalendar.Domain/

$ dotnet add ./EventSourcingCalendar.Api/ reference ./EventSourcingCalendar.Infrastructure/
```

