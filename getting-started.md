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

Add WatchDog Namespace

```c#
using WatchDog;
```

#### Register WatchDog <a href="#https-github.com-izypro-watchdog-register-watchdog-service-in-startupcs-under-configureservice" id="https-github.com-izypro-watchdog-register-watchdog-service-in-startupcs-under-configureservice"></a>

```c#
services.AddWatchDogServices();
```

For .NET Core 3.1, this should be under the ConfigureService() in your `Startup.cs` file.

For .NET 5 and above, this should be in your `Program.cs` file.

#### Add WatchDog middleware in the HTTP request pipeline <a href="#https-github.com-izypro-watchdog-add-watchdog-middleware-in-the-http-request-pipeline-in-startupcs-u" id="https-github.com-izypro-watchdog-add-watchdog-middleware-in-the-http-request-pipeline-in-startupcs-u"></a>

This authentication information (Username and Password) will be used to access the log viewer.

```c#
app.UseWatchDog(opt => 
{ 
   opt.WatchPageUsername = "YOUR USERNAME GOES HERE"; 
   opt.WatchPagePassword = "YOUR PASSWORD GOES HERE"; 
 });
```

> **NOTE** If your project uses authentication, then `app.UseWatchDog();` should come after app.UseRouting(), app.UseAuthentication(), app.UseAuthorization(), in that order

<figure><img src=".gitbook/assets/login.png" alt=""><figcaption></figcaption></figure>



****

****

#### &#x20;<a href="#https-github.com-izypro-watchdog-view-logs-and-exception" id="https-github.com-izypro-watchdog-view-logs-and-exception"></a>
