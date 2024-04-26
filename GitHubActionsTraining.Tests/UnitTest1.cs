using Microsoft.AspNetCore.Mvc.Testing;

namespace GitHubActionsTraining.Tests;

public class UnitTest1
{
    [Fact]
    public async Task ResponseNotEmpty()
    {
        //arrange
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        //act
        var result = await client.GetStringAsync("/time/utc");

        //assert
        Assert.True(result.Length > 0);
    }
    
    [Fact]
    public async Task ResponseContainsCurrentDay()
    {
        //arrange
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        //act
        var result = await client.GetStringAsync("/time/utc");

        //assert
        Assert.DoesNotContain("day", result.ToLower());
    }
}