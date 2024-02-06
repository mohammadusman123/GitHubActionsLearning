using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/time/utc", () => Results.Ok(DateTimeOffset.Now));

app.Run();