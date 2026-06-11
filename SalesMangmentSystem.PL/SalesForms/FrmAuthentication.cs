using SalesMangmentSystem.BLL.Services; 
using SalesMangmentSystem.DAL.Identity;
using SalesMangmentSystem.DAL.Models; 
using System;
using System.Windows.Forms;

namespace SalesMangmentSystem.PL.SalesForms
{
    public partial class FrmAuthentication : Form
    {
        public FrmAuthentication()
        {
            InitializeComponent();
            ApplyHoverEffects();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("من فضلك أدخل اسم المستخدم وكلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            ApplicationUser user = AuthenticationService.Login(txtUserName.Text, txtPassword.Text);

          
            if (user != null)
            {
                MainForm mainForm = new MainForm();
                mainForm.FormClosed += (s, args) => this.Close();

                mainForm.Show();

                this.Hide();
            }
            else
            {
                
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus(); 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
       
        private void ApplyHoverEffects()
        {
          
            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = System.Drawing.Color.FromArgb(4, 150, 255);

           
            btnExit.MouseEnter += (s, e) => btnExit.BackColor = System.Drawing.Color.FromArgb(200, 35, 51);
            btnExit.MouseLeave += (s, e) => btnExit.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
        }
    }
}