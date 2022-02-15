using Simplz.Monitoring.Services;
using Simplz.Monitoring.Options;
using Simplz.Monitoring.Models.Kibana;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("AppConfig");

if (!string.IsNullOrEmpty(connectionString))
    builder.Host.ConfigureAppConfiguration(builder =>
    {
        builder.AddAzureAppConfiguration(connectionString);
    });

builder.Services.Configure<InfluxOptions>(builder.Configuration.GetSection("InfluxOptions"));
builder.Services.AddSingleton<InfluxService>();

builder.Services.Configure<DiscordOptions>(builder.Configuration.GetSection("DiscordOptions"));
builder.Services.AddSingleton<DiscordService>();

await using var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/elkdiscord", async ([FromServices] DiscordService discord, [FromServices] InfluxService influx, [FromBody] Alert alert) =>
{

});

await app.RunAsync();