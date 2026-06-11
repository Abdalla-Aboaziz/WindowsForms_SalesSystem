namespace SalesMangmentSystem.PL.SalesForms
{
    partial class FrmProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtID = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSearch = new Button();
            btnAdd = new Button();
            btnDeleteAll = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            txtSearch = new TextBox();
            dgvProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            nudSalePrice = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            nudBuyPrice = new NumericUpDown();
            label6 = new Label();
            nudQuentity = new NumericUpDown();
            cbCategory = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBuyPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuentity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 48);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1372, 78);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Droid Arabic Kufi", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 150, 255);
            label1.Location = new Point(588, 18);
            label1.Name = "label1";
            label1.Size = new Size(168, 42);
            label1.TabIndex = 0;
            label1.Text = "شاشة الأصناف";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 48);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 827);
            panel2.Name = "panel2";
            panel2.Size = new Size(1372, 50);
            panel2.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(60, 60, 65);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Enabled = false;
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(855, 142);
            txtID.Name = "txtID";
            txtID.Size = new Size(250, 27);
            txtID.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(60, 60, 65);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(532, 142);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(1029, 114);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 4;
            label2.Text = "رقم الصنف ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(700, 114);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 5;
            label3.Text = "اسم الصنف";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(4, 150, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(432, 534);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 33);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(4, 150, 255);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(783, 418);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "إضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.FromArgb(220, 53, 69);
            btnDeleteAll.Cursor = Cursors.Hand;
            btnDeleteAll.FlatAppearance.BorderSize = 0;
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(77, 418);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(128, 50);
            btnDeleteAll.TabIndex = 8;
            btnDeleteAll.Text = "حذف الجميع";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(357, 418);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 50);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 193, 7);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(567, 418);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 50);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(40, 167, 69);
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(1014, 418);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(114, 50);
            btnNew.TabIndex = 11;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(60, 60, 65);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(532, 534);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(365, 27);
            txtSearch.TabIndex = 12;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvProduct.BorderStyle = BorderStyle.None;
            dgvProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeight = 40;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column5, Column6, Column2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(4, 150, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.GridColor = Color.FromArgb(70, 70, 75);
            dgvProduct.Location = new Point(0, 582);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle3.Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(4, 150, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 40;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(1372, 242);
            dgvProduct.TabIndex = 13;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            dgvProduct.CellMouseClick += dgvProduct_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "رقم الصنف";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Quantity";
            Column3.HeaderText = "الكمية ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SalePrice";
            Column4.HeaderText = "سعر الشراء ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "BuyPrice";
            Column5.HeaderText = "سعر البيع ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "CategoryID";
            Column6.HeaderText = "المجموعة";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "اسم الصنف";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // nudSalePrice
            // 
            nudSalePrice.BackColor = Color.FromArgb(60, 60, 65);
            nudSalePrice.BorderStyle = BorderStyle.FixedSingle;
            nudSalePrice.ForeColor = Color.White;
            nudSalePrice.Location = new Point(855, 229);
            nudSalePrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudSalePrice.Name = "nudSalePrice";
            nudSalePrice.Size = new Size(250, 27);
            nudSalePrice.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(1039, 201);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 19;
            label4.Text = "سعر البيع ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(700, 201);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 21;
            label5.Text = "سعر الشراء ";
            // 
            // nudBuyPrice
            // 
            nudBuyPrice.BackColor = Color.FromArgb(60, 60, 65);
            nudBuyPrice.BorderStyle = BorderStyle.FixedSingle;
            nudBuyPrice.ForeColor = Color.White;
            nudBuyPrice.Location = new Point(532, 229);
            nudBuyPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudBuyPrice.Name = "nudBuyPrice";
            nudBuyPrice.Size = new Size(250, 27);
            nudBuyPrice.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(408, 114);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 23;
            label6.Text = "الكمية ";
            // 
            // nudQuentity
            // 
            nudQuentity.BackColor = Color.FromArgb(60, 60, 65);
            nudQuentity.BorderStyle = BorderStyle.FixedSingle;
            nudQuentity.ForeColor = Color.White;
            nudQuentity.Location = new Point(209, 142);
            nudQuentity.Name = "nudQuentity";
            nudQuentity.Size = new Size(250, 27);
            nudQuentity.TabIndex = 22;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.FromArgb(60, 60, 65);
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.ForeColor = Color.White;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(209, 228);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(250, 27);
            cbCategory.TabIndex = 24;
            cbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(386, 201);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 25;
            label7.Text = "المجموعة ";
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1372, 877);
            Controls.Add(label7);
            Controls.Add(cbCategory);
            Controls.Add(label6);
            Controls.Add(nudQuentity);
            Controls.Add(label5);
            Controls.Add(nudBuyPrice);
            Controls.Add(label4);
            Controls.Add(nudSalePrice);
            Controls.Add(dgvProduct);
            Controls.Add(txtSearch);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmProduct";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة الأصناف";
            Load += FrmProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBuyPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuentity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtID;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnDeleteAll;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private TextBox txtSearch;
        private DataGridView dgvProduct;
        private NumericUpDown nudSalePrice;
        private Label label4;
        private Label label5;
        private NumericUpDown nudBuyPrice;
        private Label label6;
        private NumericUpDown nudQuentity;
        private ComboBox cbCategory;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
    }
}