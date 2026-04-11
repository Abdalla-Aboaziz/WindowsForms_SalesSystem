using SalesMangmentSystem.BLL.Dtos;
using SalesMangmentSystem.BLL.Services;
using SalesMangmentSystem.DAL.Models;
using Type = SalesMangmentSystem.DAL.Models.Type;

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
            Product product = ProductService.GetProductById(Convert.ToInt32(cbCategory.SelectedValue));
            if (product != null)
            {
                decimal quantity = Convert.ToDecimal(nudCategoryCount.Value);
                if (quantity > (decimal)product.Quantity)
                {
                    MessageBox.Show("الكمية المطلوبة غير متوفرة في المخزون", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal lineTotal = quantity * (decimal)product.SalePrice;
                // Add Row
                dgvSaleOrder.Rows.Add(

                   product.ID,
                     product.Name,
                     quantity,
                     product.SalePrice,
                     lineTotal
                    );

                // Update Total Invoice
                nudTotalInvoice.Value += lineTotal;
            }

            //LoadSaleOrders();
            //CalculateTotalInvoice();
        }
        //
        private void FrmSaleOrdercs_Load(object sender, EventArgs e)
        {



            List<ProductReadBasicDto> products = ProductService.GetAllBasicProducts();
            cbCategory.DataSource = products;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "ID";

            List<CustomerReadBasicDto> customers = CustomerServices.GetAllBasicCustomer();
            cbCustomer.DataSource = customers;
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "ID";

            txtID.Text = (SaleOrderService.GetLastInsertedID() + 1).ToString();

           
        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.RowIndex == dgvSaleOrder.NewRowIndex) return;

            DataGridViewRow row = dgvSaleOrder.Rows[e.RowIndex];

           
            if (row.Cells[0].Value != null)
            {
               
                nudCategoryCount.Value = Convert.ToDecimal(row.Cells[2].Value);

            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {

            //DisableWhenEditorDelete();


            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("من فضلك اختر فاتورة من القائمة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("هل أنت متأكد من حذف هذه الفاتورة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                if (dgvSaleOrder.CurrentRow.Cells[0].Value != null)
                {

                    int index = dgvSaleOrder.CurrentRow.Index;
                    decimal lineTotal = Convert.ToDecimal(dgvSaleOrder.Rows[index].Cells[4].Value);

                    // Remove Row
                    dgvSaleOrder.Rows.RemoveAt(index);
                    //Update Total Invoice
                    nudTotalInvoice.Value -= lineTotal;
                    MessageBox.Show("تم حذف الفاتورة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("فشل في حذف الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



          
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
            if (dgvSaleOrder.Rows.Count > 0)
            {
                // Insert Sales Order 

                SaleOrder saleOrder = new SaleOrder
                {
                    ID = Convert.ToInt32(txtID.Text),
                    CustomerID = Convert.ToInt32(cbCustomer.SelectedValue),
                    DateOrder = DateTime.Now,
                    TotalOrder = Convert.ToDouble(nudTotalInvoice.Value)
                };
                // Insert Sales Order Products
                List<SaleOrderProduct> saleOrderproducts = new List<SaleOrderProduct>();

                for (int i = 0; i < dgvSaleOrder.Rows.Count - 1; i++)
                {
                    saleOrderproducts.Add(new SaleOrderProduct
                    {
                        SaleOrderID = Convert.ToInt32(txtID.Text),
                        ProductID = Convert.ToInt32(dgvSaleOrder.Rows[i].Cells[0].Value),
                        ProductQuantity = Convert.ToDouble(dgvSaleOrder.Rows[i].Cells[2].Value),
                        ProductPrice = Convert.ToDouble(dgvSaleOrder.Rows[i].Cells[3].Value),
                        ProductTotalPrice = Convert.ToDouble(dgvSaleOrder.Rows[i].Cells[4].Value)
                    });

                }
                // Update Product (for quantity in stock)
                List<Product> products = new List<Product>();
                for (int i = 0; i < dgvSaleOrder.Rows.Count - 1; i++)
                {
                    products.Add(new Product
                    {
                        ID = Convert.ToInt32(dgvSaleOrder.Rows[i].Cells[0].Value),
                        Quantity = Convert.ToDouble(dgvSaleOrder.Rows[i].Cells[2].Value)
                    });
                }
                Stock stock = new Stock
                {
                    ID = 1, // Assuming you have only one stock
                    TotalMoney = Convert.ToDouble(nudTotalInvoice.Value),
                };
                // Update4 Stock
                StockDetails stockDetails = new StockDetails
                {
                    StockID = 1, // Assuming you have only one stock
                    Date = DateTime.Now,
                    Total = Convert.ToDouble(nudTotalInvoice.Value),
                    Type = Type.Sale,
                };
                bool IsSaleOrderInserted = SaleOrderService
                    .InsertSaleOrderTransaction(
                    saleOrder,
                    saleOrderproducts,
                    products,
                    stock,
                    stockDetails
                    );
                if (IsSaleOrderInserted)
                {
                    MessageBox.Show("تم حفظ الفاتورة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("فشل في حفظ الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Clear Form
                dgvSaleOrder.Rows.Clear();
                txtID.Text= string.Empty;
                nudTotalInvoice.Value = 0;
                nudCategoryCount.Value = 1;
                txtID.Text = (SaleOrderService.GetLastInsertedID() + 1).ToString(); 


            }
        }


    }
}
