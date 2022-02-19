using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Npgsql;
using OpenTelemetry;
using OpenTelemetry.Contrib.Extensions.AWSXRay.Trace;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace Expensely.Tracing.OpenTelemetry.Extensions;

public static class Tracing
{
    public static void AddOpenTelemetry(
        IConfiguration Configuration) {
        Sdk.CreateTracerProviderBuilder()
            .SetResourceBuilder(ResourceBuilder
                .CreateDefault()
                .AddService(
                    Assembly.GetEntryAssembly()?.GetName().Name,
                    "Expensely",
                    Assembly.GetEntryAssembly()?.GetName().Version.ToString())
                .AddTelemetrySdk())
            .AddXRayTraceId()
            .AddAWSInstrumentation()
            .AddAspNetCoreInstrumentation()
            .AddHttpClientInstrumentation()
            .AddNpgsql()
            .SetErrorStatusOnException()
            .AddOtlpExporter(options => 
            {
                options.Endpoint = new Uri(Configuration.GetValue<string>("OpenTelemetry:Endpoint"));
            })
            .Build();
        Sdk.SetDefaultTextMapPropagator(new AWSXRayPropagator());
    }
}