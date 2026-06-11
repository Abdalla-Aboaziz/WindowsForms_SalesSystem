using SalesMangmentSystem.BLL.Dtos;
using SalesMangmentSystem.BLL.Services;
using SalesMangmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Type = SalesMangmentSystem.DAL.Models.Type;

namespace SalesMangmentSystem.PL.SalesForms
{
    public partial class FrmStockDetails : Form
    {
        public FrmStockDetails()
        {
            InitializeComponent();
        }

        private void FrmStockDetails_Load(object sender, EventArgs e)
        {
            dgvSaleOrder.AutoGenerateColumns = false;
            try
            {
                var types = new[]
            {
                new { Text = "مبيعات", Value = Type.Sale },
                new { Text = "مشتريات", Value = Type.Purchase },
                new { Text = "مصروفات", Value = Type.Expenses }
            };

                cbStockName.DataSource = types;
                cbStockName.DisplayMember = "Text";
                cbStockName.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الخزائن: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            txtOrderID.Enabled = false;
        }

        private void btnsearch1_Click(object sender, EventArgs e)
        {

            try
            {
                List<StockReadDto> stockReadDtos = StockService.GetAllSaleOrderDateRange(DtpFromDate.Value, DtpToDate.Value);
                dgvSaleOrder.DataSource = stockReadDtos;

                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message);
            }
        }

        private void btnsearch2_Click(object sender, EventArgs e)
        {

            
                if (string.IsNullOrWhiteSpace(txtOrderID.Text))
                {
                    MessageBox.Show("من فضلك أدخل رقم الفاتورة للبحث", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOrderID.Focus();
                    return;
                }

                try
                {

                    int orderId = Convert.ToInt32(txtOrderID.Text);


                    List<StockReadDto> data = StockService.GetStockDetailsByOrderID(orderId);


                    dgvSaleOrder.DataSource = data;


                    if (data.Count == 0)
                    {
                        MessageBox.Show("لم يتم العثور على حركات بهذا الرقم", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    CalculateTotal();
                }
                catch (FormatException)
                {
                    MessageBox.Show("الرجاء إدخال أرقام صحيحة فقط في حقل الفاتورة", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          
        }

       

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvSaleOrder.Rows)
            {
                if (row.Cells["Column5"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Column5"].Value);
                }
            }
            nudTotalInvoice.Value = total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (cbStockName.SelectedValue == null)
                {
                    MessageBox.Show("من فضلك اختر نوع الحركة أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                int selectedType = (int)cbStockName.SelectedValue;

              
                List<StockReadDto> data = StockService.GetStockDetailsByType(selectedType);

               
                dgvSaleOrder.DataSource = data;

                
                CalculateTotal();

               
                if (data.Count == 0)
                {
                    MessageBox.Show("لا توجد حركات مسجلة بهذا النوع", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}