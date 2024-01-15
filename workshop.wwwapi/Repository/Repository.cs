using workshop.wwwapi.Data;
using workshop.wwwapi.models;

namespace workshop.wwwapi.Repository
{
    public class Repository : IRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            return DataStore.Products;
        }
    }
}
