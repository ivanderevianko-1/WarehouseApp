using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseApp.Forms
{
    public partial class TransactionForm : Form
    {
        public int Quantity { get; private set; }

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Введіть коректну кількість.");

                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Кількість повинна бути більшою за нуль.");

                return;
            }

            Quantity = quantity;

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
