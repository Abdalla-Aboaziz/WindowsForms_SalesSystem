
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            label6 = new Label();
            label7 = new Label();
            DtpFromDate = new DateTimePicker();
            DtpToDate = new DateTimePicker();
            btnsearch1 = new Button();
            btnsearch2 = new Button();
            label3 = new Label();
            StockType = new Label();
            txtOrderID = new TextBox();
            cbStockName = new ComboBox();
            button1 = new Button();
            label4 = new Label();
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
            label1.Size = new Size(167, 42);
            label1.TabIndex = 0;
            label1.Text = "حركات الخزائن ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 48);
            panel2.Controls.Add(label4);
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Droid Arabic Kufi", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(302, 16);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 21;
            label5.Text = "إجمالي الاموال :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(1190, 80);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle4.Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSaleOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSaleOrder.ColumnHeadersHeight = 40;
            dgvSaleOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, SalePrice });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle5.Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(4, 150, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvSaleOrder.DefaultCellStyle = dataGridViewCellStyle5;
            dgvSaleOrder.EnableHeadersVisualStyles = false;
            dgvSaleOrder.GridColor = Color.FromArgb(70, 70, 75);
            dgvSaleOrder.Location = new Point(12, 280);
            dgvSaleOrder.Name = "dgvSaleOrder";
            dgvSaleOrder.ReadOnly = true;
            dgvSaleOrder.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle6.Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(4, 150, 255);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvSaleOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvSaleOrder.RowHeadersVisible = false;
            dgvSaleOrder.RowHeadersWidth = 51;
            dgvSaleOrder.RowTemplate.Height = 40;
            dgvSaleOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleOrder.Size = new Size(1348, 517);
            dgvSaleOrder.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Name";
            Column1.HeaderText = "اسم الخزنة ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "SType";
            Column2.HeaderText = "نوع الحركة";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TotalMoney";
            Column5.HeaderText = "المبلغ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Date";
            Column3.HeaderText = "التاريخ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // SalePrice
            // 
            SalePrice.DataPropertyName = "OrderID";
            SalePrice.HeaderText = "رقم الفاتورة ";
            SalePrice.MinimumWidth = 6;
            SalePrice.Name = "SalePrice";
            SalePrice.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(1033, 80);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 23;
            label6.Text = "من تاريخ  : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(663, 80);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 25;
            label7.Text = "الي تاريخ  :";
            // 
            // DtpFromDate
            // 
            DtpFromDate.CalendarForeColor = Color.White;
            DtpFromDate.CalendarMonthBackground = Color.FromArgb(60, 60, 65);
            DtpFromDate.Format = DateTimePickerFormat.Short;
            DtpFromDate.Location = new Point(871, 108);
            DtpFromDate.Name = "DtpFromDate";
            DtpFromDate.Size = new Size(237, 27);
            DtpFromDate.TabIndex = 26;
            // 
            // DtpToDate
            // 
            DtpToDate.CalendarForeColor = Color.White;
            DtpToDate.CalendarMonthBackground = Color.FromArgb(60, 60, 65);
            DtpToDate.Format = DateTimePickerFormat.Short;
            DtpToDate.Location = new Point(443, 108);
            DtpToDate.Name = "DtpToDate";
            DtpToDate.Size = new Size(280, 27);
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
            btnsearch1.Location = new Point(1161, 109);
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
            btnsearch2.Location = new Point(1161, 162);
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
            label3.Location = new Point(1036, 144);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 32;
            label3.Text = "رقم الفاتورة ";
            // 
            // StockType
            // 
            StockType.AutoSize = true;
            StockType.ForeColor = Color.LightGray;
            StockType.Location = new Point(1046, 211);
            StockType.Name = "StockType";
            StockType.Size = new Size(62, 21);
            StockType.TabIndex = 34;
            StockType.Text = "نوع الحركة ";
            // 
            // txtOrderID
            // 
            txtOrderID.BackColor = Color.FromArgb(60, 60, 65);
            txtOrderID.BorderStyle = BorderStyle.FixedSingle;
            txtOrderID.Enabled = false;
            txtOrderID.ForeColor = Color.White;
            txtOrderID.Location = new Point(871, 168);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(237, 27);
            txtOrderID.TabIndex = 2;
            // 
            // cbStockName
            // 
            cbStockName.BackColor = Color.FromArgb(60, 60, 65);
            cbStockName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStockName.FlatStyle = FlatStyle.Flat;
            cbStockName.ForeColor = Color.White;
            cbStockName.FormattingEnabled = true;
            cbStockName.Location = new Point(871, 235);
            cbStockName.Name = "cbStockName";
            cbStockName.Size = new Size(237, 27);
            cbStockName.TabIndex = 36;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 167, 69);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Droid Arabic Kufi", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1161, 230);
            button1.Name = "button1";
            button1.Size = new Size(119, 32);
            button1.TabIndex = 37;
            button1.Text = "بحث";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Droid Arabic Kufi", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(519, 18);
            label4.Name = "label4";
            label4.Size = new Size(457, 21);
            label4.TabIndex = 22;
            label4.Text = "نظام ادارة المبيعات  |Abdalla Aboaziz |abdallaaboaziz@gmail.com";
            // 
            // FrmStockDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1372, 877);
            Controls.Add(button1);
            Controls.Add(cbStockName);
            Controls.Add(StockType);
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
        private DateTimePicker DtpToDate;
        private Button btnsearch1;
        private Button btnsearch2;
        private Label label3;
        private Label StockType;
        private TextBox txtOrderID;
        private ComboBox cbStockName;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn SalePrice;
        private Button button1;
        private Label label4;
    }
}