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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            nudQuntity = new NumericUpDown();
            label4 = new Label();
            label8 = new Label();
            cbStockType = new ComboBox();
            label9 = new Label();
            cbStockName = new ComboBox();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuntity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 48);
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
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(32, 14);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 50);
            btnSave.TabIndex = 30;
            btnSave.Text = "حفظ الفاتورة";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Droid Arabic Kufi", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 150, 255);
            label1.Location = new Point(588, 18);
            label1.Name = "label1";
            label1.Size = new Size(183, 42);
            label1.TabIndex = 0;
            label1.Text = "شاشة المبيعات ";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 48);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(nudTotalInvoice);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 817);
            panel2.Name = "panel2";
            panel2.Size = new Size(1372, 60);
            panel2.TabIndex = 1;
            // 
            // nudTotalInvoice
            // 
            nudTotalInvoice.BackColor = Color.FromArgb(60, 60, 65);
            nudTotalInvoice.BorderStyle = BorderStyle.FixedSingle;
            nudTotalInvoice.DecimalPlaces = 2;
            nudTotalInvoice.Font = new Font("Droid Arabic Kufi", 11F, FontStyle.Bold);
            nudTotalInvoice.ForeColor = Color.FromArgb(4, 150, 255);
            nudTotalInvoice.Location = new Point(32, 11);
            nudTotalInvoice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudTotalInvoice.Name = "nudTotalInvoice";
            nudTotalInvoice.Size = new Size(250, 35);
            nudTotalInvoice.TabIndex = 20;
            nudTotalInvoice.TextAlign = HorizontalAlignment.Center;
            nudTotalInvoice.ValueChanged += nudTotalInvoice_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Droid Arabic Kufi", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(302, 16);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 21;
            label5.Text = "إجمالي الفاتورة :";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(60, 60, 65);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Enabled = false;
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(1050, 130);
            txtID.Name = "txtID";
            txtID.Size = new Size(220, 27);
            txtID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(1191, 102);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 4;
            label2.Text = "رقم الفاتورة ";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(4, 150, 255);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(193, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 45);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "إضافة صنف";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(43, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 45);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف صنف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvSaleOrder
            // 
            dgvSaleOrder.AllowUserToAddRows = false;
            dgvSaleOrder.AllowUserToDeleteRows = false;
            dgvSaleOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleOrder.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvSaleOrder.BorderStyle = BorderStyle.None;
            dgvSaleOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSaleOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSaleOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSaleOrder.ColumnHeadersHeight = 40;
            dgvSaleOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(4, 150, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSaleOrder.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSaleOrder.EnableHeadersVisualStyles = false;
            dgvSaleOrder.GridColor = Color.FromArgb(70, 70, 75);
            dgvSaleOrder.Location = new Point(12, 280);
            dgvSaleOrder.Name = "dgvSaleOrder";
            dgvSaleOrder.ReadOnly = true;
            dgvSaleOrder.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle3.Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(4, 150, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSaleOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSaleOrder.RowHeadersVisible = false;
            dgvSaleOrder.RowHeadersWidth = 51;
            dgvSaleOrder.RowTemplate.Height = 40;
            dgvSaleOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleOrder.Size = new Size(1348, 517);
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
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ProductName";
            Column2.HeaderText = "اسم الصنف";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ProductPrice";
            Column5.HeaderText = "سعر البيع ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ProductQuantity";
            Column3.HeaderText = "الكمية ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ProductTotalPrice";
            Column4.HeaderText = "الاجمالي";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(276, 98);
            label6.Name = "label6";
            label6.Size = new Size(38, 21);
            label6.TabIndex = 23;
            label6.Text = "التاريخ";
            // 
            // cbCustomer
            // 
            cbCustomer.BackColor = Color.FromArgb(60, 60, 65);
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.FlatStyle = FlatStyle.Flat;
            cbCustomer.ForeColor = Color.White;
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(398, 129);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(280, 27);
            cbCustomer.TabIndex = 24;
            cbCustomer.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(628, 101);
            label7.Name = "label7";
            label7.Size = new Size(42, 21);
            label7.TabIndex = 25;
            label7.Text = "العميل";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(60, 60, 65);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(43, 126);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(280, 27);
            dateTimePicker1.TabIndex = 26;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.FromArgb(60, 60, 65);
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.ForeColor = Color.White;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(850, 222);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(420, 27);
            cbCategory.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(1210, 194);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 28;
            label3.Text = "الأصناف";
            // 
            // nudQuntity
            // 
            nudQuntity.BackColor = Color.FromArgb(60, 60, 65);
            nudQuntity.BorderStyle = BorderStyle.FixedSingle;
            nudQuntity.ForeColor = Color.White;
            nudQuntity.Location = new Point(716, 222);
            nudQuntity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuntity.Name = "nudQuntity";
            nudQuntity.Size = new Size(111, 27);
            nudQuntity.TabIndex = 29;
            nudQuntity.TextAlign = HorizontalAlignment.Center;
            nudQuntity.ValueChanged += nudCategoryCount_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(774, 194);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 30;
            label4.Text = "الكمية ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(914, 105);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 32;
            label8.Text = "نوع الفاتورة ";
            // 
            // cbStockType
            // 
            cbStockType.BackColor = Color.FromArgb(60, 60, 65);
            cbStockType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStockType.FlatStyle = FlatStyle.Flat;
            cbStockType.ForeColor = Color.White;
            cbStockType.FormattingEnabled = true;
            cbStockType.Location = new Point(716, 133);
            cbStockType.Name = "cbStockType";
            cbStockType.Size = new Size(280, 27);
            cbStockType.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(596, 190);
            label9.Name = "label9";
            label9.Size = new Size(64, 21);
            label9.TabIndex = 34;
            label9.Text = "اسم الخزنة ";
            // 
            // cbStockName
            // 
            cbStockName.BackColor = Color.FromArgb(60, 60, 65);
            cbStockName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStockName.FlatStyle = FlatStyle.Flat;
            cbStockName.ForeColor = Color.White;
            cbStockName.FormattingEnabled = true;
            cbStockName.Location = new Point(398, 218);
            cbStockName.Name = "cbStockName";
            cbStockName.Size = new Size(280, 27);
            cbStockName.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Droid Arabic Kufi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(527, 18);
            label10.Name = "label10";
            label10.Size = new Size(457, 21);
            label10.TabIndex = 23;
            label10.Text = "نظام ادارة المبيعات  |Abdalla Aboaziz |abdallaaboaziz@gmail.com";
            // 
            // FrmSaleOrdercs
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1372, 877);
            Controls.Add(label9);
            Controls.Add(cbStockName);
            Controls.Add(label8);
            Controls.Add(cbStockType);
            Controls.Add(label4);
            Controls.Add(nudQuntity);
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
            Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmSaleOrdercs";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة المبيعات";
            Load += FrmSaleOrdercs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuntity).EndInit();
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
        private NumericUpDown nudQuntity;
        private Button btnSave;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label4;
        private Label label8;
        private ComboBox cbStockType;
        private Label label9;
        private ComboBox cbStockName;
        private Label label10;
    }
}