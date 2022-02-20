# Expensely.Tracing.OpenTelemetry

[![Build Status](https://dev.azure.com/expensely-au/Expensely/_apis/build/status/Libraries/Tracing/Release?branchName=main)](https://dev.azure.com/expensely-au/Expensely/_build/latest?definitionId=60&branchName=main)

| View       | Badge                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|:-----------|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Prerelease | [![Expensely.Tracing.OpenTelemetry package in expensely-au@Prerelease feed in Azure Artifacts](https://feeds.dev.azure.com/expensely-au/_apis/public/Packaging/Feeds/4634f7ff-ee1a-49bd-b3de-2f19eb18d3e1@0b477f7e-e363-4441-97f7-bf3189253564/Packages/ca2ae895-8260-49cd-a885-3e8b76dec8d5/Badge)](https://dev.azure.com/expensely-au/Expensely/_packaging?_a=package&feed=4634f7ff-ee1a-49bd-b3de-2f19eb18d3e1%400b477f7e-e363-4441-97f7-bf3189253564&package=ca2ae895-8260-49cd-a885-3e8b76dec8d5&preferRelease=true) |
| Release    | [![Expensely.Tracing.OpenTelemetry package in expensely-au@Release feed in Azure Artifacts](https://feeds.dev.azure.com/expensely-au/_apis/public/Packaging/Feeds/4634f7ff-ee1a-49bd-b3de-2f19eb18d3e1@f9bccf78-9a6f-4e24-bcd7-b5f77186974c/Packages/ca2ae895-8260-49cd-a885-3e8b76dec8d5/Badge)](https://dev.azure.com/expensely-au/Expensely/_packaging?_a=package&feed=4634f7ff-ee1a-49bd-b3de-2f19eb18d3e1%40f9bccf78-9a6f-4e24-bcd7-b5f77186974c&package=ca2ae895-8260-49cd-a885-3e8b76dec8d5&preferRelease=true)    |


## How to Use
### Configuration
| Property Name | Description |
|:--------------|:------------|
| OpenTelemetry |             |

Add Configuration
``` json
{
  "OpenTelemetry": {
    "Endpoint": "http://open-telemetry:3125",
  }
}
```

Add open telemetry with configuration
``` csharp
public void ConfigureServices(IServiceCollection services)
{
    ...
    Tracing.AddOpenTelemetry(Configuration);
    ...
}
```

## Development
### Build, Package & Release
#### Locally
```
// Step 1: Authenticate
dotnet build --configuration release 

// Step 2: Pack
dotnet pack --configuration release 

// Step 3: Publish
dotnet nuget push "Expensely.Tracing.OpenTracing.*.nupkg" -Source "github"
```
