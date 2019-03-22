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
            try
            {
                string tk = txtUserName.Text;
                string mk = txtPassWord.Text;
                TAIKHOAN taikhoan = (from i in db.TAIKHOANs where i.TaiKhoan1 == tk && i.Matkhau == mk select i).FirstOrDefault();
                if(taikhoan!=null)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng đăng nhập lại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
