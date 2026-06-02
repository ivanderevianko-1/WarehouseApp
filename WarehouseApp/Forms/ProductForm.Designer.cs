namespace WarehouseApp.Forms
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtUnit = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            dtpDeliveryDate = new DateTimePicker();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 60);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Одиниця:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 103);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Ціна:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 143);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Кількість:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 204);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 4;
            label5.Text = "Дата надходження:";
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 18);
            txtName.Name = "txtName";
            txtName.Size = new Size(408, 27);
            txtName.TabIndex = 5;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(127, 57);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(408, 27);
            txtUnit.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(127, 103);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(408, 27);
            txtPrice.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(127, 140);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(408, 27);
            txtQuantity.TabIndex = 8;
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Location = new Point(204, 204);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new Size(298, 27);
            dtpDeliveryDate.TabIndex = 9;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(155, 252);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 10;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(317, 252);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 304);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(dtpDeliveryDate);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtUnit);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Додавання товару";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtUnit;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private DateTimePicker dtpDeliveryDate;
        private Button btnOk;
        private Button btnCancel;
    }
}