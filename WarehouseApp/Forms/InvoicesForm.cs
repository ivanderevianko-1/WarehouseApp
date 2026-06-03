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
    public partial class InvoicesForm : Form
    {
        public InvoicesForm(List<Invoice> invoices)
        {
            InitializeComponent();


            dgvInvoices.DataSource = null;
            dgvInvoices.DataSource = invoices;

            dgvInvoices.Columns["Id"].HeaderText = "Код";
            dgvInvoices.Columns["Type"].HeaderText = "Тип";
            dgvInvoices.Columns["Date"].HeaderText = "Дата";
            dgvInvoices.Columns["ProductName"].HeaderText = "Товар";
            dgvInvoices.Columns["Quantity"].HeaderText = "Кількість";
            dgvInvoices.Columns["Comment"].Visible = false;
        }
        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
