using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomestayApp
{
    public partial class fmLogin : Form
    {
        QuanLyHomestayEntities db = new QuanLyHomestayEntities();
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            if (Login.testLogin(txtUserName.Text, txtPassWord.Text) == true)
            {
                MessageBox.Show("Đăng nhập thành công.");
                this.DialogResult = DialogResult.OK;
            }

            else
            { 
                MessageBox.Show("Đăng nhập thất bại. Vui lòng đăng nhập lại.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

<<<<<<< HEAD
        private void fmLogin_Load(object sender, EventArgs e)
        {

        }
=======
       
>>>>>>> 6b8ab4e9f5f04f87818064ac28e7849242d8e363
    }
}
