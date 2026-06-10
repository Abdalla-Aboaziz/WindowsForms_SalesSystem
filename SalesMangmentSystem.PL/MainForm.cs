using SalesMangmentSystem.PL.SalesForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesMangmentSystem.PL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
