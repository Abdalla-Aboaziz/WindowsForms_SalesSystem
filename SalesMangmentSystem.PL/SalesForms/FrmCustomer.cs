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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidationInputs()) { return; }
            Customer Customer = new Customer
            {
                Name = txtName.Text,
                Phone= txtphonenumber.Text,
                Address= textBox2.Text,// Adress
                BirthData = txtdateofbirth.Value,
            };

            bool isAdded = CustomerServices.AddCustomer(Customer);
            if (isAdded)
            {
                MessageBox.Show("تمت إضافة العميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في إضافة العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            List<Customer> categories = CustomerServices.GetAllCustomers();
            dgvCustomer.DataSource = categories;
        }


        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            LoadCategories();

            
        }

        private void dgvCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisableWhenEditorDelete();
            txtID.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
           
            textBox2.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString(); // Adress
            txtphonenumber.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            txtdateofbirth.Value = Convert.ToDateTime(dgvCustomer.CurrentRow.Cells[4].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisableWhenEditorDelete();
            if (!ValidationInputs()) { return; }

            bool isUpdated = CustomerServices.UpdateCustomer(new Customer
            {
                ID = int.Parse(txtID.Text),
                Name = txtName.Text,
                Phone = txtphonenumber.Text,
                Address = textBox2.Text,// Adress
                BirthData = txtdateofbirth.Value,
            });

            if (isUpdated)
            {
                MessageBox.Show("تم تعديل  العميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في تعديل العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCategories();


        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DisableWhenEditorDelete();
            if (!ValidationInputs()) { return; }

            if (MessageBox.Show("هل أنت متأكد من حذف هذه العميل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            bool isDeleted = CustomerServices.DeleteCustomer(int.Parse(txtID.Text));
            if (isDeleted)
            {
                MessageBox.Show("تم حذف العميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في حذف العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCategories();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisableWhenEditorDelete();
            if (MessageBox.Show("هل أنت متأكد من حذف جميع العملاء ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            bool isAllDeleted = CustomerServices.DeleteAllCustomer();
            if (isAllDeleted)
            {
                MessageBox.Show("تم حذف جميع العملاء بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشل في حذف جميع العملاء", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCategories();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Customer> Customers = CustomerServices.GetAllCustomersbyPattern(txtSearch.Text);
            dgvCustomer.DataSource = Customers;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtSearch.Text = string.Empty;
            txtphonenumber.Text = string.Empty;
            textBox2.Text = string.Empty;// Adress
            txtdateofbirth.Value = DateTime.Now;
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }

        #region  Helper Methods

        private void LoadCategories()
        {
            List<Customer> categories = CustomerServices.GetAllCustomers();
            dgvCustomer.DataSource = categories;
        }
        private bool ValidationInputs()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtphonenumber.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم الهاتف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("من فضلك ادخل العنوان", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
