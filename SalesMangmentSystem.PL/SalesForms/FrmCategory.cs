using SalesMangmentSystem.BLL.Services;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesMangmentSystem.PL.SalesForms
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidationInputs()) { return; }
            Category category = new Category
            {

                Name = txtName.Text
            };

            bool isAdded = CategoryService.AddCategory(category);
            if (isAdded)
            {
                MessageBox.Show("تمت إضافة المجموعة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في إضافة المجموعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            List<Category> categories = CategoryService.GetAllCategorys();
            dgvCategory.DataSource = categories;
        }


        private void FrmCategory_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            LoadCategories();
        }

        private void dgvCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisableWhenEditorDelete();
            txtID.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisableWhenEditorDelete();
            if (!ValidationInputs()) { return; }

            bool isUpdated = CategoryService.UpdateCategory(new Category
            {
                ID = int.Parse(txtID.Text),
                Name = txtName.Text
            });

            if (isUpdated)
            {
                MessageBox.Show("تم تعديل  المجموعة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في تعديل المجموعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCategories();


        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DisableWhenEditorDelete();
            if (!ValidationInputs()) { return; }

            if (MessageBox.Show("هل أنت متأكد من حذف هذه المجموعة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            bool isDeleted = CategoryService.DeleteCategory(int.Parse(txtID.Text));
            if (isDeleted)
            {
                MessageBox.Show("تم حذف المجموعة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في حذف المجموعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCategories();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisableWhenEditorDelete();
            if (MessageBox.Show("هل أنت متأكد من حذف جميع المحموعات ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            bool isAllDeleted = CategoryService.DeleteAllCategory();
            if (isAllDeleted)
            {
                MessageBox.Show("تم حذف جميع المجموعات بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في حذف جميع المجموعات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCategories();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Category> categories = CategoryService.GetAllCategorysbyPattern(txtSearch.Text);
            dgvCategory.DataSource = categories;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = string.Empty;
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }

        #region  Helper Methods

        private void LoadCategories()
        {
            List<Category> categories = CategoryService.GetAllCategorys();
            dgvCategory.DataSource = categories;
        }
        private bool ValidationInputs()
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم المجموعة ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void DisableWhenEditorDelete()
        {
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
        }

        #endregion


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
