using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using System.Reflection;
using workshop.wwwapi.models;

namespace workshop.nunit;

public class ProductsTests
{
    [Test]
    public async Task ProductEndpointStatus()
    {
        // Arrange
        var factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder => { });
        var client = factory.CreateClient();
       
        // Act
        var response = await client.GetAsync("/products");
      
        // Assert
        Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
    }
    [Test]
    public async Task When_GetProducts_Then_ResponseShouldBeExpectedProducts()
    {
        // Arrange
        var factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder => { });
        var client = factory.CreateClient();
        var data = this.ReadFromFile("expected.json");
        var expected = JsonConvert.DeserializeObject<Product[]>(data);

        // Act
        var response = await client.GetAsync("/products");
        var actual = JsonConvert.DeserializeObject<Product[]>(await response.Content.ReadAsStringAsync());

        // Assert
        Assert.IsTrue(response.StatusCode==System.Net.HttpStatusCode.OK);
    }

    public string ReadFromFile(string fileName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        using (var stream = assembly.GetManifestResourceStream($"workshop.nunit.{fileName}"))
        using (var reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }
    }
}