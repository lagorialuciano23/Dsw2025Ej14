using Dsw2025Ej14.Api.Domain;
using System.Text.Json;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria : IPersistencia
    {
        private List<Product> _products = [];

        public PersistenciaEnMemoria()
        {
            LoadProducts();
        }

        public Product GetProduct(string sku)
        {
            return _products.FirstOrDefault(p => p.sku.Equals(sku, StringComparison.OrdinalIgnoreCase) && p.IsActive);
        }


        public IEnumerable<Product> GetProducts()
        {
            return _products.Where(p => p.IsActive);
        }

        public  void LoadProducts()
        {
            try
            {
                var json = File.ReadAllText("products.json");
                _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                }) ?? [];
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error loading products: {ex.Message}");
                _products = new List<Product>();
            }
        }

    }
}
