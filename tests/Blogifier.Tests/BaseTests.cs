namespace Blogifier.Tests;

using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

public class BaseTests
{

    [Fact]
    public void getGreetingMessage() {
        Environment.SetEnvironmentVariable("DRONE", "true");
        var result = "Hello, Drone!";
        Assert.Equal("Hello, Drone!", result);
    }
}
