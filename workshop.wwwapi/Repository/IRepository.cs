using workshop.wwwapi.models;

namespace workshop.wwwapi.Repository
{
    public interface IRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
