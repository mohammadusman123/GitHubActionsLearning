using Microsoft.AspNetCore.Mvc;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/time/utc",
    () => Results.Ok("Current time is: " + DateTimeOffset.Now + ", day is: " +
                     DateTimeOffset.Now.DayOfWeek + " and the weather is chilly. Hurray!! the summer is coming....."));

app.Run();

public partial class Program
{
}