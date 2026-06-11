namespace SalesMangmentSystem.PL.SalesForms
{
    partial class FrmStockDetails
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
            nudTotalInvoice = new NumericUpDown();
            label5 = new Label();
            label2 = new Label();
            dgvSaleOrder = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            DtpFromDate = new DateTimePicker();
            txtOrderID = new TextBox();
            DtpToDate = new DateTimePicker();
            btnsearch1 = new Button();
            btnsearch2 = new Button();
            label3 = new Label();
            txtSearchCustomer = new TextBox();
            label4 = new Label();
            cbByOrderID = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrder).BeginInit();
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
            label1.Size = new Size(206, 52);
            label1.TabIndex = 0;
            label1.Text = "حركات الخزائن ";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 48);
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
            nudTotalInvoice.Size = new Size(250, 42);
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
            label5.Size = new Size(171, 36);
            label5.TabIndex = 21;
            label5.Text = "إجمالي الفاتورة :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(1191, 102);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 4;
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
            dataGridViewCellStyle1.Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSaleOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSaleOrder.ColumnHeadersHeight = 40;
            dgvSaleOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, SalePrice, Column4 });
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
            Column1.DataPropertyName = "saleorderID";
            Column1.HeaderText = "رقم الفاتورة";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "CustomerName";
            Column2.HeaderText = "اسم العميل ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ProductName";
            Column5.HeaderText = "اسم الصنف";
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
            // SalePrice
            // 
            SalePrice.DataPropertyName = "ProductPrice";
            SalePrice.HeaderText = "سعر البيع ";
            SalePrice.MinimumWidth = 6;
            SalePrice.Name = "SalePrice";
            SalePrice.ReadOnly = true;
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
            label6.Location = new Point(1034, 102);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 23;
            label6.Text = "من تاريخ  : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(664, 102);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 25;
            label7.Text = "الي تاريخ  :";
            // 
            // DtpFromDate
            // 
            DtpFromDate.CalendarForeColor = Color.White;
            DtpFromDate.CalendarMonthBackground = Color.FromArgb(60, 60, 65);
            DtpFromDate.Format = DateTimePickerFormat.Short;
            DtpFromDate.Location = new Point(872, 130);
            DtpFromDate.Name = "DtpFromDate";
            DtpFromDate.Size = new Size(237, 32);
            DtpFromDate.TabIndex = 26;
            // 
            // txtOrderID
            // 
            txtOrderID.BackColor = Color.FromArgb(60, 60, 65);
            txtOrderID.BorderStyle = BorderStyle.FixedSingle;
            txtOrderID.Enabled = false;
            txtOrderID.ForeColor = Color.White;
            txtOrderID.Location = new Point(872, 230);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(237, 32);
            txtOrderID.TabIndex = 2;
            txtOrderID.TextChanged += txtOrderID_TextChanged;
            // 
            // DtpToDate
            // 
            DtpToDate.CalendarForeColor = Color.White;
            DtpToDate.CalendarMonthBackground = Color.FromArgb(60, 60, 65);
            DtpToDate.Format = DateTimePickerFormat.Short;
            DtpToDate.Location = new Point(390, 130);
            DtpToDate.Name = "DtpToDate";
            DtpToDate.Size = new Size(350, 32);
            DtpToDate.TabIndex = 29;
            // 
            // btnsearch1
            // 
            btnsearch1.BackColor = Color.FromArgb(40, 167, 69);
            btnsearch1.Cursor = Cursors.Hand;
            btnsearch1.FlatAppearance.BorderSize = 0;
            btnsearch1.FlatStyle = FlatStyle.Flat;
            btnsearch1.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            btnsearch1.ForeColor = Color.White;
            btnsearch1.Location = new Point(1162, 131);
            btnsearch1.Name = "btnsearch1";
            btnsearch1.Size = new Size(119, 32);
            btnsearch1.TabIndex = 30;
            btnsearch1.Text = "بحث";
            btnsearch1.UseVisualStyleBackColor = false;
            btnsearch1.Click += btnsearch1_Click;
            // 
            // btnsearch2
            // 
            btnsearch2.BackColor = Color.FromArgb(40, 167, 69);
            btnsearch2.Cursor = Cursors.Hand;
            btnsearch2.FlatAppearance.BorderSize = 0;
            btnsearch2.FlatStyle = FlatStyle.Flat;
            btnsearch2.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            btnsearch2.ForeColor = Color.White;
            btnsearch2.Location = new Point(1162, 230);
            btnsearch2.Name = "btnsearch2";
            btnsearch2.Size = new Size(119, 32);
            btnsearch2.TabIndex = 31;
            btnsearch2.Text = "بحث";
            btnsearch2.UseVisualStyleBackColor = false;
            btnsearch2.Click += btnsearch2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(1024, 202);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 32;
            label3.Text = "رقم الفاتورة ";
            label3.Click += label3_Click;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.BackColor = Color.FromArgb(60, 60, 65);
            txtSearchCustomer.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCustomer.Enabled = false;
            txtSearchCustomer.ForeColor = Color.White;
            txtSearchCustomer.Location = new Point(390, 230);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(350, 32);
            txtSearchCustomer.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(662, 202);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 34;
            label4.Text = "اسم العميل";
            label4.Click += label4_Click;
            // 
            // cbByOrderID
            // 
            cbByOrderID.AutoSize = true;
            cbByOrderID.BackColor = Color.Transparent;
            cbByOrderID.ForeColor = SystemColors.ButtonHighlight;
            cbByOrderID.Location = new Point(256, 230);
            cbByOrderID.Name = "cbByOrderID";
            cbByOrderID.Size = new Size(112, 29);
            cbByOrderID.TabIndex = 35;
            cbByOrderID.Text = "برقم الفاتورة ";
            cbByOrderID.UseVisualStyleBackColor = false;
            cbByOrderID.CheckedChanged += cbByOrderID_CheckedChanged;
            // 
            // FrmStockDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1372, 877);
            Controls.Add(cbByOrderID);
            Controls.Add(label4);
            Controls.Add(txtSearchCustomer);
            Controls.Add(label3);
            Controls.Add(btnsearch2);
            Controls.Add(btnsearch1);
            Controls.Add(DtpToDate);
            Controls.Add(DtpFromDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvSaleOrder);
            Controls.Add(label2);
            Controls.Add(txtOrderID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmStockDetails";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة المبيعات";
            Load += FrmStockDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaleOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private DataGridView dgvSaleOrder;
        private Label label5;
        private NumericUpDown nudTotalInvoice;
        private Label label6;
        private Label label7;
        private DateTimePicker DtpFromDate;
        private TextBox txtOrderID;
        private DateTimePicker DtpToDate;
        private Button btnsearch1;
        private Button btnsearch2;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtSearchCustomer;
        private Label label4;
        private CheckBox cbByOrderID;
    }
}