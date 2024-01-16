using workshop.wwwapi.models;

namespace workshop.wwwapi.Data
{
    public class Seeder
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(1, "Boolean Duck", 4),
            new Product(2, "Boolean Hoodie", 30),
            new Product(3, "Boolean Mouse Mat", 2),
            new Product(4, "Boolean Coffee Pack", 22),
            new Product(5, "Boolean Energy Drink Pack", 45)
        };
    }
}
