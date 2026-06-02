using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using WarehouseApp.Models;

namespace WarehouseApp.Services
{
    public class FileService
    {
        private const string ProductsFile = "products.json";
        private const string InvoicesFile = "invoices.json";

        public void SaveProducts(List<Product> products)
        {
            string json = JsonSerializer.Serialize(products,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(ProductsFile, json);
        }

        public List<Product> LoadProducts()
        {
            if (!File.Exists(ProductsFile))
                return new List<Product>();

            string json = File.ReadAllText(ProductsFile);

            return JsonSerializer.Deserialize<List<Product>>(json)
                   ?? new List<Product>();
        }

        public void SaveInvoices(List<Invoice> invoices)
        {
            string json = JsonSerializer.Serialize(invoices,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(InvoicesFile, json);
        }

        public List<Invoice> LoadInvoices()
        {
            if (!File.Exists(InvoicesFile))
                return new List<Invoice>();

            string json = File.ReadAllText(InvoicesFile);

            return JsonSerializer.Deserialize<List<Invoice>>(json)
                   ?? new List<Invoice>();
        }
    }
}
