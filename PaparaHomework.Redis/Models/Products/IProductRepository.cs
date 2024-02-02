namespace PaparaHomework.Redis.Models.Products
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}
