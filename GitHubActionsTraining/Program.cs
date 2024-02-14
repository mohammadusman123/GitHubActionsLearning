using Microsoft.AspNetCore.Mvc;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/time/utc",
    () => Results.Ok("Current time is: " + DateTimeOffset.Now + " and the day is: " +
                     DateTimeOffset.Now.DayOfWeek + " and the weather is: look outside the window :p"));

app.Run();

public partial class Program
{
}