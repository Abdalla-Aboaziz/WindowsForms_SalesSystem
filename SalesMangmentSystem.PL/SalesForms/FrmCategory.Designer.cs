namespace SalesMangmentSystem.PL.SalesForms
{
    partial class FrmCategory
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
            dgvCategory = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1190, 97);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(535, 38);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "شاشة المجموعات ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 926);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1190, 73);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(950, 178);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(228, 32);
            txtID.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 178);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 32);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1058, 142);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "رقم المجموعة ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 142);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 5;
            label3.Text = "اسم المجموعة ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateGray;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(391, 396);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 36);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(836, 252);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 62);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "اضافة ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.DarkSlateGray;
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(68, 252);
            btnDeleteAll.Margin = new Padding(3, 4, 3, 4);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(104, 62);
            btnDeleteAll.TabIndex = 8;
            btnDeleteAll.Text = "حذف الجميع ";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(372, 252);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 62);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSlateGray;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(621, 252);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 62);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.DarkSlateGray;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(1074, 252);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(104, 62);
            btnNew.TabIndex = 11;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(482, 396);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(332, 32);
            txtSearch.TabIndex = 12;
            // 
            // dgvCategory
            // 
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.BackgroundColor = Color.MistyRose;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvCategory.Location = new Point(0, 362);
            dgvCategory.Margin = new Padding(3, 4, 3, 4);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(1190, 567);
            dgvCategory.TabIndex = 13;
            dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            dgvCategory.CellMouseClick += dgvCategory_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "رقم المجموعة ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "اسم المجموعة ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1190, 999);
            Controls.Add(dgvCategory);
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
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "FrmCategory";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة المجموعات ";
            Load += FrmCategory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
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
        private DataGridView dgvCategory;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}