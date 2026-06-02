using System;
using System.Windows.Forms;
using WarehouseApp.Models;
using WarehouseApp.Services;
using WarehouseApp.Forms;


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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource =
                warehouseService.SearchProducts(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                Product product = form.Product;

                product.Id = warehouseService.Products.Count + 1;

                warehouseService.AddProduct(product);

                RefreshProductsGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
                return;

            Product? product = dgvProducts.CurrentRow.DataBoundItem as Product;

            if (product == null)
                return;

            warehouseService.RemoveProduct(product.Id);

            RefreshProductsGrid();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = warehouseService.SearchProducts(txtSearch.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
                return;

            Product? product =
                dgvProducts.CurrentRow.DataBoundItem as Product;

            if (product == null)
                return;

            ProductForm form = new ProductForm(product);

            if (form.ShowDialog() == DialogResult.OK)
            {
                warehouseService.UpdateProduct(form.Product);

                RefreshProductsGrid();
            }
        }
    }
}

