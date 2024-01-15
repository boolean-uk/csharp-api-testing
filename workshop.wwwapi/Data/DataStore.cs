using workshop.wwwapi.models;

namespace workshop.wwwapi.Data
{
    public class DataStore
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(1, "Boolean Duck", 100),
            new Product(2, "Boolean Hoodie", 100),
            new Product(3, "Boolean Mouse Mat", 100),
            new Product(4, "Boolean Coffee", 100),
            new Product(5, "Boolean Energy Drink", 501000)
        };
    }
}
