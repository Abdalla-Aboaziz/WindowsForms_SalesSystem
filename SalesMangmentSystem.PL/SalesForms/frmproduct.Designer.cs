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
            panel1.BackColor = Color.DarkSlateGray;
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
            label1.ForeColor = Color.White;
            label1.Location = new Point(588, 30);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "شاشةالاصناف  ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 827);
            panel2.Name = "panel2";
            panel2.Size = new Size(1372, 50);
            panel2.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(855, 142);
            txtID.Name = "txtID";
            txtID.Size = new Size(250, 27);
            txtID.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(532, 142);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1014, 114);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "رقم الصنف ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(710, 119);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "اسم الصنف";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateGray;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(432, 534);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(783, 418);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "اضافة ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.DarkSlateGray;
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(77, 418);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(114, 50);
            btnDeleteAll.TabIndex = 8;
            btnDeleteAll.Text = "حذف الجميع ";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateGray;
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
            btnUpdate.BackColor = Color.DarkSlateGray;
            btnUpdate.ForeColor = Color.White;
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
            btnNew.BackColor = Color.DarkSlateGray;
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
            txtSearch.Location = new Point(532, 534);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(365, 27);
            txtSearch.TabIndex = 12;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.BackgroundColor = Color.MistyRose;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column5, Column6, Column2 });
            dgvProduct.Location = new Point(0, 572);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
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
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Quantity";
            Column3.HeaderText = "الكمية ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SalePrice";
            Column4.HeaderText = "سعر الشراء ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "BuyPrice";
            Column5.HeaderText = "سعر البيع ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "CategoryID";
            Column6.HeaderText = "المجموعة";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "اسم الصنف";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // nudSalePrice
            // 
            nudSalePrice.Location = new Point(855, 229);
            nudSalePrice.Name = "nudSalePrice";
            nudSalePrice.Size = new Size(250, 27);
            nudSalePrice.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1033, 206);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 19;
            label4.Text = "سعر البيع ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(710, 206);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 21;
            label5.Text = "سعر الشراء ";
            // 
            // nudBuyPrice
            // 
            nudBuyPrice.Location = new Point(532, 229);
            nudBuyPrice.Name = "nudBuyPrice";
            nudBuyPrice.Size = new Size(250, 27);
            nudBuyPrice.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 119);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 23;
            label6.Text = "الكمية ";
            // 
            // nudQuentity
            // 
            nudQuentity.Location = new Point(209, 142);
            nudQuentity.Name = "nudQuentity";
            nudQuentity.Size = new Size(250, 27);
            nudQuentity.TabIndex = 22;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(209, 228);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(250, 28);
            cbCategory.TabIndex = 24;
            cbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 206);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 25;
            label7.Text = "المجموعة ";
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
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
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmProduct";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشاة الاصناف ";
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