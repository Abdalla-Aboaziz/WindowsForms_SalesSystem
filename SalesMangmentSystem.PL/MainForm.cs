using SalesMangmentSystem.PL.SalesForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesMangmentSystem.PL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ApplyHoverEffects();
        }

       
        private void ApplyHoverEffects()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button btn)
                {
                    btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(4, 150, 255);
                    btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(60, 60, 65);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.ShowDialog();
        }

        private void SaleOrder_Click(object sender, EventArgs e)
        {
            FrmSaleOrdercs frmSaleOrdercs = new FrmSaleOrdercs();
            frmSaleOrdercs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSaleOrderReport frmSaleOrderReport = new FrmSaleOrderReport();
            frmSaleOrderReport.ShowDialog();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            FrmStockDetails frm = new FrmStockDetails();
            frm.ShowDialog();
        }

       
    }
}