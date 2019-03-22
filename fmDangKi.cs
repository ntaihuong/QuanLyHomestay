using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomestayApp
{
    public partial class fmDangKi : Form
    {
        QuanLyHomestayEntities db;
        public fmDangKi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbTaikhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            Register rs = new Register();
            if (rs.checkMK(txtMatKhau.Text, txtXNMK.Text)==false)
            {
                MessageBox.Show("mật khẩu xác nhận không đúng", "thông báo", MessageBoxButtons.OKCancel);

            }
            else if (rs.checkTK(txtTaikhoan.Text) != true)
                {
                    TAIKHOAN tk = new TAIKHOAN();
                tk.HoTen = txtHoten.Text;
                tk.Email = txtEmail.Text;
                tk.Matkhau = txtMatKhau.Text;
                tk.TaiKhoan1 = txtTaikhoan.Text;
                tk.Phone = txtPhone.Text;
                    rs.addNew(tk);
                }
                else
                {
                    MessageBox.Show("tên tài khoản đã tồn tại", "thông báo", MessageBoxButtons.OKCancel);
                }
                    
        }

        private void fmDangKi_Load(object sender, EventArgs e)
        {

        }
    }
}
