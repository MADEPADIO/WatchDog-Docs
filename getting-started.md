---
description: Installing and Setting up WatchDog.
---

# Getting Started

### Installation <a href="#https-github.com-izypro-watchdog-installation" id="https-github.com-izypro-watchdog-installation"></a>

Install via .NET CLI

```bash
dotnet add package WatchDog.NET --version 1.4.6
```

Install via Package Manager

```bash
Install-Package WatchDog.NET --version 1.4.6
```

### Usage <a href="#https-github.com-izypro-watchdog-usage" id="https-github.com-izypro-watchdog-usage"></a>

To enable WatchDog to listen for requests, use the WatchDog middleware provided by WatchDog.

Add WatchDog Namespace in `Startup.cs`

```c#
using WatchDog;
```

#### Register WatchDog service in `Startup.cs` under `ConfigureService()` <a href="#https-github.com-izypro-watchdog-register-watchdog-service-in-startupcs-under-configureservice" id="https-github.com-izypro-watchdog-register-watchdog-service-in-startupcs-under-configureservice"></a>

```c#
services.AddWatchDogServices();
```

#### Setup AutoClear Logs `Optional` <a href="#https-github.com-izypro-watchdog-setup-autoclear-logs-optional" id="https-github.com-izypro-watchdog-setup-autoclear-logs-optional"></a>

This clears the logs after a specific duration.

> **NOTE** When `IsAutoClear = true` Default Schedule Time is set to Weekly, override the settings like below:

```c#
services.AddWatchDogServices(opt => 
{ 
   opt.IsAutoClear = true;
   opt.ClearTimeSchedule = WatchDogAutoClearScheduleEnum.Monthly;
});
```
