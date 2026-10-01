using System.Text.Json;
using FunkoPopApi.Repository;
using FunkoPopApi.Routes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options => {
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
});

builder.Services.AddSingleton<IFunkoRepository, FunkoRepository>();

var app = builder.Build();

app.MapFunkoRoutes();

app.Run();