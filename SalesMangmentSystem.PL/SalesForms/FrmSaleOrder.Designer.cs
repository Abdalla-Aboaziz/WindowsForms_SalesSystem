namespace SalesMangmentSystem.PL.SalesForms
{
    partial class FrmSaleOrdercs
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
            btnSave = new Button();
            label1 = new Label();
            panel2 = new Panel();
            nudTotalInvoice = new NumericUpDown();
            label5 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvSaleOrder = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            cbCustomer = new ComboBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbCategory = new ComboBox();
            label3 = new Label();
            nudCategoryCount = new NumericUpDown();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCategoryCount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1372, 78);
            panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(32, 16);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 48);
            btnSave.TabIndex = 30;
            btnSave.Text = "حفظ الفاتورة ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(588, 30);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "شاشة المبيعات ";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(nudTotalInvoice);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 827);
            panel2.Name = "panel2";
            panel2.Size = new Size(1372, 50);
            panel2.TabIndex = 1;
            // 
            // nudTotalInvoice
            // 
            nudTotalInvoice.DecimalPlaces = 2;
            nudTotalInvoice.Location = new Point(12, 11);
            nudTotalInvoice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudTotalInvoice.Name = "nudTotalInvoice";
            nudTotalInvoice.Size = new Size(250, 27);
            nudTotalInvoice.TabIndex = 20;
            nudTotalInvoice.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(302, 13);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 21;
            label5.Text = "اجمالي الفاتورة ";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(1020, 139);
            txtID.Name = "txtID";
            txtID.Size = new Size(250, 27);
            txtID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1179, 111);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "رقم الفاتورة ";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(332, 538);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 28);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "اضافة ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(165, 538);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 28);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvSaleOrder
            // 
            dgvSaleOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleOrder.BackgroundColor = Color.MistyRose;
            dgvSaleOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, Column4 });
            dgvSaleOrder.Location = new Point(0, 572);
            dgvSaleOrder.Name = "dgvSaleOrder";
            dgvSaleOrder.RowHeadersWidth = 51;
            dgvSaleOrder.Size = new Size(1372, 242);
            dgvSaleOrder.TabIndex = 13;
            dgvSaleOrder.CellContentClick += dgvProduct_CellContentClick;
            dgvSaleOrder.CellMouseClick += dgvProduct_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ProductID";
            Column1.HeaderText = "رقم الصنف";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ProductName";
            Column2.HeaderText = "اسم الصنف";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ProductPrice";
            Column5.HeaderText = "سعر البيع ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ProductQuantity";
            Column3.HeaderText = "الكمية ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ProductTotalPrice";
            Column4.HeaderText = "الاجمالي";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(823, 113);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 23;
            label6.Text = "التاريخ";
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(228, 138);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(250, 28);
            cbCustomer.TabIndex = 24;
            cbCustomer.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 116);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 25;
            label7.Text = "العميل";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(619, 136);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 26;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(875, 538);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(434, 28);
            cbCategory.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1252, 515);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 28;
            label3.Text = "الاصناف";
            // 
            // nudCategoryCount
            // 
            nudCategoryCount.Location = new Point(619, 538);
            nudCategoryCount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCategoryCount.Name = "nudCategoryCount";
            nudCategoryCount.Size = new Size(250, 27);
            nudCategoryCount.TabIndex = 29;
            nudCategoryCount.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmSaleOrdercs
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1372, 877);
            Controls.Add(nudCategoryCount);
            Controls.Add(label3);
            Controls.Add(cbCategory);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(cbCustomer);
            Controls.Add(label6);
            Controls.Add(dgvSaleOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmSaleOrdercs";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشاة الاصناف ";
            Load += FrmSaleOrdercs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCategoryCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtID;
        private Label label2;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvSaleOrder;
        private Label label5;
        private NumericUpDown nudTotalInvoice;
        private Label label6;
        private ComboBox cbCustomer;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbCategory;
        private Label label3;
        private NumericUpDown nudCategoryCount;
        private Button btnSave;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}