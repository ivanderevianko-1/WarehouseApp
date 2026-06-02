namespace WarehouseApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnReceive = new Button();
            btnShip = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(279, 57);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(832, 576);
            dgvProducts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Пошук:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 57);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(227, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 190);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 31);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 259);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 31);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReceive
            // 
            btnReceive.Location = new Point(12, 334);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(125, 31);
            btnReceive.TabIndex = 7;
            btnReceive.Text = "Надходження";
            btnReceive.UseVisualStyleBackColor = true;
            // 
            // btnShip
            // 
            btnShip.Location = new Point(12, 414);
            btnShip.Name = "btnShip";
            btnShip.Size = new Size(125, 31);
            btnShip.TabIndex = 8;
            btnShip.Text = "Відвантаження";
            btnShip.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 490);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 31);
            btnSave.TabIndex = 9;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 667);
            Controls.Add(btnSave);
            Controls.Add(btnShip);
            Controls.Add(btnReceive);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Name = "MainForm";
            Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Label label1;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnReceive;
        private Button btnShip;
        private Button btnSave;
    }
}
