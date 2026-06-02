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
            Product.Name = txtName.Text;
            Product.Unit = txtUnit.Text;
            Product.Price = decimal.Parse(txtPrice.Text);
            Product.Quantity = int.Parse(txtQuantity.Text);
            Product.LastDeliveryDate = dtpDeliveryDate.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
