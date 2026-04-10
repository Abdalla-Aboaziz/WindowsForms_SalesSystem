using SalesMangmentSystem.BLL.Services;
using SalesMangmentSystem.DAL.Models;

namespace SalesMangmentSystem.PL.SalesForms
{
    public partial class FrmSaleOrdercs : Form
    {
        public FrmSaleOrdercs()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidationInputs()) return;

            // 1. احفظ الأوردر
            SaleOrder order = new SaleOrder
            {
                CustomerID = (int)cbCustomer.SelectedValue,
                DateOrder = DateTime.Now,
                TotalOrder = (double)nudSalePrice.Value * (double)nudCategoryCount.Value
            };
            bool isAdded = SaleOrderService.AddSaleOrder(order);
            if (!isAdded)
            {
                MessageBox.Show("فشل في إضافة الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get the new order ID
            int newID = SaleOrderService.GetLastInsertedID();

            // 3. Save order details
            SaleOrderProduct detail = new SaleOrderProduct
            {
                SaleOrderID = newID,
                ProductID = (int)cbCategory.SelectedValue,
                ProductName = cbCategory.Text,
                ProductPrice = (double)nudSalePrice.Value,
                ProductQuantity = (double)nudCategoryCount.Value,
                ProductTotalPrice = (double)nudSalePrice.Value * (double)nudCategoryCount.Value
            };
            SaleOrderProductService.AddOrderProduct(detail);

            MessageBox.Show("تمت إضافة الفاتورة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSaleOrders();
            CalculateTotalInvoice();
        }
        //
        private void FrmSaleOrdercs_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;

            // Load customers and categories into combo boxes

            List<Customer> customers = CustomerServices.GetAllCustomers();
            cbCustomer.DataSource = customers;
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "ID";
            List<Product> products = ProductService.GetAllProducts();
            cbCategory.DataSource = products;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "ID";
            LoadSaleOrders();
                CalculateTotalInvoice();
        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DisableWhenEditorDelete();

            SaleOrderProduct selected = (SaleOrderProduct)dgvProduct.CurrentRow.DataBoundItem;
            txtID.Text = selected.SaleOrderID.ToString();
            nudSalePrice.Value = (decimal)selected.ProductPrice;
            nudCategoryCount.Value = (decimal)selected.ProductQuantity;
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {

            DisableWhenEditorDelete();

           
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("من فضلك اختر فاتورة من القائمة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من حذف هذه الفاتورة؟", "تأكيد الحذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            int orderID = int.Parse(txtID.Text);
            SaleOrderProductService.DeleteByOrderId(orderID);

            bool isDeleted = SaleOrderService.DeleteSaleOrder(orderID);
            if (isDeleted)
                MessageBox.Show("تم حذف الفاتورة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("فشل في حذف الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LoadSaleOrders();
            CalculateTotalInvoice();
        }





        #region  Helper Methods

      
        private void LoadSaleOrders()
        {
            var orders = SaleOrderService.GetAllSaleOrders();
            var allDetails = new List<SaleOrderProduct>();
            foreach (var o in orders)
            {
                var details = SaleOrderProductService.GetByOrderId(o.ID);
                allDetails.AddRange(details);
            }
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = allDetails;
        }
        private bool ValidationInputs()
        {

            if (nudSalePrice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر بيع صالح ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("من فضلك اخترالعميل  ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nudCategoryCount.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل كمية صالحة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void DisableWhenEditorDelete()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;

        }
        private void CalculateTotalInvoice()
        {

            var list = dgvProduct.DataSource as List<SaleOrderProduct>;
            if (list == null) return;
            nudTotalInvoice.Value = (decimal)list.Sum(d => d.ProductTotalPrice);
        }
        #endregion


        //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("من فضلك اختر فاتورة من القائمة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("من فضلك اختر العميل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int orderID = int.Parse(txtID.Text);

            bool isUpdated = SaleOrderService.SaveSaleOrder(new SaleOrder
            {
                ID = orderID,
                CustomerID = (int)cbCustomer.SelectedValue,
                DateOrder = DateTime.Now,
                TotalOrder = (double)nudSalePrice.Value * (double)nudCategoryCount.Value
            });

            SaleOrderProductService.UpdateByOrderId(new SaleOrderProduct
            {
                SaleOrderID = orderID,
                ProductID = (int)cbCategory.SelectedValue,
                ProductName = cbCategory.Text,
                ProductPrice = (double)nudSalePrice.Value,
                ProductQuantity = (double)nudCategoryCount.Value,
                ProductTotalPrice = (double)nudSalePrice.Value * (double)nudCategoryCount.Value
            });

            if (isUpdated)
            {
                MessageBox.Show("تم تحديث الفاتورة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSaleOrders();
                CalculateTotalInvoice();
            }
            else
                MessageBox.Show("فشل في تحديث الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    
    }
}
