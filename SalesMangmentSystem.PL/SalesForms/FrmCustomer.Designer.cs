namespace SalesMangmentSystem.PL.SalesForms
{
    partial class FrmCustomer
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
            dgvCustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            txtphonenumber = new TextBox();
            textBox2 = new TextBox();
            txtdateofbirth = new DateTimePicker();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 48);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1375, 78);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Droid Arabic Kufi", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 150, 255);
            label1.Location = new Point(588, 18);
            label1.Name = "label1";
            label1.Size = new Size(179, 52);
            label1.TabIndex = 0;
            label1.Text = "ادارة العملاء";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 48);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 827);
            panel2.Name = "panel2";
            panel2.Size = new Size(1375, 50);
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
            txtID.Size = new Size(250, 32);
            txtID.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(60, 60, 65);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(532, 142);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 32);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(1029, 114);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 4;
            label2.Text = "رقم العميل ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(700, 114);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 5;
            label3.Text = "اسم العميل ";
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
            txtSearch.Size = new Size(365, 32);
            txtSearch.TabIndex = 12;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvCustomer.BorderStyle = BorderStyle.None;
            dgvCustomer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomer.ColumnHeadersHeight = 40;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, DateOfBirth });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(4, 150, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.GridColor = Color.FromArgb(70, 70, 75);
            dgvCustomer.Location = new Point(0, 582);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle3.Font = new Font("Droid Arabic Kufi", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(4, 150, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 40;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(1372, 242);
            dgvCustomer.TabIndex = 13;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            dgvCustomer.CellMouseClick += dgvCustomer_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "رقم العميل ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "اسم العميل ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Phone";
            Column3.HeaderText = "رقم الهاتف";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Address";
            Column4.HeaderText = "العنوان";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            DateOfBirth.DataPropertyName = "BirthData";
            DateOfBirth.HeaderText = "تاريخ الميلاد";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(381, 114);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 23;
            label6.Text = "رقم الهاتف";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(381, 233);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 25;
            label7.Text = "تاريخ الميلاد";
            label7.Click += label7_Click;
            // 
            // txtphonenumber
            // 
            txtphonenumber.BackColor = Color.FromArgb(60, 60, 65);
            txtphonenumber.BorderStyle = BorderStyle.FixedSingle;
            txtphonenumber.ForeColor = Color.White;
            txtphonenumber.Location = new Point(209, 142);
            txtphonenumber.Name = "txtphonenumber";
            txtphonenumber.Size = new Size(250, 32);
            txtphonenumber.TabIndex = 27;
            txtphonenumber.TextChanged += textBox2_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(60, 60, 65);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(532, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(573, 32);
            textBox2.TabIndex = 29;
            // 
            // txtdateofbirth
            // 
            txtdateofbirth.CalendarMonthBackground = SystemColors.ControlLightLight;
            txtdateofbirth.Format = DateTimePickerFormat.Short;
            txtdateofbirth.Location = new Point(210, 261);
            txtdateofbirth.Name = "txtdateofbirth";
            txtdateofbirth.Size = new Size(250, 32);
            txtdateofbirth.TabIndex = 30;
            txtdateofbirth.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(1016, 233);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 31;
            label4.Text = "عنوان العميل ";
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1375, 877);
            Controls.Add(label4);
            Controls.Add(txtdateofbirth);
            Controls.Add(textBox2);
            Controls.Add(txtphonenumber);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvCustomer);
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
            Name = "FrmCustomer";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة الأصناف";
            Load += FrmCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
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
        private DataGridView dgvCustomer;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn DateOfBirth;
        private TextBox txtphonenumber;
        private TextBox textBox2;
        private DateTimePicker txtdateofbirth;
        private Label label4;
    }
}