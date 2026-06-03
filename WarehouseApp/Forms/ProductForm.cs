using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseApp.Models;


namespace WarehouseApp.Forms
{
    public partial class ProductForm : Form
    {
        public Product Product { get; private set; }

        public ProductForm()
        {
            InitializeComponent();

            Product = new Product();
        }

        public ProductForm(Product product)
        {
            InitializeComponent();

            Product = product;

            txtName.Text = product.Name;
            txtUnit.Text = product.Unit;
            txtPrice.Text = product.Price.ToString();
            txtQuantity.Text = product.Quantity.ToString();
            dtpDeliveryDate.Value = product.LastDeliveryDate;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Введіть назву товару.",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show(
                    "Введіть одиницю виміру.",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show(
                    "Ціна повинна бути більшою за 0.",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show(
                    "Кількість не може бути від'ємною.",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Product.Name = txtName.Text;
            Product.Unit = txtUnit.Text;
            Product.Price = price;
            Product.Quantity = quantity;
            Product.LastDeliveryDate = dtpDeliveryDate.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
