using Microsoft.AspNetCore.Mvc;
using MinimapApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
builder.Services.AddScoped<IStupidService, StupidService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/weatherforecast", ([FromServices] IWeatherForecastService forecastService) =>
    {
        return forecastService.GetForecast();
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.MapGet("/getStupid", ([FromServices] IStupidService stupidService) =>
    {
        return stupidService.GetStupid();
    })
    .WithName("GetStupid")
    .WithOpenApi();

app.Run();

public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}