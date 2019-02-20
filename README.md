# SimpleID Capture C#.NET Sample
This is a Windows Forms application that shows how to integrate C#.NET code with SimpleID Capture.

## Third-Party components ##

We use the following third-party components on this project. Both of them are added as a Nuget dependency on the Visual Studio 2017 project. Feel free to use other libraries.

- [Newtonsoft JSON.NET][jsonnet]
- [Websocket-sharp][wssharp] (Pre-Release)

## Running the application ##

Before running the application, you need to have a valid installation of SimpleID Core and SimpleID Capture. You also need to set the API Key on SimpleID.cs file. Change the following line, build and run the project.

```cs
private string _apiKey = "YOUR_API_KEY";
```

## Contribution ##

Suggestions and new features for this sample are more than welcome. Feel free to submit a PR.

## License ##

This sample is provided under [The MIT License].




 [jsonnet]: <https://www.newtonsoft.com/json>
 [wssharp]: <https://github.com/sta/websocket-sharp>
