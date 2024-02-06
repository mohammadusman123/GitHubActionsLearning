using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/time/utc",
    () => Results.Ok("Current time is: " + DateTimeOffset.Now + " and days is: " +
                     DateTimeOffset.Now.DayOfWeek));

app.Run();