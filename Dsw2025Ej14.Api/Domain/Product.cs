namespace Dsw2025Ej14.Api.Domain
{
    public class Product
    {
        private String Sku { get; set; }
        private String Name { get; set; }
        private decimal CurrentUnitPrice { get; set; }
        public bool IsActive { get; set; }

        public Product(string sku, string name, decimal currentUnitPrice, bool isActive)
        {
            Sku = sku;
            Name = name;
            CurrentUnitPrice = currentUnitPrice;
            IsActive = isActive;
        }
    }
}
