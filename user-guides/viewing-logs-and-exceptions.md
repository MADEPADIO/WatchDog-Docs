# Viewing Logs and Exceptions

#### View Logs and Exception <a href="#https-github.com-izypro-watchdog-view-logs-and-exception" id="https-github.com-izypro-watchdog-view-logs-and-exception"></a>

Start your server and head to `/watchdog` to view the logs.

> Example: https://myserver.com/watchdog or https://localhost:\[your-port]/watchdog

Still confused? Check out the implementation in the [WatchDogCompleteTestAPI](https://github.com/IzyPro/WatchDog/tree/main/WatchDogCompleteTestAPI) folder or the .NET 6 implementation in the [WatchDogCompleteApiNet6](https://github.com/IzyPro/WatchDog/tree/main/WatchDogCompleteApiNet6) folder.

#### Log Messages/Events <a href="#https-github.com-izypro-watchdog-log-messagesevents" id="https-github.com-izypro-watchdog-log-messagesevents"></a>

```
WatchLogger.Log("...Test Log...");
WatchLogger.LogWarning(JsonConvert.Serialize(model));
WatchLogger.LogError(res.Content, eventId: reference);
```

<figure><img src="../.gitbook/assets/in-code.png" alt=""><figcaption><p>I p;</p></figcaption></figure>
