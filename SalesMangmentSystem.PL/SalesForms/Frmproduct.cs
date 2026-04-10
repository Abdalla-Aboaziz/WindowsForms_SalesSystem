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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidationInputs()) { return; }
            Product Product = new Product
            {
                BuyPrice = (double)nudBuyPrice.Value,
                SalePrice = (double)nudSalePrice.Value,
                Quantity = (int)nudQuentity.Value,
                CategoryID = (int)cbCategory.SelectedValue,
                Name = txtName.Text
            };

            bool isAdded = ProductService.AddProduct(Product);
            if (isAdded)
            {
                MessageBox.Show("تمت إضافة الصنف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في إضافة الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            List<Product> categories = ProductService.GetAllProducts();
            dgvProduct.DataSource = categories;
        }


        private void FrmProduct_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            LoadCategories();

            List<Category> categories = CategoryService.GetAllCategorys();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "ID";
        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisableWhenEditorDelete();
            txtID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            nudQuentity.Value = Convert.ToDecimal(dgvProduct.CurrentRow.Cells[2].Value);
            nudSalePrice.Value = Convert.ToDecimal(dgvProduct.CurrentRow.Cells[3].Value);
            nudBuyPrice.Value = Convert.ToDecimal(dgvProduct.CurrentRow.Cells[4].Value);
            cbCategory.SelectedValue = dgvProduct.CurrentRow.Cells[5].Value;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisableWhenEditorDelete();
            if (!ValidationInputs()) { return; }

            bool isUpdated = ProductService.UpdateProduct(new Product
            {
                ID = int.Parse(txtID.Text),
                BuyPrice = (double)nudBuyPrice.Value,
                SalePrice = (double)nudSalePrice.Value,
                Quantity = (int)nudQuentity.Value,
                CategoryID = (int)cbCategory.SelectedValue,
                Name = txtName.Text
            });

            if (isUpdated)
            {
                MessageBox.Show("تم تعديل  الصنف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في تعديل الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCategories();


        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DisableWhenEditorDelete();
            if (!ValidationInputs()) { return; }

            if (MessageBox.Show("هل أنت متأكد من حذف هذه الصنف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            bool isDeleted = ProductService.DeleteProduct(int.Parse(txtID.Text));
            if (isDeleted)
            {
                MessageBox.Show("تم حذف الصنف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في حذف الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCategories();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisableWhenEditorDelete();
            if (MessageBox.Show("هل أنت متأكد من حذف جميع الاصناف ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            bool isAllDeleted = ProductService.DeleteAllProduct();
            if (isAllDeleted)
            {
                MessageBox.Show("تم حذف جميع الاصناف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في حذف جميع الاصناف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCategories();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Product> products = ProductService.GetAllProductsbyPattern(txtSearch.Text);
            dgvProduct.DataSource = products;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtSearch.Text = string.Empty;
            nudBuyPrice.Value = 0;
            nudSalePrice.Value = 0;
            nudQuentity.Value = 0;
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }

        #region  Helper Methods

        private void LoadCategories()
        {
            List<Product> categories = ProductService.GetAllProducts();
            dgvProduct.DataSource = categories;
        }
        private bool ValidationInputs()
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم الصنف ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nudBuyPrice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر شراء صالح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nudSalePrice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر بيع صالح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("من فضلك اختر فئة الصنف ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nudQuentity.Value < 0)
            {
                MessageBox.Show("من فضلك ادخل كمية  الصنف ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
