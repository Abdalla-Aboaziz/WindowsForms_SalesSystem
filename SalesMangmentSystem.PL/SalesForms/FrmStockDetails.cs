using SalesMangmentSystem.BLL.Dtos;
using SalesMangmentSystem.BLL.Services;
using SalesMangmentSystem.DAL.Models;
using Type = SalesMangmentSystem.DAL.Models.Type;

namespace SalesMangmentSystem.PL.SalesForms
{
    public partial class FrmStockDetails : Form
    {
        public FrmStockDetails()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        //
        private void FrmStockDetails_Load(object sender, EventArgs e)
        {





        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }




        private void btnDelete_Click(object sender, EventArgs e)
        {





        }







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

        }

        private void nudCategoryCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudTotalInvoice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch1_Click(object sender, EventArgs e)
        {
            List<SaleOrderReadProductDto> saleOrders = SaleOrderService.GetAllSaleOrderDateRange(Convert.ToDateTime(DtpFromDate.Value), Convert.ToDateTime(DtpToDate.Value));

            dgvSaleOrder.DataSource = saleOrders;
            nudTotalInvoice.Value = (decimal)saleOrders.Sum(so => so.ProductTotalPrice);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch2_Click(object sender, EventArgs e)
        {
            List<SaleOrderReadProductDto> saleOrders = default;
            if (cbByOrderID.Checked)
            {
                saleOrders = SaleOrderService.GetAllSaleOrderWithProducts(default, Convert.ToInt32(txtOrderID.Text));

            }
            else
            {
                saleOrders = SaleOrderService.GetAllSaleOrderWithProducts(Convert.ToString(txtSearchCustomer.Text), default);
            }
            dgvSaleOrder.DataSource = saleOrders;
            nudTotalInvoice.Value = (decimal)saleOrders.Sum(so => so.ProductTotalPrice);
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbByOrderID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbByOrderID.Checked)
            {
                txtOrderID.Enabled = true;        
                txtSearchCustomer.Enabled = false; 
                txtSearchCustomer.Clear();
            }
            else
            {
                txtOrderID.Enabled = false;       
                txtSearchCustomer.Enabled = true;  
                txtOrderID.Clear();
            }
        }
    }
}
