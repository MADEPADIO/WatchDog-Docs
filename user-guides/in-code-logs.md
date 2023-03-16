---
description: Setup Logging to External Db, ILogger Sink Logs
---

# In-Code Logs

#### Setup Logging to External Db (MSSQL, MySQL, PostgreSQL & MongoDb) `Optional` <a href="#https-github.com-izypro-watchdog-setup-logging-to-external-db-mssql-mysql-postgresql-mongodb-optiona" id="https-github.com-izypro-watchdog-setup-logging-to-external-db-mssql-mysql-postgresql-mongodb-optiona"></a>

Add Database Connection String and Choose DbDriver Option

```c#
services.AddWatchDogServices(opt => 
{
   opt.IsAutoClear = false; 
   opt.SetExternalDbConnString = "Server=localhost;Database=testDb;User Id=postgres;Password=root;"; 
   opt.DbDriverOption = WatchDogSqlDriverEnum.PostgreSql; 
});
```

**Sink Logs from ILogger**

You can also sink logs from the .NET ILogger into WatchDog

> For .NET 6 and above

```
builder.Logging.AddWatchDogLogger();
```

> For .NET Core 3.1, configure logging and add `.AddWatchDogLogger()` to the `CreateHostBuilder` method of the `Program.cs` class

```
Host.CreateDefaultBuilder(args)
 .ConfigureLogging( logging =>
 {
     logging.AddWatchDogLogger();
 })
 .ConfigureWebHostDefaults(webBuilder =>
 {
     webBuilder.UseStartup<Startup>();
 });
```
