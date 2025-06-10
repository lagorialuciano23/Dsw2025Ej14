namespace Dsw2025Ej14.Api.Domain
{
    public interface IPersistencia
    {
        public Product GetProduct(String sku);
        public IEnumerable<Product> GetProducts();
    }
}