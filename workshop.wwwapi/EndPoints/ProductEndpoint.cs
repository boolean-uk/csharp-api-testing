using System.Runtime.CompilerServices;
using workshop.wwwapi.models;
using workshop.wwwapi.Repository;

namespace workshop.wwwapi.EndPoints
{
    public static class ProductEndpoint
    {
        
        public static void ConfigureProductEndpoint(this WebApplication app)
        {
            app.MapGet("/products", GetProducts);
        }
        public static async Task<IResult> GetProducts(IRepository repository)
        {
            IEnumerable<Product> payload = repository.GetProducts();

            return Results.Ok(payload);
        }
    }
}
