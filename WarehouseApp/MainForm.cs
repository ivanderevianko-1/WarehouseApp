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
        private FileService fileService;
        public MainForm()
        {
            InitializeComponent();

            warehouseService = new WarehouseService();
            fileService = new FileService();

            warehouseService.Products = fileService.LoadProducts();
            warehouseService.Invoices = fileService.LoadInvoices();

            if (warehouseService.Products.Count == 0)
            {
                LoadTestData();
            }

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
            dgvProducts.Columns["Id"].HeaderText = "Код";
dgvProducts.Columns["Name"].HeaderText = "Назва";
dgvProducts.Columns["Unit"].HeaderText = "Одиниця";
dgvProducts.Columns["Price"].HeaderText = "Ціна";
dgvProducts.Columns["Quantity"].HeaderText = "Кількість";
dgvProducts.Columns["LastDeliveryDate"].HeaderText = "Дата надходження";
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
            DialogResult result = MessageBox.Show(
                                                  "Ви дійсно бажаєте видалити цей товар?",
                                                  "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }
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

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
                return;

            Product? product =
                dgvProducts.CurrentRow.DataBoundItem as Product;

            if (product == null)
                return;

            TransactionForm form = new TransactionForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                warehouseService.ReceiveProduct(
                    product.Id,
                    form.Quantity);

                RefreshProductsGrid();
            }
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
                return;

            Product? product =
                dgvProducts.CurrentRow.DataBoundItem as Product;

            if (product == null)
                return;

            TransactionForm form = new TransactionForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                bool success = warehouseService.ShipProduct(
                    product.Id,
                    form.Quantity);

                if (!success)
                {
                    MessageBox.Show(
                        "Недостатньо товару на складі.",
                        "Помилка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                RefreshProductsGrid();
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fileService.SaveProducts(warehouseService.Products);
            fileService.SaveInvoices(warehouseService.Invoices);

            MessageBox.Show(
                "Дані успішно збережено!",
                "Збереження",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            InvoicesForm form = new InvoicesForm(warehouseService.Invoices);
            form.ShowDialog();
        }
    }
}

