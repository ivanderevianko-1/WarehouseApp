using WarehouseApp.Models;

namespace WarehouseApp.Services
{
    public class WarehouseService
    {
        public List<Product> Products { get; set; }

        public List<Invoice> Invoices { get; set; }

        public WarehouseService()
        {
            Products = new List<Product>();
            Invoices = new List<Invoice>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int id)
        {
            Product? product = FindProductById(id);

            if (product == null)
                return false;

            Products.Remove(product);
            return true;
        }

        public Product? FindProductById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }
    }
}