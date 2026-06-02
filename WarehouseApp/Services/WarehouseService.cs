using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool UpdateProduct(Product updatedProduct)
        {
            Product? product = FindProductById(updatedProduct.Id);

            if (product == null)
                return false;

            product.Name = updatedProduct.Name;
            product.Unit = updatedProduct.Unit;
            product.Price = updatedProduct.Price;
            product.Quantity = updatedProduct.Quantity;
            product.LastDeliveryDate = updatedProduct.LastDeliveryDate;

            return true;
        }

        public List<Product> SearchProducts(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return Products;

            searchText = searchText.ToLower();

            return Products
                .Where(p => p.Name.ToLower().Contains(searchText))
                .ToList();
        }

        public bool ReceiveProduct(int id, int quantity)
        {
            Product? product = FindProductById(id);

            if (product == null || quantity <= 0)
                return false;

            product.Quantity += quantity;
            product.LastDeliveryDate = DateTime.Now;

            Invoices.Add(new Invoice
            {
                Id = Invoices.Count + 1,
                Type = "Надходження",
                Date = DateTime.Now,
                ProductName = product.Name,
                Quantity = quantity,
                Comment = ""
            });

            return true;
        }

        public bool ShipProduct(int id, int quantity)
        {
            Product? product = FindProductById(id);

            if (product == null || quantity <= 0)
                return false;

            if (product.Quantity < quantity)
                return false;

            product.Quantity -= quantity;

            Invoices.Add(new Invoice
            {
                Id = Invoices.Count + 1,
                Type = "Відвантаження",
                Date = DateTime.Now,
                ProductName = product.Name,
                Quantity = quantity,
                Comment = ""
            });

            return true;
        }
    }
}