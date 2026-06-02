using WarehouseApp.Models;
using WarehouseApp.Services;

namespace WarehouseApp
{
    public partial class MainForm : Form
    {
        private WarehouseService warehouseService;

        public MainForm()
        {
            InitializeComponent();

            warehouseService = new WarehouseService();

            LoadTestData();
            RefreshProductsGrid();
        }

        private void LoadTestData()
        {
            warehouseService.AddProduct(new Product
            {
                Id = 1,
                Name = "Ноутбук",
                Unit = "шт",
                Price = 25000,
                Quantity = 10,
                LastDeliveryDate = DateTime.Now
            });

            warehouseService.AddProduct(new Product
            {
                Id = 2,
                Name = "Миша",
                Unit = "шт",
                Price = 500,
                Quantity = 50,
                LastDeliveryDate = DateTime.Now
            });

            warehouseService.AddProduct(new Product
            {
                Id = 3,
                Name = "Клавіатура",
                Unit = "шт",
                Price = 1200,
                Quantity = 25,
                LastDeliveryDate = DateTime.Now
            });
        }

        private void RefreshProductsGrid()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = warehouseService.Products;
        }
    }
}
