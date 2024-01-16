using workshop.wwwapi.Data;
using workshop.wwwapi.models;

namespace workshop.wwwapi.Repository
{
    public class Repository : IRepository
    {
        private DatabaseContext _db;
        public Repository(DatabaseContext db)
        {
            _db = db;
        }
        public IEnumerable<Product> GetProducts()
        {
          
            
            return _db.Products;
        }
    }
}
